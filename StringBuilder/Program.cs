/*
 * string builder is mutable
 * in string class , it creates new object every time you modified it
 * therefore, the stringBuilder class is better choice for manipulation of string
 * where you do not have many strings to deal with,
 * you should consider just do the operations without using the StringBuilder class.
 * But in scenarios where you need to deal with a big quantity of strings,
 * you should consider using the StringBuilder class because this will have a positive impact on the performance of your application and definitely this is a better choice.
 */

using System.Text;

class Program
{
    static void Main(string[] args)
    {
        StringBuilder sb = new StringBuilder("Example of ");
        sb.Append("string concatenation");
        Console.WriteLine(sb);
        
        StringBuilder sb2 = new StringBuilder("Example of ");
        sb2.Append("string concatenation with StringBuilder");
        sb2.Replace("StringBuilder", "the StringBuilder class");
        Console.WriteLine(sb2);
        
        Console.WriteLine(sb2.MaxCapacity);
        
        Console.WriteLine(sb2.Insert(2,true));
        
        Console.WriteLine(sb2.Clear());
    }
}