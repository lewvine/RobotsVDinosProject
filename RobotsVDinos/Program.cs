

using RobotsVDinos;

//Create and populate weapons list and weapons
List<Weapon> weapons = new List<Weapon>();

Weapon sword = new Weapon("sword", 5);
Weapon halberd = new Weapon("halberd", 10);
Weapon mace = new Weapon("mace", 15);

weapons.Add(sword);
weapons.Add(halberd);
weapons.Add(mace);

//Create and populate herd and dinos
Herd herd = new Herd();

Dinosaur rex = new Dinosaur("Rex");
Dinosaur tbone = new Dinosaur("TBone");
Dinosaur max = new Dinosaur("Max");
herd.dinosaurs.Add(rex);
herd.dinosaurs.Add(tbone);
herd.dinosaurs.Add(max);

//Create and populate fleet and robots
Fleet fleet = new Fleet();

Robot c3p0 = new Robot("c3po", sword);
Robot robo = new Robot("robo", sword);
Robot r2d2 = new Robot("r2d2", sword);
fleet.robots.Add(c3p0);
fleet.robots.Add(robo);
fleet.robots.Add(r2d2);

Console.WriteLine("Welcome to Robots versus Dinosaurs!");
Console.WriteLine("In Robots versus Dinosaurs, you play the Robot, and fight against Dinosaurs!" +
    "  Each team has three members");
Console.WriteLine("Ready to get started?  (PLEASE SELECT ENTER)");
Console.ReadLine();
Console.WriteLine("Your three robots are:");
foreach(Robot robot in fleet.robots)
{
    Console.WriteLine($"{robot.Name} equipped with a {robot.Weapon.Type} with an attack value of {robot.Weapon.AttackPower}");
}
Console.WriteLine("Would you like to switch weapons? (TYPE 'YES' OR 'NO')");
string answer = Console.ReadLine();
if (answer == "YES")
{
    Console.WriteLine("Which robot would you like to switch weapons for?");
    foreach (Robot robot in fleet.robots)
    {
        Console.WriteLine($"{robot.Name} -- (TYPE '{fleet.robots.IndexOf(robot)}')");
    }
    Console.ReadLine();
}