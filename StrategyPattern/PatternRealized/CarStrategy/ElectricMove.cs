using StrategyPattern.Interfaces;

namespace StrategyPattern.PatternRealized.CarStrategy;

public class ElectricMove : IMovable
{
    public void Move()
    {
        Console.WriteLine("Перемещение на электричестве");
    }
}
