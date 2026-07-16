# Práctica universitaria de C# (2022): Mover un personaje con WASD con físicas realistas (Unity)
08/01/2022
## ASOCIAR UN CÓDIGO A UN ELEMENTO (AL JUGADOR)
- Script: PlayerController
-En el Inspector →  Add Component.
-Buscamos Script y le damos a New Script, y lo titulamos en este caso “PlayerController”.
-Se nos pondrá el script en el Inspector, y debemos hacer doble click en el script de PlayerController.
-Se nos abrirá el editor de código (yo ahora usaría VSC pero en 2022 cuando hice esta práctica usaba Sublime Text).
- CÓDIGO DE PlayerController EN ESTE REPOSITORIO.
-Cuando tengamos el script de jugador basta con importarlo en Project y arrastrarlo a la Jerarquía.
* Hay comentarios // dentro del script que explican lo que hace cada línea.

## FÍSICAS REALES
- Empuja al objeto como si le dieras un toque con el dedo. Tiene inercia, resbala, rebota y frena poco a poco.
- El jugador se desplaza lateralmente. No rota para mirar a dónde va, simplemente se desliza en los ejes X y Z.

## LA OTRA OPCIÓN: RÍGIDO (SCRIPT POR DEFECTO DE UNITY)
- El otro script (PlayerControllerDefault) es el que pone Unity por defecto para mover un objeto.
- Es más feo, más matemático y con movimientos muy rígidos (frenadas en seco, puede atravesar paredes y rota).

## CONTEXTO
- Motor gráfico Unity 2018
- Lenguaje C#
