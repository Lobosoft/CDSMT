
# Generador de datos aleatorios de tráfico

## Descripción

Este programa genera un archivo CSV con datos simulados de tráfico para un período de varios años. Los datos de tráfico se generan en función de una serie de valores base predefinidos que representan el tráfico de vehículos por hora durante un día, considerando dos direcciones de tráfico (Sentido Norte y Sentido Sur). Los datos generados se guardan en un archivo CSV llamado `TrafficData.csv`.

### Características:
- El programa genera tráfico para un número de años especificado.
- Los datos se generan para cada día y cada hora del día.
- El tráfico varía según las horas del día, con mayores volúmenes de tráfico en las horas pico.
- El archivo resultante contiene columnas para el año, día, hora, tráfico en el Sentido Norte y tráfico en el Sentido Sur.

## Formato de salida de la ejecución

3. **Salida**: El programa genera un archivo CSV que contiene los registros de tráfico generados de forma aleatoria. El archivo tiene la siguiente estructura:

    ```
    Año,Día,Hora,SentidoNorte,SentidoSur
    ```

    - **Año**: El año de la simulación.
    - **Día**: El día del año (de 1 a 365).
    - **Hora**: La hora del día (de 0 a 23).
    - **SentidoNorte**: El tráfico de vehículos en la dirección Norte (un valor aleatorio dentro de un rango definido).
    - **SentidoSur**: El tráfico de vehículos en la dirección Sur (un valor aleatorio dentro de un rango definido).

4. **Salida del archivo CSV**: Los datos generados se guardan en un archivo llamado `TrafficData.csv`.

## Ejemplo de salida

Un ejemplo de las primeras líneas del archivo generado podría ser:

```
Año,Día,Hora,SentidoNorte,SentidoSur
2019,1,0,200,400
2019,1,1,50,100
2019,1,2,600,1200
...
```

## Personalización

Para cambiar el número de años a simular hay que cambiar el valor de inicialización de la variable `years`. 
Para modificar las horas del día o los rangos de tráfico es necesario editar la matriz `seedData`.

## Uso
Se ha utilizado para generar datos usados en los scripts:
    - **Estimación de tráfico.ipynb**: Realiza una estimación del tráfico para un día y hora futuros basándose en los datos existentes y utilizando Random Forest.
# Generador de datos aleatorios de tráfico 2

## Descripción

Este programa genera un archivo CSV con datos simulados de tráfico para un período de varios años basándose en la tabla de intensidades que proporciona el ayuntamiento de Málaga y que lee del fichero `IntensidadesTiempoBase.csv`. Los datos de tráfico se generan con un intervalo del 20 % por defecto por encima o por debajo de los valores existentes. Como mejora podría tenerse en cuenta una tendencia alcistadel tráfico de la ciudad, además de ir ajustando el porcentaje de forma dinámica. Los datos generados se guardan en un archivo CSV llamado `IntensidadesTiempoBase_Actualizado.csv`.
Estos datos se han usado en varios de los algoritmos de ML que ilustran el trabajo ante los problemas y limitaciones de parseo de los PDF del ayuntamiento usando una IA (ChatGPT) con una cuenta gratuita. Lo ideal sería poder contar con datos más detallados y con un formato de fichero que permita su procesado.

## Uso
Se ha utilizado para generar datos usados en los scripts:
    - **Estimación de tráfico futuro usando redes neuronales.ipynb**: Realiza una estimación del tráfico para un día y hora futuros basándose en los datos existentes utilizando una red neuronal LSTM (Long short-term memory), una red neuronal recurrente (RNN) que usa aprendizaje profundo (deep learning) para procesar y predecir secuencias de datos.
	
	- **Vías con  mayor tránsito.ipynb**: Realiza un cálculo de las vías con mayor tránsito, buscando las más transitadas y presentando una tendencia de tráfico para cada una de las vías.
	
	- **Tráfico comparado entre días laborales, sábados y domingos.ipynb**: Presenta una comparación del tráfico entre los días laborables y fines de semana (sábados y domingos) y las tendencias de intensidad media diara por tipo de día.
