class Program
{
    static void Main()
    {
        var source = new CancellationTokenSource();
        var token = source.Token;
        
        var task = Task.Run(() => DoSomething(token), token);
        
        Thread.Sleep(500);
        
        Console.WriteLine("Main::Cancel");
        source.Cancel();
        
        Thread.Sleep(500);
    }
    
    static void DoSomething(CancellationToken token)
    {
        for (int i = 0; i < 100; i++)
        {
            Thread.Sleep(100);
            if (token.IsCancellationRequested)
            {
                Console.WriteLine("Method1 canceled");
                return;
            }
            Console.WriteLine($"Method1 running... {i}");
        }
    }
}