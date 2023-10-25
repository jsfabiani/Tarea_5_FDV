# Tarea_5_FDV
Crear un nuevo proyecto en Unity, seleccionando la opción 2D. Para el seguimiento de las sesión será necesario descargar, la colección de sprites zombies y el atlas de sprites globinsword.
Atlas de sprites: Imagen que se puede dividir en múltiples imágenes con recursos para el juego: secuencias animadas de personajes, elementos de adorno, armas, etc. La carga de todos los recursos en una única imagen es más eficiente que cargar cada una de las imágenes en que se pueda subdividir. 
- Crear una carpeta Sprites y dentro una carpeta Zombies y otra Goblin. Importar las imágenes como los nuevos assets en el proyecto. Las animaciones de cada zombie puede estar organizadas en subcarpetas.
- Creamos los scripts para controlar el movimiento para el personaje Zombie. Hacer una versión sin salto y otra con salto, para lo cual es mejor que sea un objeto físico y añadimos una fuerza. Creamos un objeto para presentar el personaje, añadir los scripts necesarios para moverlo por la pantalla. En este caso sólo tendremos que mover las coordenadas (X, Y). Tendremos que usar además las clases Rigidbody2D y Vector2 o Transform y Vector3. Además necesitamos que el sprite se oriente hacia donde camina, podemos hacerlo usando la propiedad Flip en el eje X en función de si se está moviendo hacia la izquierda (movimiento negativo) o hacia la derecha (movimiento positivo). El suelo se considera en la y = 0
    SpriteRenderer spriteRenderer;
    spriteRenderer.flipX
- Crear el movimiento salto para el zombie, el objeto será físico y se logrará aplicando una fuerza vertical. Si no se implementa adecuadamente el zombie volará. Se debe controlar si está en el suelo o no, a través del evento OnCollider2D comprobar si se está en el suelo, en cuyo caso se desactiva un flagSalto. Por otra parte, si se pulsa la tecla del salto, y no está saltando aplicar una fuerza vertical. Activar un flagSalto para saber que ya saltó. Se puede comprobar si está en el suelo recuperando el gameobject del objeto Collision en el evento OnCollision2D.
- Crear las animaciones del personaje Zombie: Cuando disponemos de una colección de imágenes para crear una animación agregamos un GameObject vacío. A continuación, seleccionamos la colección de scripts que forman la animación y la arrastramos al personaje. De esa forma Unity crea un objeto Animation, la primera vez que se crea, también añade un objeto Animator Controller.
Con la animación seleccionada podemos arrastrar el objeto jugador e ir visualizando las animaciones.
En la pestaña Animator disponemos de una interfaz gráfica que nos permite definir de forma visual la máquina de estados que controla la animación. Por defecto, del estado inicial (Entry) se pasa a la animación Idle. Las transiciones pueden estar controladas por parámetros que nos permitirán definir scripts asociados controlados por valores que tome el parámetro.
private Animator animator;
animator = GetComponent<Animator>();
animator.SetBool("isWalking", true);

- Agregar un sprite zombie, con un collider2D, y crear un script, en el que el zombie, al colisionar con él cambie la animación a Dead.

- Crear las animaciones de Goblin. Añadir un script al zombie, para que al colisionar con Goblin, Goblin active la animación de atacar.
