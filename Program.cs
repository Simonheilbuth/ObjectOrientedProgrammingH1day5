
using ObjectOrientedProgrammingH1day5.Code;






Animal cat = AnimalFactory.CreateAnimal(enmAnimals.Cat);
Console.WriteLine($"kattens navn er {cat.Name}");
cat.MakeSound();

Animal dog = AnimalFactory.CreateAnimal(enmAnimals.Dog);
Console.WriteLine($"hundens navn er {dog.Name}");
dog.MakeSound();

Animal sheep = AnimalFactory.CreateAnimal(enmAnimals.Sheep);
Console.WriteLine($"fårs navn er {sheep.Name}");
sheep.MakeSound();

Console.ReadKey();
