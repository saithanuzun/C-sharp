/*
 * 
 */
using System.Text.RegularExpressions;

class Program
{
    public static void Main(string[] args)
    {
        Regex regex = new Regex(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$");
        string? value = Console.ReadLine();
        bool match = regex.IsMatch(value);
        Console.WriteLine(match);
    }
}