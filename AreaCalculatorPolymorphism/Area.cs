using System;

class Area
{
    public double CalculateArea(double radius)
    {
        return 3.14 * radius * radius;
    }

    public double CalculateArea(double length, double breadth)
    {
        return length * breadth;
    }

    public double CalculateArea(double b, double h, bool triangle)
    {
        return 0.5 * b * h;
    }
}