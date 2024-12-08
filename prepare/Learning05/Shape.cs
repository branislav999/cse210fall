
public class Shape
{
    private string _color;

    public string GetString()
    {
        return _color;
    }

    public void SetString(string color)
    {
        _color = color;
    }

    public Shape(string color)
    {
        _color = color;
    }

    public virtual double GetArea()
    {
        return -1;
    }

}