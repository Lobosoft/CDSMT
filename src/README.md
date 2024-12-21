# CDSMT
Código fuente de algunos ejemplos correspondientes a estimaciones de tráfico para el curso "Competencias digitales para el sector de la movilidad y el transporte"

## Contenido de las carpetas
Se describe brevemente el contenido de cada carpeta:

    - **BestPath**: Implementación en C# de los algoritmos de búsqueda en grafos Dijkstra y A estrella (o A asterisco). Se presentan a modo de ejemplo para ilustrar cómo estos algoritmos pueden usarse dentro de las tecnologías que permiten el cálculo de rutas óptimas en movilidad, bien para el cálculo de rutas óptimas en desplazamientos de tráfico como en gestión de flotas.
	Se trata de un ejemplo muy básico pero quería que ilustrase el contenido de los temas del trabajo de investigación.
	- **Data**: Datos de intensidades de tráfico de la ciudad de Málaga. Es la información sobre movilidad que proporciona el ayuntamiento, aunque el formato es en PDF y requiere de su extracción y procesado para ser usado. La frecuencia es trimestral y lo ideal sería contar con datos masivos diarios para el uso en big data.
	- **DummyData**: Datos ficticios, aleatorios o generados de forma pseudoaleatoria basándose en datos reales extraídos de `Data`.
	- **Jupyter Notebooks**: Varios archivos notebook con código en Python, usando información de `DummyData` para presentar ejemplos de procesamiento y uso de información de tráfico y explotación de datos que es posible realizar a partir de ellos.
	- **TrafficGenerator**: Dos aplicaciones de consola programadas en C# con generación de datos de tráfico aleatorios pero basados en un patrón para el uso en los scrips de Python, además de generación de datos basados en históricos presentes en Data para proporcionar una mayor cantidad de información para entrenamiento y test de la red neuronal incluida en los scripts de Python, pero basados en un subconjunto de viales.

