# ProjectC
Design patterns: 
- Model-View-Controller: <br>
pt a separa data(model), UI(view) si logica programului (controller) <br>
L-am folosit in clasele: Pokemon, GameView si GameController

- Singleton pattern: <br>
Clasa GameMechanics

- Factory Method: <br>
Obiectele sunt cei 2 pokemoni (Gengar si Raichu)
- Strategy pattern: <br> 
Pt implementarea diferitelor strategii de atac


Unit tests:
Se pot folosi teste pt. acuratete, calcularea daunelor, probabilitatea unui hit critical si selectia de atac.

1. Model <br>
	Clasele: Pokemon, Attacks si Game Mechanics <br>
	Metode de procesare pt. 'damage', 'critical hits', 'random attack selection'

2. View <br>
	Interfata console-based

3. Controller <br>
	Game flow, turn-based actions, comunicarea dintre model si view <br>
	Implementeaza logica meciului si determina un castigator	

Jocul functioneaza asa:<br>
Sunt 2 pokemoni, amandoi au 100 hp si 3 atacuri diferite, codul poate sa fie modificat in asa fel incat jocul sa se joace singur, userul sa aleaga un pokemon si sa il controleze...etc. 
