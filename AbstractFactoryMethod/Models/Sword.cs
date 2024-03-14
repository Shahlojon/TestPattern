using AbstractFactoryMethod.Models.BaseModels;

namespace AbstractFactoryMethod.Models;

class Sword : Weapon
{
    public override void Hit()
    {
        Console.WriteLine("Бьем мечом");
    }
}
