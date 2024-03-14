using StrategyPattern.Interfaces;

namespace StrategyPattern.PatternRealized.CarStrategy;

public class PetrolMove : IMovable
{
    public void Move()
    {
        Console.WriteLine("Перемещение на бензине");
    }
}
