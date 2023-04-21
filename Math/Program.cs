/*
 * 
 */
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(Math.Pow(2,2));
        Console.WriteLine(Math.Min(1,2));
        Console.WriteLine(Math.Floor(10.91));// return the  integer number
        Console.WriteLine(Math.Ceiling(10.91));// next integer number
        Console.WriteLine(Math.Round(10.91));// closest integer number 
        Console.WriteLine(Math.Sign(10.91));// 1 for positive  , 0 for zero , -1 for negative
        Console.WriteLine(Math.Abs(-10.91)); // returns the positive value of given number
        Console.WriteLine(Math.DivRem(10,3));// it is same as % operator 
        Console.WriteLine(Math.Sqrt(16));// square
        
    }
}