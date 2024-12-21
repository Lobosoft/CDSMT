
# Algoritmos de Búsqueda de Rutas: Dijkstra y A*

## Introducción

En este proyecto, se implementan dos algoritmos clásicos utilizados para encontrar la ruta más corta entre dos puntos en un grafo: **Dijkstra** y **A***. Estos algoritmos son fundamentales en el campo de la informática y se utilizan en aplicaciones como la navegación de mapas, la planificación de rutas, la inteligencia artificial, y mucho más. Para el propósito que nos ocupa, vienen a ilustrar su uso en el cálculo de rutas óptimas dentro de la movilidad sostenible en la ciudad de Málaga, aunque los datos usados son muy básicos y viene a darse como parte de lo que vendría a ser un proyecto a mayor escala donde se podría integrar para los objetivos que persigue el trabajo en el que se integra.

## ¿Qué es un grafo?

Un **grafo** es una estructura matemática compuesta por **nodos** (o vértices) y **aristas** (o conexiones) entre esos nodos. Los nodos pueden representar lugares, y las aristas pueden representar caminos o distancias entre esos lugares. El objetivo de los algoritmos de búsqueda de rutas es encontrar el camino más corto o el más eficiente entre dos nodos en el grafo.

## Algoritmo de Dijkstra

### ¿Cómo funciona Dijkstra?

El **algoritmo de Dijkstra** es uno de los métodos más conocidos para encontrar el camino más corto entre un nodo inicial y todos los demás nodos en un grafo en el que las aristas tienen un costo asociado. Este algoritmo es útil cuando no tienes información extra sobre la "dirección" del objetivo (como en un mapa de carreteras sin una meta específica en mente).

### Pasos de Dijkstra:
1. Comienza en el nodo de inicio.
2. Marca la distancia de este nodo a sí mismo como 0 (porque no se necesita ir a ningún lado).
3. Para cada nodo vecino, calcula la distancia desde el nodo de inicio y actualiza la distancia si es más corta que la previamente registrada.
4. Marca el nodo actual como visitado y pasa al nodo no visitado con la distancia más corta.
5. Repite este proceso hasta llegar al nodo de destino.

Dijkstra garantiza que encontrará el camino más corto, pero no tiene en cuenta ningún conocimiento adicional sobre la ubicación del destino (por ejemplo, la heurística).

### Ventajas de Dijkstra:
- Garantiza encontrar el camino más corto en grafos con pesos no negativos.
- Es eficiente cuando se trata de encontrar la ruta más corta entre un punto de inicio y todos los demás nodos.

### Desventajas de Dijkstra:
- Puede ser lento y consumir muchos recursos cuando el grafo es grande.
- No tiene en cuenta la "dirección" del objetivo, por lo que puede explorar muchos caminos innecesarios.

## Algoritmo A*

### ¿Cómo funciona A*?

El **algoritmo A\*** es una versión mejorada de Dijkstra. A diferencia de Dijkstra, A* usa una **heurística**: una estimación de lo lejos que está el destino desde un nodo determinado. Esto le permite ser más "inteligente" al decidir qué camino seguir.

A* calcula el **costo total estimado** de un nodo como la suma de:
- **g(n)**: El costo desde el nodo de inicio hasta el nodo actual (igual que Dijkstra).
- **h(n)**: La heurística que estima el costo restante para llegar al destino.

La fórmula para A* es:
```
f(n) = g(n) + h(n)
```

### Pasos de A*:
1. Comienza en el nodo de inicio.
2. Calcula el valor **f(n)** para cada nodo vecino (suma del costo acumulado hasta el nodo actual y la heurística estimada al destino).
3. Elige el nodo vecino con el valor **f(n)** más bajo y explóralo.
4. Repite este proceso hasta llegar al nodo de destino.

A* es mucho más eficiente que Dijkstra en muchos casos, porque al usar la heurística, puede enfocarse en las rutas que están más cerca del destino.

### Ventajas de A*:
- Es más rápido que Dijkstra cuando se tiene una buena heurística, ya que explora menos nodos.
- Puede ser muy eficiente en mapas y gráficos con una "dirección clara", como en la navegación GPS.

### Desventajas de A*:
- Requiere una buena heurística, que no siempre es fácil de obtener.
- Si la heurística es inexacta, puede comportarse de manera similar a Dijkstra.

## Comparación entre Dijkstra y A*

| Característica     | **Dijkstra**                                   | **A\***                                      |
|--------------------|-----------------------------------------------|---------------------------------------------|
| **Heurística**     | No utiliza heurística, solo el costo real.    | Utiliza una heurística que estima el costo restante al objetivo. |
| **Eficiencia**     | Menos eficiente para encontrar el objetivo, explora muchos nodos. | Más eficiente al enfocarse en rutas cercanas al objetivo gracias a la heurística. |
| **Ideal para**     | Encontrar el camino más corto desde un nodo a todos los demás. | Encontrar el camino más corto entre dos nodos específicos cuando se tiene una buena heurística. |
| **Casos de uso**   | Redes de carreteras sin conocimiento adicional del destino, cálculo de rutas entre todos los nodos. | GPS, planificación de rutas en entornos con un destino claro. |

### ¿Cuándo usar Dijkstra?
- Cuando no tienes una heurística confiable.
- Cuando necesitas calcular el camino más corto entre un nodo y todos los demás nodos en el grafo.
- En redes con costos no negativos y cuando no importa mucho la eficiencia.

### ¿Cuándo usar A*?
- Cuando tienes una heurística razonable que puede estimar el costo hasta el destino.
- Cuando buscas eficiencia y el objetivo es encontrar el camino entre dos nodos específicos en un grafo grande.
- En aplicaciones de navegación como los GPS o videojuegos donde el destino es conocido.

## Conclusión

Ambos algoritmos, Dijkstra y A*, son poderosos para encontrar rutas en un grafo, pero tienen diferentes ventajas dependiendo del contexto. Dijkstra es más simple y siempre garantiza la mejor solución, pero A* es más eficiente cuando se tiene una buena heurística para guiar la búsqueda.

Si eres nuevo en programación, no te preocupes si no entiendes todos los detalles matemáticos. Lo más importante es que ahora sabes cuándo y por qué usar cada algoritmo, y cómo se aplican en problemas del mundo real.

¡Espero que esta explicación te haya ayudado a comprender mejor estos dos algoritmos y cómo se comparan!
