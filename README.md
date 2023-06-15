# ProjectC
Design patterns: 
- Model-View-Controller: 
pt a separa data(model), UI(view) si logica programului (controller)
L-am folosit in clasele: Pokemon, GameView si GameController

- Singleton pattern:
Clasa GameMechanics

Posibil sa fie si: 

- Factory Method: 
Obiectele sunt cei 2 pokemoni (Gengar si Raichu)
- Strategy pattern:
Pt implementarea diferitelor strategii de atac


Unit tests:
Se pot folosi teste pt. acuratete, calcularea daunelor, probabilitatea unui hit critical si selectia de atac.
In program am folosit unit test pentru clasa GameMechanics

1. Model
	Clasele: Pokemon, Attacks si Game Mechanics
	Metode de procesare pt. 'damage', 'critical hits', 'random attack selection'

2. View
	Interfata console-based

3. Controller
	Game flow, turn-based actions, comunicarea dintre model si view
	Implementeaza logica meciului si determina un castigator	
