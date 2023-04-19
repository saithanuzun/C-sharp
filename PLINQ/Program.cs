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

        //example 2

        var tasks = Enumerable.Range(0, 10).Select(id => Task.Run(async () => await HeavyTask(id)));

        var results = tasks
            .AsParallel()
            .WithDegreeOfParallelism(3)
            .Select(t => t.Result)
            .ToList();

        results.ForEach(Console.WriteLine);
    }

    static async Task<int> HeavyTask(int id)
    {
        Console.WriteLine("Starting Task #" + id);
        await Task.Delay(new Random().Next(3000, 10000));
        Console.WriteLine("Finished Task #" + id);
        return id;
    }

    private static void WriteToConsole(int x)
    {
        Console.WriteLine(x);
    }
}