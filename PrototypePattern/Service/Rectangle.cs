using PrototypePattern.Interfaces;

namespace PrototypePattern.Service;

internal class Rectangle : IFigure
{
    int width;
    int height;

    public Rectangle(int width, int height)
    {
        this.width = width;
        this.height = height;
    }
    public void GetInfo()
    {
        Console.WriteLine("Прямоугольник длиной {0} и шириной {1}", height, width);
    }

    public IFigure Clone()
    {
        return new Rectangle(this.width, this.height);
    }
}
