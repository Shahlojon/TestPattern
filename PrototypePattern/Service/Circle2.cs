using PrototypePattern.Interfaces;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace PrototypePattern.Service;
[Serializable]
internal class Circle2 : IFigure
{
    public Point Point { get; set; }
    int radius;
    public Circle2(int r, int x, int y)
    {
        radius = r;
        Point = new Point { X=x, Y = y};
    }
    public IFigure Clone()
    {
        return MemberwiseClone() as IFigure;
    }

    public void GetInfo()
    {
       Console.WriteLine("Круг радиусом {0} и центром в точке ({1}, {2})", radius, Point.X, Point.Y);
    }

    public object DeepCopy()
    {
        object figure = null;
        using (MemoryStream tempStream = new MemoryStream())
        {
            BinaryFormatter binFormatter = new BinaryFormatter(null,
                new StreamingContext(StreamingContextStates.Clone));

            binFormatter.Serialize(tempStream, this);
            tempStream.Seek(0, SeekOrigin.Begin);

            figure = binFormatter.Deserialize(tempStream);
        }
        return figure;
    }
}
