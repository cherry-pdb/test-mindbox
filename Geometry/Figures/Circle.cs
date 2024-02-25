namespace Geometry.Figures;

public class Circle : IShape
{
    private double Radius { get; set; }

    public Circle(double radius)
    {
        if (radius < 0)
            throw new ArgumentException("Radius must be non-negative");
        
        Radius = radius;
    }
    
    public double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }
}