

using RobotsVDinos;

//Set up the game
List<Weapon> weapons = CreateWeapons();
Herd herd = CreateHerd();
Fleet fleet = CreateFleet(weapons);

Menu();
Console.WriteLine("Ready to get started?  (TYPE 'YES' TO GET STARTED)");
string answer = Console.ReadLine();

if(answer == "YES")
{
    Console.Clear();
    Console.WriteLine("GREAT!  Your three robots are:");
    foreach (Robot robot in fleet.robots)
    {
        Console.WriteLine($"{robot.Name} equipped with a {robot.Weapon.Type} with an attack value of {robot.Weapon.AttackPower}");
    }
    Console.WriteLine("Would you like to switch weapons? (TYPE 'YES' OR 'NO')");
    answer = Console.ReadLine();
}

if (answer == "YES")
{
    Console.WriteLine("Which robot would you like to switch weapons for?");
    foreach (Robot robot in fleet.robots)
    {
        Console.WriteLine($"{robot.Name} -- (TYPE '{fleet.robots.IndexOf(robot)}')");
    }
    answer = Console.ReadLine();
}

List<Weapon> CreateWeapons()
{
    //Create and populate weapons list and weapons
    List<Weapon> weapons = new List<Weapon>();

    Weapon sword = new Weapon("sword", 5);
    Weapon halberd = new Weapon("halberd", 10);
    Weapon mace = new Weapon("mace", 15);

    weapons.Add(sword);
    weapons.Add(halberd);
    weapons.Add(mace);

    return weapons;
}

Fleet CreateFleet(List<Weapon> weapons)
{
    //Create and populate fleet and robots
    Fleet fleet = new Fleet();

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
    Herd herd = new Herd();

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