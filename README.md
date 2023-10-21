# ProyectoSODVI_Equipo8
 Este repositorio contendrá todos los archivos relacionados al juego de nivel 1 del equipo 8 (Endless Runner)

## Movimiento
int FuerzaDeSalto - Fuerza con la que salta el personaje
bool EnElPiso - Inidca si el personaje esta en conacto con el piso

### Update
Al presionar tecla espacio y se deteca que no esta en contacto con el piso el personaje va a saltar

### OnColLisionEnter2D
Si el personaje colisiona con objetos indica que esta en contacto con el piso, si este objeto tiene tag "obstaculo" el personaje se destruira, el tiempo del juego se pausara y se activara el menu de perder
