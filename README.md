# Unforgiving Trials: Nightfall's Grasp
Unforgiving Trials: Nightfall's Grasp es un juego de Rol de Acción con Elementos Roguelike ().

En un juego de rol de acción basado en la generación procedural de mazmorras y objetos, el jugador se embarcará en emocionantes aventuras explorando mazmorras llenas de desafíos y tesoros. Cada partida ofrecerá un mundo único, lo que garantiza la rejugabilidad y la emoción constante. A medida que el jugador avanza, recolectará objetos variados, desde armas poderosas hasta artefactos mágicos, que le proporcionarán habilidades especiales y ventajas en la lucha contra enemigos desafiantes.
El objetivo principal será eliminar un jefe final para completar exitosamente la partida. Este jefe será un desafío épico que requerirá estrategia y habilidad para vencer. Con cada intento, el jugador aprenderá más sobre el juego y mejorará su personaje, lo que lo acercará cada vez más a la victoria. Con la combinación de acción frenética, exploración y la emoción de enfrentarse a jefes finales únicos en cada partida, este juego ofrecerá una experiencia de juego dinámica y emocionante que mantendrá a los jugadores comprometidos durante horas de juego.

# Historia
Un alumno de la carrera de Desarrollo de Software Multiplataforma trata de conseguir su título como TSU para ello deberá de enfrentarse a las implacables pruebas que sus profesores tienen para él, para ello deberá de navegar a través de todos los salones en busca de la aprobación de sus clases mientras se enfrenta a sus problemas diarios.

# Especificaciones de desarrollo

## Motor 2D
Desarrollar el videojuego "Unforgiving Trials: Nightfall's Grasp" utilizando un motor 2D, con un enfoque similar al juego "The Binding of Isaac," con el propósito de ofrecer a los jugadores una experiencia emocionante y desafiante. El género de los juegos roguelike y el estilo visual 2D ha demostrado ser exitoso en la industria de los videojuegos. La popularidad de juegos como "The Binding of Isaac" indica una demanda continua por experiencias similares.

<img src="https://github.com/spalomino13/Unforgiving-Trials-Nightfall-s-Grasp/assets/105385260/eb276d74-9de3-49be-be35-d9cf99d90489" width="400px" />


## Clasificacion
El público al que va dirigida esta aplicación es a las personas mayores de 15 años, que buscan una experiencia de juego emocionante y desafiante. Nuestra aplicación ofrece una variedad de juegos y características diseñadas para entretener y estimular la mente de adolescentes y adultos jóvenes, brindando diversión y entretenimiento a aquellos que desean disfrutar de una experiencia de juego enriquecedora.

<img src="https://github.com/spalomino13/U_T_Nightfalls_Grasp/assets/105385260/8a90f138-6794-425e-aa12-4c26a09835e6" width="400px" />

---

# Casos de uso

## Pagina inicial

| Boton | Descripción |
| ----------- | ----------- |
| Iniciar | Mandara a la **Pagina de personajes**. |
| Informacion | Mostrara la **Pagina de informacion** en donde se encuentran las reglas del juego, y especificacion de los objetos en la historia. |
| Opciones | Mostrara distintas opciones que tendra el videojuego |
| Salir | Cerrara el juego. |
 
<img src="https://github.com/spalomino13/Unforgiving-Trials-Nightfall-s-Grasp/assets/105385260/db0351bb-2ca1-492e-8249-1069f8532911" width="700px"/>


#### Vista de la pagina de inicio
<img src="https://github.com/spalomino13/U_T_Nightfalls_Grasp/assets/89074060/297998c0-11ac-40a8-9ee5-f7243926ed80" width="700px"/>


## Pagina de informacion

| Descripcion |
|-----------------------|
| Muestra la historio, los objetos y controles y los objetos especiales. |

<img src="https://github.com/spalomino13/U_T_Nightfalls_Grasp/assets/105385260/eadd4006-af5e-468b-9f30-638836d9ee06" width="700px" />

## Pagina de personajes

| Descripcion |
| ---------------------|
| Muestra a dos personajes los cuales son el principal "Manu" y el segundo "Nao". una vez seleccionado mostrara la **pagina de niveles**. |

<img src="https://github.com/spalomino13/U_T_Nightfalls_Grasp/assets/105385260/996f04f1-c594-4a95-b886-b9b372dfaa9b" width="700px" />

## Pagina de niveles

