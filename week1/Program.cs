Console.Write("Please provide your mame for adventure registration card: ");
string name = Console.ReadLine();

Console.Write("Race or species: ");
string species = Console.ReadLine();

Console.Write("Role: ");
string role = Console.ReadLine();

Console.Write("What is your level? ");
int level = int.Parse(Console.ReadLine());

Console.Write("What is your Strength Stat? ");
int strength = int.Parse(Console.ReadLine());

Console.Write("What is your Agility Stats? ");
int agility = int.Parse(Console.ReadLine());

Console.Write("What is your Intelligence Stats? ");
int intel = int.Parse(Console.ReadLine());

//calc of power
double power = (strength*2) + (agility*1.5) + (intel*1) + (level*5);

//output
Console.WriteLine();
Console.WriteLine("================================");
Console.WriteLine("   ADVENTURER GUILD PROFILE     ");
Console.WriteLine("================================");
Console.WriteLine($"Name:         {name}           ");
Console.WriteLine($"Race/Species: {species}        ");
Console.WriteLine($"Role:         {role}           ");
Console.WriteLine("--------------------------------");
Console.WriteLine($"Level:        {level}          ");
Console.WriteLine($"Strength:     {strength}       ");
Console.WriteLine($"Agility:      {agility}        ");
Console.WriteLine($"Intelligence: {intel}          ");
Console.WriteLine("--------------------------------");
Console.WriteLine($"Power:        {power:F2}       ");
Console.WriteLine("================================");

Console.Readline();