using AbstractFactoryMethod.Models;

Hero hero = new(new ElfFactory());
hero.Hit();
hero.Run();

hero = new(new VoinFactory());

hero.Hit();
hero.Run();
Console.ReadLine();