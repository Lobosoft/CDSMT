using System;
using System.Collections.Generic;
using System.IO;

class TrafficDataGenerator
{
    static void Main(string[] args)
    {
        // Definimos algunas constantes        
        const int DaysPerYear = 365;
        const int HoursPerDay = 24;

        // El número de años que vamos a procesar y el año de comienzo de la serie
        int years = 6;        
        int startingYear = 2019;

        // Número total de registros a generar
        int totalRecords = years * DaysPerYear * HoursPerDay;

        // Definimos un array semilla con valores constantes para cada hora (0-23).
        // Cada posición del array representa el rango base de tráfico por hora.
        // Por ejemplo, valores más altos en horas pico.
        int[,] seedData = {
            { 100, 400 }, // 00:00 - 01:00
            { 50, 250 },  // 01:00 - 02:00
            { 50, 100 },  // 02:00 - 03:00
            { 50, 100 },  // 03:00 - 04:00
            { 50, 150 },  // 04:00 - 05:00
            { 200, 400 }, // 05:00 - 06:00
            { 500, 1000 },// 06:00 - 07:00
            { 1000, 2000 },// 07:00 - 08:00
            { 1500, 2500 },// 08:00 - 09:00
            { 1200, 2200 },// 09:00 - 10:00
            { 1000, 1800 },// 10:00 - 11:00
            { 900, 1700 },// 11:00 - 12:00
            { 800, 1600 },// 12:00 - 13:00
            { 1000, 2000 },// 13:00 - 14:00
            { 1500, 2500 },// 14:00 - 15:00
            { 2000, 3000 },// 15:00 - 16:00
            { 2500, 3500 },// 16:00 - 17:00
            { 3000, 4000 },// 17:00 - 18:00
            { 3500, 4500 },// 18:00 - 19:00
            { 3000, 4000 },// 19:00 - 20:00
            { 2000, 3000 },// 20:00 - 21:00
            { 1500, 2500 },// 21:00 - 22:00
            { 1000, 2000 },// 22:00 - 23:00
            { 500, 1500 } // 23:00 - 00:00
        };
        
        Random random = new Random();

        // Almacenamiento de los datos generados, comenzando por la cabecera del CSV
        List<string> trafficData = new List<string>();
        trafficData.Add("Año,Día,Hora,SentidoNorte,SentidoSur");
       
        for (int year = 0; year < years; year++)
        {
            for (int day = 1; day <= DaysPerYear; day++)
            {
                for (int hour = 0; hour < HoursPerDay; hour++)
                {
                    int minTrafficA = seedData[hour, 0];
                    int maxTrafficA = seedData[hour, 1];
                    int trafficA = random.Next(minTrafficA, maxTrafficA + 1);

                    int minTrafficB = seedData[hour, 0];
                    int maxTrafficB = seedData[hour, 1];
                    int trafficB = random.Next(minTrafficB, maxTrafficB + 1);

                    string record = $"{year + startingYear},{day},{hour},{trafficA},{trafficB}";
                    trafficData.Add(record);
                }
            }
        }

        string filePath = "TrafficData.csv";
        File.WriteAllLines(filePath, trafficData);

        Console.WriteLine($"Datos generados y guardados en {filePath} ({totalRecords} registros).");
    }
}
