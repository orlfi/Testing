using FigureLibrary;

namespace Figures.ConsoleTest;

/// <summary>
/// Легкость добавления других фигур
/// Описывает фигуру прямоугольника
/// </summary>
public class Rectangle : Figure
{
    public double Width { get; }
    public double Height { get; }

    public Rectangle(double width, double height)
        => (Width, Height) = (width, height);

    public override double CalcArea()
    {
        return Width * Height;
    }
}
