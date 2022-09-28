<h1>Patrones de diseño utilizados en el proyecto:</h1>

<h2>Memento</h2>
<img src="https://refactoring.guru/images/patterns/cards/memento-mini.png"></img>
<h3>Memento es un patrón de diseño de comportamiento que te permite guardar y restaurar el estado previo de un objeto sin revelar los detalles de su implementación.
En este caso es utilizado para que el game manager sea capaz de guardar los puntajes de los jugadores,los cuales convertimos en datos privados de esta clase, y los guarde en una clase externa y puedan ser obtenidos a partir de esta ultima. Evitando de esta manera que la pantalla final del juego deba acceder a las variables publicas del gamemanager para obtenerlas.</h3>

<h2>Singleton</h2>
<img src="https://refactoring.guru/images/patterns/cards/singleton-mini.png"></img>
<h3>Singleton es un patrón de diseño creacional que nos permite asegurarnos de que una clase tenga una única instancia, a la vez que proporciona un punto de acceso global a dicha instancia. En este caso es utilizado para mantener con vida en distintas escenas a un mismo audio source y mantener, de esta manera, la musica sonando sin interrupciones.</h3>

<h2>Flyweight</h2>
<img src="https://refactoring.guru/images/patterns/cards/flyweight-mini.png"></img>
<h3>Flyweight es un patrón de diseño estructural que te permite mantener más objetos dentro de la cantidad disponible de RAM compartiendo las partes comunes del estado entre varios objetos en lugar de mantener toda la información en cada objeto. En este caso es utilizado para mantener varios datos como la dificultad o un booleano sobre si la partida es multiplayer o no a traves de scriptable objects que persisten en el juego. De esta manera no es necesario tener diferentes objetos con esta data en diferentes escenas y se ahorran recursos.</h3>

<h2>Observer</h2>
<img src="https://refactoring.guru/images/patterns/cards/observer-mini.png"></img>
<h3>Observer es un patrón de diseño de comportamiento que te permite definir un mecanismo de suscripción para notificar a varios objetos sobre cualquier evento que le suceda al objeto que están observando. En este caso se utiliza para que el game manager no se encargue de cambiar de escena al final del juego sino que el menu manager se encargue de suscribirse al evento del mencionado anteriormente cuando termina el juego y al momento de recibir la señal realice el cambio de escena.</h3>