| Niveles |
|---------------------------------|
| Nivel TSU                       |
| Nivel F                         |

<img src="https://github.com/spalomino13/U_T_Nightfalls_Grasp/assets/105385260/b97878ea-0fd1-4b0d-a08a-5fbb7790f374" width="700px" />

## Dentro de la partida

| Descripcion |
| ---------------------|
| Dentro de la partida el jugador podra moverse hacia arriba, abajo, izquierda y derecha por la sala y dentro de todo el mapa, al igua que podra disparar hacia las mismas direcciones. |

<img src="https://github.com/spalomino13/U_T_Nightfalls_Grasp/assets/105385260/e2012b68-4997-477b-bf05-198086c728a7" width="700px" />

## Elementos en partida

| Nombre | Descripcion |
|--------|--------------|
| Corazones | Es el indicador de la vida que tiene el jugador |
| Barra de daño | Es la indicadora del nivel de daño que tiene el proyectil del jugador |
| Barra de veloacidad | Es el indicador del nivel de veloacidad de movimiento que tiene el jugador |
| Barra de armamento | Es el indicador del nivel de proteccion que tiene el jugador |
| Barra de proyectil | Es el indicador de la cantidad o nivel que tiene el proyectil del jugador |
| Barra de velocidad de disparo | Es el indicador del nivel de la velocidad del disparo del jugador |
| Barra de tiempo | Es el indicador del tiempo que se tiene en una sala de jefe para derrotarlo |
| Mapa | Muestra el mapa en el que se encuentra el jugador |


<img src="https://github.com/spalomino13/Unforgiving-Trials-Nightfall-s-Grasp/assets/105385260/e8f67300-b82a-461e-9a80-d952f088b359" width="700px" />

## Pagina al perder nivel
| Descripcion |
| ---------------------|
| Cuando el jugador pierde la partida le mostrara una pantalla con dos opciones las cuales seran volver a la **pagina de niveles** o reiniciar nivel en caso de que lo decida |

<img src="https://github.com/spalomino13/U_T_Nightfalls_Grasp/assets/105385260/4438723e-b818-4474-86e8-e7c09f9a0a9a" width="700px" />

<img src="https://github.com/spalomino13/U_T_Nightfalls_Grasp/assets/105385260/0e826edc-1b8d-4e25-afbf-0973be3e8cad" width="700px" />

---

# Diseños

## Nivel TSU
<img src="https://github.com/spalomino13/Unforgiving-Trials-Nightfall-s-Grasp/assets/105385260/1b70a033-0956-48a4-87ef-84d32c6e67c4" width="700px" />

## Mapas nivel - TSU
### Mapa 1
<img src="https://github.com/spalomino13/Unforgiving-Trials-Nightfall-s-Grasp/assets/105385260/71ee6939-f900-44b9-ae9e-1603aa164b00" width="700px" />

### Mapa 2
<img src="https://github.com/spalomino13/Unforgiving-Trials-Nightfall-s-Grasp/assets/105385260/dd386919-b4d3-4688-83e9-2c09332fc5a7" width="700px" />

### Mapa 3
<img src="https://github.com/spalomino13/Unforgiving-Trials-Nightfall-s-Grasp/assets/105385260/abe93eef-c007-44a0-89e5-c57613c5e07c" width="700px" />

### Mapa 4
<img src="https://github.com/spalomino13/Unforgiving-Trials-Nightfall-s-Grasp/assets/105385260/f5f2165e-45b9-461f-bc41-ec912a0bc8fe" width="700px" />


## Nivel F
<img src="https://github.com/spalomino13/Unforgiving-Trials-Nightfall-s-Grasp/assets/105385260/ced5f4bc-8d73-484f-93e6-08e6560b12ee" width="700px" />

## Mapas nivel - F
### Mapa 1
<img src="https://github.com/spalomino13/Unforgiving-Trials-Nightfall-s-Grasp/assets/105385260/9d07a8aa-e46d-4def-bd64-33fd08285c8f" width="700px" />

### Mapa 2
<img src="https://github.com/spalomino13/Unforgiving-Trials-Nightfall-s-Grasp/assets/105385260/3259ff2d-2e4f-4f6a-a570-8db74dd0532a" width="700px" />

### Mapa 3
<img src="https://github.com/spalomino13/Unforgiving-Trials-Nightfall-s-Grasp/assets/105385260/82fc8d57-8ecc-46e0-87b0-ade567190685" width="700px" />

