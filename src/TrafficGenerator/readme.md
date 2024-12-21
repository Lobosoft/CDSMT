
# Generador de Datos de Tráfico

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
