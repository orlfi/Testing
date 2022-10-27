using System;
using FigureLibrary;
using Xunit;

namespace Figures.Tests;

public class FiguresTests
{
    [Fact]
    public void Circle_AreaOfRadius1_ShouldBe_Pi()
    {
        var circle = new Circle(1);

        var area = circle.CalcArea();

        Assert.Equal(Math.PI, area);
    }

    [Fact]
    public void Circle_IsDescedant_Of_Figure()
    {
        var circle = new Circle(1);

        Assert.IsType<Circle>(circle);
        Assert.True(circle is Figure);
    }

    [Fact]
    public void Tringle_AreaOfEquilateralTriangle_IsValidNumber()
    {
        double correctValue = 43.30127018922193;
        var triangle = new Triangle(10, 10, 10);

        var area = triangle.CalcArea();

        Assert.Equal(correctValue, area);
    }

    [Fact]
    public void Tringle_IsRightAngle_ShouldReturn_True()
    {
        var triangle = new Triangle(4, 3, 5);

        Assert.True(triangle.IsRightAngled);
    }


    public void Tringle_IsDescedant_Of_Figure()
    {
        var triangle = new Triangle(10, 10, 10);

        Assert.IsType<Triangle>(triangle);
        Assert.True(triangle is Figure);
    }

    [Fact]
    public void Tringle_CreationWithWrongSides_ShouldThrowException()
    {
        var expectedMessage = "Specified argument was out of the range of valid values.";

        var exception = Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(-5, 10, 10));
        
        Assert.Equal(expectedMessage, exception.Message);
    }
}