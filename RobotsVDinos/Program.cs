

using RobotsVDinos;

List<Weapon> weapons = new List<Weapon>();
Herd herd = new Herd();
Fleet fleet = new Fleet();
string answer;
Menu();

//Set up the game
void SetupGame()
{
    weapons = CreateWeapons();
    herd = CreateHerd();
    fleet = CreateFleet(weapons);
}

void NewGame()
{
    SetupGame();
    Game();
}

void Game()
{

    Console.WriteLine("WELCOME TO ROBOTS VERSUS ALIENS!");
    Console.WriteLine("--------------------------------");
    int roundNumber = 1;
    while(fleet.robots.Count > 0 && herd.dinosaurs.Count > 0)
    {
        Round(fleet.robots[0], herd.dinosaurs[0], roundNumber);
    }
}

void Round(Robot robot, Dinosaur dino, int roundNumber)
{
    Console.WriteLine("ROUND " + roundNumber + ":");
    Console.WriteLine("--------");
    Console.WriteLine(robot.Name.ToUpper() + " versus " + dino.Type.ToUpper() + ".  FIGHT!");
    int turnCount = 1;
    Thread.Sleep(1000);
    while(robot.Health > 0 && dino.Health > 0)
    {
        Turn(robot, dino, turnCount);
        turnCount++;
    }
    //If Robot loses
    if (robot.Health <= 0) 
    { 
        Console.WriteLine(robot.Name.ToUpper() + " IS DEFEATED!  " + dino.Type.ToUpper() + " WINS!");
        fleet.robots.Remove(robot);
    }

    //If Dino wins
    if (dino.Health <= 0) 
    { 
        Console.WriteLine(dino.Type.ToUpper() + " IS DEFEATED!  " + robot.Name.ToUpper() + " WINS!" );
        herd.dinosaurs.Remove(dino);
    }
    roundNumber++;
}


void Turn(Robot robot, Dinosaur dino, int turnNumber)
{
    Console.Clear();
    Console.WriteLine("TURN " + turnNumber + ": FIGHT!");
    Console.WriteLine("-----------------------------");
    Console.WriteLine();
    robot.Attack(dino);
    dino.Attack(robot);
    Console.ReadLine();
}


List<Weapon> CreateWeapons()
{
    //Create and populate weapons list and weapons
    Weapon sword = new Weapon("sword", 3);
    Weapon halberd = new Weapon("halberd", 3);
    Weapon mace = new Weapon("mace", 3);

    weapons.Add(sword);
    weapons.Add(halberd);
    weapons.Add(mace);

    return weapons;
}

Fleet CreateFleet(List<Weapon> weapons)
{
    //Create and populate fleet and robots
    Robot c3p0 = new Robot("c3po", weapons[0]);
    Robot robo = new Robot("robo", weapons[0]);
    Robot r2d2 = new Robot("r2d2", weapons[0]);
    fleet.robots.Add(c3p0);
    fleet.robots.Add(robo);
    fleet.robots.Add(r2d2);

    return fleet;
}

Herd CreateHerd()
{
    //Create and populate herd and dinos
    Dinosaur rex = new Dinosaur("Rex");
    Dinosaur tbone = new Dinosaur("TBone");
    Dinosaur max = new Dinosaur("Max");
    herd.dinosaurs.Add(rex);
    herd.dinosaurs.Add(tbone);
    herd.dinosaurs.Add(max);

    return herd;
}

void Header()
{
    Console.WriteLine("           ROBOTS VERSUS DINOSAURS              ");
    Console.WriteLine("------------------------------------------------");
}

void Menu()
{
    Header();
    Console.WriteLine("MENU");
    Console.WriteLine("----------------");
    Console.WriteLine("New Game     - N");
    Console.WriteLine("Resume Game  - R");
    Console.WriteLine("Quit Game    - Q");
    Console.WriteLine("Show Weapons - W");
    Console.WriteLine("Show Fleet   - F");
    Console.WriteLine("Show Herd    - H");
    string answer = Console.ReadLine();
    Router(answer);
}

void Router(string answer)
{
    switch (answer)
    {
        case "N":
            NewGame();
            break;
        case "F":
            ShowFleet();
            break;
        case "H":
            ShowHerd();
            break;
        case "W":
            ShowWeapons();
            break;
        default:
            Console.WriteLine("That was not a valid entry.  Please try again:");
            Console.WriteLine("----------------------------------------------");
            Menu();
            break;
    }
}


void ShowFleet()
{
    Console.Clear();
    Console.WriteLine("THE FLEET");
    Console.WriteLine("----------------------------------------");
    Console.WriteLine();
    Console.WriteLine("NAME    WEAPON    ATTACK POWER  POWER LEVEL  HEALTH");
    Console.WriteLine("---------------------------------------------------");
    foreach (Robot robot in fleet.robots)
    {
    Console.WriteLine($"{robot.Name.ToUpper()}    {robot.Weapon.Type.ToUpper()}  {robot.Weapon.AttackPower} {robot.PowerLevel}%   {robot.Health}%");
    }
        answer = Console.ReadLine();
}

void ShowHerd()
{
    Console.Clear();
    Console.WriteLine("THE HERD");
    Console.WriteLine("----------------------------------------");
    Console.WriteLine();
    Console.WriteLine("TYPE   ATTACK POWER  ENERGY  HEALTH");
    Console.WriteLine("-----------------------------------");
    foreach (Dinosaur dino in herd.dinosaurs)
    {
        Console.WriteLine($"{dino.Type.ToUpper()}    {dino.AttackPower}  {dino.Energy}% {dino.Health}%");
    }
    answer = Console.ReadLine();
}

void ShowWeapons()
{
    Console.Clear();
    Console.WriteLine("Here is the list of available weapons:");
    Console.WriteLine();
    Console.WriteLine("NAME      ATTACK POWER");
    Console.WriteLine("----------------------");
    int space;
    foreach (Weapon weapon in weapons)
    {
        string output = weapon.Type.ToUpper() + " ";
        if (output.Length < 10)
        {
            int count = 10 - output.Length;
            for (int i = 0; i < count; i++)
            {
                output += " ";
            }
        }
        output += weapon.AttackPower;
        Console.WriteLine(output);
    }
}