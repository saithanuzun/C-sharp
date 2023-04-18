namespace PLINQ;

public class Program
{
    private static void Main(String[] args)
    {
        List<int> numbers = Enumerable.Range(1, 100).ToList();

        var evenNumbers = numbers.AsParallel()
            .Where(n => n % 2 == 0)
            .ToList();

        Console.WriteLine("Even numbers: " + string.Join(", ", evenNumbers));
        
        // or 

        var array = Enumerable.Range(1, 100).ToList();

        var newArray = array.AsParallel().Where(x => x % 2 == 0);
        
        newArray.ToList().ForEach(WriteToConsole);
    }

    private static void WriteToConsole(int x)
    {
        Console.WriteLine(x);
    }
}