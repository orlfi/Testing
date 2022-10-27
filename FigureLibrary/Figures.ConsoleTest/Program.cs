using FigureLibrary;
using Figures.ConsoleTest;

Figure circle = new Circle(3);
Console.WriteLine($"Площадь окружности: {circle.CalcArea()}");

Figure triangle = new Triangle(10, 10, 10);
Console.WriteLine($"Площадь треугольника: {triangle.CalcArea()}");

var rightTriangle = new Triangle(8, 6, 10);
Console.WriteLine($"Прямоугольный? {rightTriangle.IsRightAngled}");

Figure rectangle = new Rectangle(10, 20);
Console.WriteLine($"Площадь прямоугольника: {rectangle.CalcArea()}");

Figure square = new Square(10);
Console.WriteLine($"Площадь квадрата: {square.CalcArea()}");

