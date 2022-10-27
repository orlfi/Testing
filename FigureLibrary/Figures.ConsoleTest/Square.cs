namespace Figures.ConsoleTest;

/// <summary>
/// Легкость добавления других фигур
/// Описывает фигуру квадрата (частный случай прямоугольника)
/// </summary>
public class Square : Rectangle
{
    public Square(double side) : base(side, side) { }

}
