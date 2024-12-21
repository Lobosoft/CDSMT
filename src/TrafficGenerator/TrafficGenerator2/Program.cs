using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Globalization;
using System.IO;
using System.Text;
using CsvHelper;
using CsvHelper.Configuration;

public class TrafficData
{
    public int Año { get; set; }
    public int Trimestre { get; set; }
    public int PM { get; set; }
    public string Calle { get; set; }
    public int IMDL { get; set; }
    public int IMDS { get; set; }
    public int IMDD { get; set; }
    public int IMHPL { get; set; }
    public int IMHPS { get; set; }
    public int IMHPD { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        string inputFilePath = "IntensidadesTiempoBase.csv";
        string outputFilePath = "IntensidadesTiempoBase_Actualizado.csv";

        // Cargar datos del archivo CSV original
        List<TrafficData> originalData = LoadCsv(inputFilePath);

        // Generar datos históricos
        List<TrafficData> generatedData = GeneratePastData(originalData, 2020, 2010, new int[] { 1, 2 }, 0.2);

        // Guardar los datos generados en un nuevo archivo CSV
        SaveCsv(outputFilePath, generatedData);

        Console.WriteLine($"Datos generados y guardados en {outputFilePath}");
    }

    static List<TrafficData> LoadCsv(string filePath)
    {
        var config = new CsvHelper.Configuration.CsvConfiguration(CultureInfo.InvariantCulture)
        {
            Encoding = Encoding.GetEncoding("iso-8859-1"),
            Delimiter = ","
        };

        using (var reader = new StreamReader(filePath, Encoding.GetEncoding("iso-8859-1")))
        using (var csv = new CsvReader(reader, config))
        {
            return new List<TrafficData>(csv.GetRecords<TrafficData>());
        }
    }

    static void SaveCsv(string filePath, List<TrafficData> data)
    {
        using (var writer = new StreamWriter(filePath))
        using (var csv = new CsvWriter(writer, new CsvConfiguration(CultureInfo.InvariantCulture) { Delimiter = "," }))
        {
            csv.WriteRecords(data);
        }
    }

    static List<TrafficData> GeneratePastData(List<TrafficData> data, int startYear, int endYear, int[] trimesters, double variation)
    {
        var newRows = new List<TrafficData>();

        foreach (var row in data)
        {
            for (int year = startYear; year >= endYear; year--)
            {
                foreach (var trimester in trimesters)
                {
                    var newRow = new TrafficData
                    {
                        Año = year,
                        Trimestre = trimester,
                        PM = row.PM,
                        Calle = row.Calle,
                        IMDL = AdjustValue(row.IMDL, variation),
                        IMDS = AdjustValue(row.IMDS, variation),
                        IMDD = AdjustValue(row.IMDD, variation),
                        IMHPL = AdjustValue(row.IMHPL, variation),
                        IMHPS = AdjustValue(row.IMHPS, variation),
                        IMHPD = AdjustValue(row.IMHPD, variation)
                    };
                    newRows.Add(newRow);
                }
            }
        }

        return newRows;
    }

    static int AdjustValue(int originalValue, double variation)
    {
        var random = new Random();
        double factor = 1 + random.NextDouble() * (2 * variation) - variation; // Variación en torno al 20%
        return Math.Max(0, (int)(originalValue * factor));
    }
}