### Mapa 4
<img src="https://github.com/spalomino13/Unforgiving-Trials-Nightfall-s-Grasp/assets/105385260/8428288d-5443-47a8-b6d1-045be3676d18" width="700px" />


---

# Reglas del juego (Indicaciones)
- Reglas del juego (Indicaciones)
- Avanza una sala a la vez eliminando a los enemigos que se encuentren en ella.
- Recolecta objetos que te ayudarán a mejorar tus habilidades.
- Recuerda que cuentas con 3 vidas para pasar un mapa.
- Encuentra y llega a la sala del jefe del mapa para enfrentarlo.
  - Con el jefe se complican las cosas ya que cuentas con un límite de tiempo para vencerlo.
  - En caso de que se te acabe el tiempo, pierdes una de las 3 vidas que tienes y reinicias el combate con el jefe.
  - En caso de perder las 3 vidas, se reiniciará el mapa completo.
- Derrota al jefe y muestra que eres digno de pasar al siguiente mapa.
- Avanza 9 mapas derrotando a los enemigos y jefes para avanzar al siguiente nivel.

---

# Aditamentos
Los aditamentos pueden proporcionar mejoras en las habilidades del personaje, como aumentar su fuerza de ataque, velocidad, resistencia o precisión. Esto  permite enfrentar desafíos más difíciles y tener una ventaja sobre los oponentes. Se presentas imagenes de os aditamentos que se podran encontrar en el juego.

| Nombre de aditamento | Forma | Descripcion | valor | 
|----------------------|-------|-------------|-------|
| Libro | <img src="https://github.com/spalomino13/U_T_Nightfalls_Grasp/assets/89074060/6c811ac9-434d-484c-8596-26b1dfee7e76" width="100px" /> | Aumenta el valor en daño | 20 |
| Disquet | <img src="https://github.com/spalomino13/U_T_Nightfalls_Grasp/assets/89074060/f9e6c8af-898d-4687-a3a7-686bf606cf55" width="100px" /> | Aumenta el valor en armamento | 20 |
| Mouse | <img src="https://github.com/spalomino13/U_T_Nightfalls_Grasp/assets/89074060/84c1b935-9b2e-4a37-bd11-12c2f524b974" width="100px" />| Aumenta el valor en velocidad | 20 |
| Audifonos | <img src="https://github.com/spalomino13/U_T_Nightfalls_Grasp/assets/89074060/4751474f-1a09-4480-a907-f18d2fe96a7c" width="100px" />| Aumenta el valor en velocidad de disparo | 20 |

*Los aditamentos se encuentran en la carpeta Assets > Aditamentos*

---

# Especificacion de objetos

| Nombre del objeto | Forma | Descripción |
|-------------------|-------|-------------|
|Sala|<img src="https://github.com/spalomino13/U_T_Nightfalls_Grasp/assets/89074060/69067721-f902-4434-bebb-9f55ed500752" width="100px" />|Este es el fondo que se tendra en los mapas donde se podra mover el personaje|
|Obstaculo de escritorio de equipos de computo|<img src="https://github.com/spalomino13/U_T_Nightfalls_Grasp/assets/89074060/53e230c7-c3cd-4c16-a98f-aff6aa8fe324" width="100px" />|Estos  seran os objetos que se interprestan como ostaculos donde el personaje chocara con este|
|Objeto puerta| <img src="https://github.com/spalomino13/U_T_Nightfalls_Grasp/assets/89074060/88ab3687-4a6e-40c8-9edf-eef1d984b280" width="100px" /> <br> <img src="https://github.com/spalomino13/U_T_Nightfalls_Grasp/assets/89074060/fd8d46e8-3349-4410-af95-17442f77a790" width="100px" />|Objeto que se interpresta como una puerta donde indica que podra pasarlao no dependiendo del estado de la puerta|

*Los objetos se encuentran en la carpeta Assets > Objetos*

---

# Estructura de base de datos

- [x] Id: Int
- [x] Nombre jugador: varchar(50)
- [x] Fecha de nacimiento: Date


---

# Enlace a Trello
https://trello.com/b/lZsKHUDo/unforgiving-trials-nightfalls-grasp

---

## Autores:

**Samuel Palomino Cruz - 1220100206**

**Jonathan Raciel Medina Rivera - 1220100044**

**Universidad Tecnologica del Norte de Guanajuato - 18 de Octubre del 2023**

