public class Rectangle : Shape
{
    private double _width;
    private double _weight;

    public Rectangle (string color, double width, double weight) : base (color)
    {
        _width = width;
        _weight = weight;
    }

    public override double GetArea()
    {
        return _width * _weight;
    }
}