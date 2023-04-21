/* string is immutable . That means , it cannot be modified
 * methods : toUpper , split ,startswith , endswith , trim , tolower, substring,tochararray
 * methods : contains, replace ,equals, indexof, format,join,lastindexof
 * methods: isnullorempty, compareto, isnullorwhitespace
 */

class Program
{
    public static void Main(string[] args)
    {
        string str = "hello world";

        str = str.ToUpper();
        Console.WriteLine(str);

        str = str.ToLower();
        Console.WriteLine(str);

        str = str.Substring(2, 4);
        Console.WriteLine(str);

        str = str.Replace('l', 'w');
        Console.WriteLine(str);

        str = " how are you ";
        var split = str.Split("w");
        Console.WriteLine(split[0]);

        str = str.Trim();
        Console.WriteLine("=" + str + "=");

        var array = str.ToCharArray();
        Console.WriteLine(array[0]);

        str = String.Join('-', new List<string?>() { "how", "are", "you" });
        Console.WriteLine(str);

        char[] CharArray = new char[] { 'h', 'e', 'l', 'l', 'o' };
        str = new string(CharArray);
        Console.WriteLine(str);

        string a = "a";
        string b = "b";
        bool equals = string.Equals(a, b);
        Console.WriteLine(equals); //overload this method for checking classes

        bool startsWith = str.StartsWith('m');
        Console.WriteLine(startsWith);

        bool EndsWith = str.EndsWith('u');
        Console.WriteLine(EndsWith);

        bool Contains = str.Contains("ou");
        Console.WriteLine(Contains);

        var indexOf = str.IndexOf("ll");
        Console.WriteLine(indexOf);

        var lastIndex = str.LastIndexOf("ll");
        Console.WriteLine(lastIndex);

        string director = "Sam Raimi", movie = "Spider Man";
        str = string.Format("{0} is the director of  {1}", director, movie);
        Console.WriteLine(str);

        str = str.Insert(1, "-insert-");
        Console.WriteLine(str);

        str = str.Remove(1, 8);
        Console.WriteLine(str);
    }
}