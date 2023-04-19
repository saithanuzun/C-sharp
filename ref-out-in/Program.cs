// we are not allowed to overload methods based on ref and out keywords.


class Program
{
    static void Main(string[] args)
    {
        int myNumber = 0;
        Increase(ref myNumber);
        
        Decrease(out int myNumber2);
        
        WriteToConsole(myNumber2);
        
        
    }
    
    static void Increase(ref int i)
    {
        Console.WriteLine("Value received inside method :" + i);
        i += 10;
        Console.WriteLine("Updated value inside method :" + i);
    }

    static void Decrease(out int i)
    {
        i = 11;
        Console.WriteLine("Value received inside method :" + i);
        i -= 10;
        Console.WriteLine("Updated value inside method :" + i);
    }
    
    //Readonly
    static void WriteToConsole(in int number)
    {
        // number = 5; causes error
        Console.WriteLine("number: " + number);
    }
}