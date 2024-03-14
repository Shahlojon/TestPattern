using PrototypePattern.Interfaces;

namespace PrototypePattern.Service;

internal class Circle : IFigure
{
    int radius;

    public Circle(int r)
    {
        radius = r;
    }
    public IFigure Clone()
    {
#pragma warning disable CS8603 // Possible null reference return.
        return MemberwiseClone() as IFigure;
#pragma warning restore CS8603 // Possible null reference return.
    }

    public void GetInfo()
    {
        Console.WriteLine("Круг радиусом {0}", radius);
    }
}
