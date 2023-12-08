# ProyectoSODVI_Equipo8
 Este repositorio contendrá todos los archivos relacionados al juego de nivel 1 del equipo 8 (Endless Runner)


## Movimiento.cs
Controla el movimiento del perosnaje. Se implmeneto una variable bool 'Salto' para poder conrolar las animacioes del personaje.

### Update()
Al presionar tecla espacio y se deteca que no esta en contacto con el piso el personaje va a saltar.

### OnColLisionEnter2D()
Si el personaje colisiona con objetos indica que esta en contacto con el piso, si este objeto tiene tag "obstaculo" el personaje se destruira, el tiempo del juego se pausara y se activara el menu de perder.


## Mov_Fruta.cs
Controla el movimiento de las frutas.

### Update()
Activa el avance del objeto.

### OnTrigerEnter2D()
Cuando el objeto colisiona con otro con tag "Personaje" se destruira.

### OnBecameInvisible()
En caso de no destruirse por colision, el objeto se destruira al estar fuera de la pantalla.


## Mov_Obstaculo.cs
Controla el movimiento de los obstaculos.

### Update()
Activa el avance del objeto.

### OnBecameInvisible()
El objeto se destruira al estar fuera de la pantalla.


## Spawn_Objetos.cs
Controla la aparcion de comida y obsaculos.

### Start()
Activa los generadores de obstaculos y comida, cada uno con sus respectivos tiempos. 

### Update()
Actualiza el tiempo en el que se van a repetir los SpawnObjetos.

### SpawnObjetos()
Indica la posision en la que va a paecer el nuevo obsaculo (abajo o ariba) y lo crea (entre los generadores).

### SpawnComida()
Inidca la posision en la que va a aparecer la nueva comida, basandose en posisionGen_Com (arriba o abajo) y lo crea.


## Puntuacion.cs
Conrola la puntuacion del jugador con respeco al tiempo.

### Update()
Aumenta el valor de la puntuacion con respeco al tiempo y lo imprime en la pantalla.

### PuntuacionFruta()
Añade la puntuacion de la comida a la puntacion total.

## Pausar.cs
Controla los botones y menus del juego.

### Pausa()
Se le incorpora al boton de pausa.
Detiene el tiempo, desactiva el boton de pausa y activa el menu de pausa.

### Continuar()
Se le incorpora al boton de continuar.
Hace que el tiempo vuelva a avanzar, activa el boton de pausa y desactiva el menu de pausa.

### Reiniciar()
Se le incorpora al boton de reiniciar.
Hace que el tiempo vuelva a avanzar y reinicia la escena "Juego".

### Inicio()
Se le incorpora al boton de incio.
Hace que el tiempo avance (creo que esto a no es necesario), desaciva el menu principal e inicia la escena "Juego".

### Menu()
Se le incorpora al boton que redirige al menu principal.
Inicia la escena "Menu Principal".

## Fondos.cs
Conrola el movimiento de la imagen de fondo (este script ambien se le aplico a la imagen del piso).

### Awake()
Indica el material que se esta utilizando.

### Update()
Modifica el offset (movimiento horizontal) de la imagen.

## Sonido_Boton.cs
Controla el sonido de los botones.

### SoundButton()
Indica que audio se va a reproducir y lo activa y desactiva.
