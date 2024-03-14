using PrototypePattern.Interfaces;
using PrototypePattern.Service;

Console.WriteLine("Rectangle");
Console.WriteLine();
IFigure figure = new Rectangle(30, 40);
IFigure cloned = figure.Clone();
figure.GetInfo();
cloned.GetInfo();

Console.WriteLine("Circle1");
Console.WriteLine();

Circle figure1 = new Circle(10);
IFigure clonedCircle = figure1.Clone() as Circle;
figure1.GetInfo();
clonedCircle.GetInfo();

Console.WriteLine("Circle2");
Console.WriteLine();

Circle2 circle = new Circle2(10,4,6);
Circle2 clonedCircle2 = circle.Clone() as Circle2;
circle.GetInfo();
circle.Point.X = 15;
clonedCircle2.GetInfo();

Console.WriteLine("Circle3");
Console.WriteLine();
Circle2 circle2 = new Circle2(30, 50, 60);
// применяем глубокое копирование
Circle2 clonedFigure = circle2.DeepCopy() as Circle2;
circle2.Point.X = 100;
circle2.GetInfo();
clonedFigure.GetInfo();