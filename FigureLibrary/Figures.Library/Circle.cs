using System;

namespace FigureLibrary;

/// <summary> Определяет фигуру окружности. </summary>
public class Circle : Figure
{
    /// <summary> Радиус окружности. </summary>
    public double Radius { get; }

    public Circle(double radius)
    { 
        if (radius <= 0)
            throw new ArgumentOutOfRangeException(nameof(radius), "Радиус должен быть больше 0");

        Radius = radius; 
    }

    /// <summary> Вычисляет площадь круга Pi*R*R</summary>
    /// <returns> Площадь круга</returns>
    public override double CalcArea()
    {
        return Math.PI * Math.Pow(Radius, 2);
    }
}
