# ProyectoSODVI_Equipo8
 Este repositorio contendrá todos los archivos relacionados al juego de nivel 1 del equipo 8 (Endless Runner)


## Movimiento.cs
Controla el movimiento del perosnaje.

int FuerzaDeSalto - Fuerza con la que salta el personaje
bool EnElPiso - Inidca si el personaje esta en conacto con el piso.

### Update()
Al presionar tecla espacio y se deteca que no esta en contacto con el piso el personaje va a saltar.

### OnColLisionEnter2D()
Si el personaje colisiona con objetos indica que esta en contacto con el piso, si este objeto tiene tag "obstaculo" el personaje se destruira, el tiempo del juego se pausara y se activara el menu de perder.


## Mov_Fruta.cs
Controla el movimiento de las frutas.

int Velocidad - Velocidad en la que se mueven los objetos.

### Update()
Activa el avance del objeto.

### OnTrigerEnter2D()
Cuando el objeto colisiona con otro con tag "Personaje" se destruira.

### OnBecameInvisible()
En caso de no destruirse por colision, el objeto se destruira al estar fuera de la pantalla.


## Mov_Obstaculo.cs
Controla el movimiento de los obstaculos.

int Velocidad - Velocidad en la que se mueven los objetos.

### Update()
Activa el avance del objeto.

### OnBecameInvisible()
El objeto se destruira al estar fuera de la pantalla.


## Spawn_Objetos.cs
Controla la aparcion de comida y obsaculos.

GameObject[] obstaculos - Arreglo de los obstaculos.
GameObject[] comida - Arreglo de la comida.

float tiempoSpawn_Obs = 2 - Tiempo, desde el incio, en el que van a aparecer los obstaculos.
float repetirSpawn_Obs - Tiempo, a partir del primer spawn, en el que van a aparecer los objetos.

Transform GenAbajoD - Generador de obstaculos.
Transform GenAbajoI - Generador de obstaculos.

float tiempoSpawn_Com = 10 -Tiempo, desde el incio, en el que van a aparecer la comida.
float repetirSpawn_Com - Tiempo, a partir del primer spawn, en el que van a aparecer la comida.
float posisionGen_Com - Posiscion en la que va a aparecer la comida, esta puede ser arriba o abajo.

Transform GenAbajo - Generador de comda.
Transform GenArriba - Generador de comda.

### Start()
Activa los generadores de obstaculos y comida, cada uno con sus respectivos tiempos. 

### Update()
Actualiza el tiempo en el que se van a repetir los SpawnObjetos.

### SpawnObjetos()
Indica la posision en la que va a paecer el nuevo obsaculo (entre los generadores) y lo crea.

### SpawnComida()
Inidca la posision en la que va a aparecer la nueva comida, basandose en posisionGen_Com (arriba o abajo) y lo crea.


## Puntuacion.cs
Conrola la puntuacion del jugador con respeco al tiempo.

TMP_Text puntuacion - Texo de la puntuacion (creo que esta de mas).
float valor_p - Valor de la pntuacion.

### Update()
Aumenta el valor de la puntuacion con respeco al tiempo y lo imprime en la pantalla.


## Pausar.cs
Controla los botones y menus del juego.

GameObject botonPausa - Boton de pausa.
GameObject menuPausa - Menu de pausa.
GameObject P_Perdiste - Pantalla que aparece al perder.
GameObject menuPrincipal - Menu principal.

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
