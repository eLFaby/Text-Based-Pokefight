<h2>Design patterns:</h2> 
Strategy Pattern:<br>
Attack.cs<br><br>

Observer Pattern:<br>
Pokemon.cs<br><br>

Singleton Pattern:<br>
GameController.cs<br><br>


<h2>Unit tests:</h2>
AttackTests.cs <br>
Tests if the attack is valid and if it was a critical hit.<br><br>
PokemonTests.cs <br>
Makes sure that the hp of the opponent drops after an attack. <br><br>
GameControllerTests.cs<br>
Test the Game Over conditions<br><br>


<h2>The game:</h2>
There are 2 pokemons, each of them has 100 hp and 3 different attacks they can use. The game is turn-based and the abilities each pokemon uses are selected at random with 10% chance of a critical hit. The game ends when one pokemon loses enough hp to reach 0.

<h2>About the main files:</h2> 
<h3>GameController.cs:</h3><br><br>

This file contains the GameController class, which follows the Singleton design pattern. It ensures that only one instance of the GameController is created throughout the program.<br>
The GameController class manages the game logic, including initializing the Pokémon instances (Gengar and Raichu) and starting the game.<br>
It has properties for accessing the Gengar and Raichu instances and a GameOver property to determine if the game is over.<br>
The StartGame() method runs the game loop, where Pokémon attack each other until one of them has zero HP. It also displays the winner at the end.<br><br>
<h3>Pokemon.cs:</h3><br><br>

This file contains the Pokémon class, which represents a Pokémon character in the game.<br>
The Pokémon class has properties such as Name, HP (Hit Points), and Attacks (a list of attack strategies).<br>
It also has methods like DisplayStatus() to show the Pokémon's information and PerformAttack() to execute an attack on a target Pokémon.<br>
The Pokémon class uses the Observer design pattern implicitly. Other objects can observe the Pokémon instance to receive updates when its HP changes.<br><br>
<h3>Attack.cs:</h3><br><br>

This file contains the Attack class, which represents an attack strategy that a Pokémon can use.<br>
The Attack class has properties such as Name, MinDamage, and MaxDamage, which define the attack's characteristics.<br>
It implements the IAttackStrategy interface, which provides the necessary methods for calculating damage and checking for critical hits.
