using AbstractFactoryMethod.Models.BaseModels;

namespace AbstractFactoryMethod.Models;
// движение полета
class FlyMovement : Movement
{
    public override void Move()
    {
        Console.WriteLine("Летим");
    }
}
