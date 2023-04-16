class Program
{
    private static async Task Main()
    {
        Console.WriteLine("step 1");
        var myTask = GetContent();
        Console.WriteLine("step 2");

        var content = await myTask;
        Console.WriteLine("step 3 = " + content.Length);
        
        
    }

    private static async Task<string> GetContent()
    {
        var content = await  new HttpClient().GetStringAsync("https://www.google.com");
        Console.WriteLine("get content");
        return   content;
    }
}