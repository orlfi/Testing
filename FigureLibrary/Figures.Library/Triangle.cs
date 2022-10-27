namespace FigureLibrary;

/// <summary> Определяет фигуру треугольника. </summary>
public class Triangle : Figure
{
    /// <summary> Сторона A. </summary>
    public double A { get; }

    /// <summary> Сторона B. </summary>
    public double B { get; }

    /// <summary> Сторона C. </summary>
    public double C { get; }

    public bool IsRightAngled => CheckPythagoreanTheorem(A, B, C)
        || CheckPythagoreanTheorem(B, A, C)
        || CheckPythagoreanTheorem(C, A, B);

    public Triangle(double a, double b, double c)
    {
        if (a <= 0 || b <= 0 || c <= 0)
            throw new ArgumentOutOfRangeException();

        (A, B, C) = (a, b, c);
    }

    /// <summary>. Вычисляет площадь треугольника по формуле Герона. </summary>
    /// <returns> Площадь треугольника. </returns>
    public override double CalcArea()
    {
        var p = (A + B + C) / 2; // вычисление полупериметра
        var result = Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        return result;
    }

    private bool CheckPythagoreanTheorem(double hypotenuse, double cathet1, double cathet2)
        => Math.Pow(hypotenuse, 2) == Math.Pow(cathet1, 2) + Math.Pow(cathet2, 2);
}
