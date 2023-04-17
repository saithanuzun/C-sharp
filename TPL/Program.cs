
class Program 
{
    static void Main() 
    {
        // Multithreading
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        Parallel.ForEach(numbers, (number) => {
            
            // Process each number in parallel
            
            Console.WriteLine("Processing number {0} on thread {1}", number, Task.CurrentId);
            Thread.Sleep(new Random().Next(100, 1000));
        });

        Console.WriteLine("All numbers processed.");

    }
}