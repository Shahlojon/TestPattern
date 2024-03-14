using StrategyPattern.Interfaces;

namespace StrategyPattern.PatternRealized.CarStrategy;

public class Car(int num, string model, IMovable mov)
{
    protected int passengers = num; // кол-во пассажиров
    protected string model = model; // модель автомобиля

    public IMovable Movable { private get; set; } = mov;

    public void Move()
    {
        Movable.Move();
    }
}
