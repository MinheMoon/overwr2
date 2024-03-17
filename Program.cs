public class Weight : IComparable<Weight>, IComparer<Weight>
{
    public int Mass { get; set; }
    public ConsoleColor Color { get; set; }
    public int Size { get; set; }

    public int Compare(Weight x, Weight y)
    {
        return x.Mass.CompareTo(y.Mass);
    }

    public int CompareTo(Weight other)
    {
        return Mass.CompareTo(other.Mass);
    }

    public override bool Equals(object obj)
    {
        if (obj == null || GetType() != obj.GetType())
            return false;

        Weight p = (Weight)obj;
        return (Mass == p.Mass) && (Color == p.Color) && (Size == p.Size);
    }

    public static bool operator ==(Weight a, Weight b)
    {
        return a.Equals(b);
    }

    public static bool operator !=(Weight a, Weight b)
    {
        return !a.Equals(b);
    }

    public static bool operator >(Weight a, Weight b)
    {
        return a.Mass > b.Mass;
    }

    public static bool operator <(Weight a, Weight b)
    {
        return a.Mass < b.Mass;
    }

    public static bool operator >=(Weight a, Weight b)
    {
        return a.Mass >= b.Mass;
    }

    public static bool operator <=(Weight a, Weight b)
    {
        return a.Mass <= b.Mass;
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<Weight> weights = new List<Weight>()
        {
            new Weight { Mass = 10, Color = ConsoleColor.Red, Size = 11 },
            new Weight { Mass = 20, Color = ConsoleColor.Blue, Size = 10 },
            new Weight { Mass = 15, Color = ConsoleColor.Green, Size = 7 }
        };

        Console.WriteLine("Відсортовано за масою:");
        foreach (var weight in weights.OrderBy(w => w.Mass))
        {
            Console.WriteLine($"Mass: {weight.Mass}, Color: {weight.Color}, Size: {weight.Size}");
        }

        Console.WriteLine("Відсортовано за розміром:");
        foreach (var weight in weights.OrderBy(w => w.Size))
        {
            Console.WriteLine($"Mass: {weight.Mass}, Color: {weight.Color}, Size: {weight.Size}");
        }

        Console.WriteLine("Відсортовано за кольором:");
        foreach (var weight in weights.OrderBy(w => w.Color))
        {
            Console.WriteLine($"Mass: {weight.Mass}, Color: {weight.Color}, Size: {weight.Size}");
        }
    }
}
