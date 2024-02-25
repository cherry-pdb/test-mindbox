namespace Geometry.Figures;

public class Triangle : IShape
{
    private double FirstSide { get; set; }
    private double SecondSide { get; set; }
    private double ThirdSide { get; set; }

    public Triangle(double firstSide, double secondSide, double thirdSide)
    {
        if (firstSide <= 0 || secondSide <= 0 || thirdSide <= 0)
            throw new ArgumentException("Sides must be positive.");
        
        FirstSide = firstSide;
        SecondSide = secondSide;
        ThirdSide = thirdSide;
    }
    
    public double CalculateArea()
    {
        var halfPerimeter = (FirstSide + SecondSide + ThirdSide) / 2;
       
        return Math.Sqrt(halfPerimeter 
                         * (halfPerimeter - FirstSide) 
                         * (halfPerimeter - SecondSide) 
                         * (halfPerimeter - ThirdSide));
    }

    public bool IsRightAngled()
    {
        var firstPow = FirstSide * FirstSide;
        var secondPow = SecondSide * SecondSide;
        var thirdPow = ThirdSide * ThirdSide;

        return firstPow + secondPow == thirdPow 
            || firstPow + thirdPow == secondPow
            || secondPow + thirdPow == firstPow;
    }
}