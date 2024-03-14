using AbstractFactoryMethod.Models.BaseModels;

namespace AbstractFactoryMethod.Models;

// движение - бег
class RunMovement : Movement
{
    public override void Move()
    {
        Console.WriteLine("Бежим");
    }
}
