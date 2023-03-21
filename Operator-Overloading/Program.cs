/*  Operators
*   + - * /
*   == =! < > <= >=
*   true false 
*   && || ?? ? += -= *= /=
*/

public class Number
{
    public decimal Value { get; set; }
    public int Precision { get; set; }

    public Number(decimal value)
    {
        Value = value;
    }

    public static Number operator +(Number number1, Number number2)
    {
        return new Number(number1.Value + number2.Value);
    }

    public static Number operator +(Number number1, int number2)
    {
        return new Number(number1.Value + number2);
    }

    public static bool operator ==(Number number1, Number number2)
    {
        return number1.Value == number2.Value && number1.Precision == number2.Precision;
    }

    public static bool operator ==(Number number1, int number2)
    {
        return number1.Value == number2;
    }

    public static bool operator !=(Number number1, int number2)
    {
        return number1.Value != number2;
    }

    public static bool operator !=(Number number1, Number number2)
    {
        return number1.Value != number2.Value;
    }

    public static bool operator true(Number number) => number.Value > 0;
    public static bool operator false(Number number) => number.Value <= 0;
}

public class User
{
    public int Id { get; set; }

    public string FullName { get; set; }

    public static bool operator ==(User u1, User u2) => u1.Id == u2.Id;
    public static bool operator !=(User u1, User u2) => u1.Id != u2.Id;

    public static bool operator true(User user) => user.Id > 0 && !string.IsNullOrEmpty(user.FullName);
    public static bool operator false(User user) => user.Id <= 0 || string.IsNullOrEmpty(user.FullName);
}

class Program
{
    static void Main(String[] args)
    {
        // Number
        Number number1 = new Number(0);
        Number number2 = new Number(10);
        
        Console.WriteLine(number1);
        Console.WriteLine(number1==number2);
        Console.WriteLine(number1+number2);
        Console.WriteLine(number1!=number2);
        
        if (number2)
        {
            Console.WriteLine(number1.Value);
        }
        
        // User

        User user1 = new User() { FullName = "saithanuzun", Id = 1 };
        User user2 = new User() { FullName = "saithanuzun2", Id = 2 };

        if (user1)
            Console.WriteLine("not empty");

        Console.WriteLine(user1==user2);
        
        
    }
}