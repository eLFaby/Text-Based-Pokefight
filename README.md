<h2>Design patterns:</h2> <br>
Strategy Pattern:<br>
Attack.cs<br><br>

Observer Pattern:<br>
Pokemon.cs<br><br>

Singleton Pattern:<br>
GameController.cs<br><br>


<h2>Unit tests:</h2>
AttackTests.cs <br>
Testeaza daca lovitura e valida si daca exista o lovitura critica sau nu <br><br>
PokemonTests.cs <br>
Se asigura ca in urma unui atac, hp-ul celui atacat a scazut. <br><br>
GameControllerTests.cs<br>
Testeaza conditiile de Game Over (Cand unul din pokemoni ajunge la 0 hp) <br><br>


Jocul functioneaza asa:<br>
Sunt 2 pokemoni, amandoi au 100 hp si 3 atacuri diferite, fiecare pokemon ataca pe rand cu o abilitate aleasa random pana unul din ei ramane cu 0 hp. Exista mecanica de lovitura critica care dubleaza damage-ul.
