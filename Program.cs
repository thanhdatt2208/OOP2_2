public class Vector
{
    private float x;

    private float y;
    public float X { get => x; set => x = value; }
    public float Y { get => y; set => y = value; }

    public Vector(float x_, float y_)
    {
        x = x_;
        y = y_;
    }
    public void PrintVector()
    {
        Console.WriteLine($"({x}, {y})");
    }

    public Vector Add(Vector v)
    {
        return new Vector(x + v.x, y + v.y);
    }

    public Vector Sub(Vector v)
    {
        return new Vector(x - v.x, y - v.y);
    }

    public float Mal(Vector v)
    {
        return x * v.x + y * v.y;
    }

    public bool Orth(Vector v)
    {
        return Mal(v) == 0;
    }
    static void Main(string[] args)
    {
        Vector v1 = new Vector(3, 4);
        Vector v2 = new Vector(4, -3);

        Console.Write("Vector 1 ");
        v1.PrintVector();

        Console.Write("Vector 2 ");
        v2.PrintVector();

        Console.Write("Vector 1 + Vector 2 =  Vector");
        Vector sum = v1.Add(v2);
        sum.PrintVector();

        Console.Write("Vector 1 - Vector 2 = Vector");
        Vector difference = v1.Sub(v2);
        difference.PrintVector();

        float dotProduct = v1.Mal(v2);
        Console.WriteLine($"Dot Product: {dotProduct}");

        bool isOrthogonal = v1.Orth(v2);
        Console.WriteLine($"Are vector 1 and vector 2 Orthogonal?: {isOrthogonal}");
        Console.ReadKey();
    }
}