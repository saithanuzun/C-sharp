/*
 Constraints
 where t : class
 where t : struct
 where t : Classname
 where t : InterfaceName
 where t : new() // which means it cannot be abstract
 
*/

public class MyClass<Type1, Type2> : IDisposable
{
    public Type1 Property1 { get; set; }
    public Type2 Property2 { get; set; }

    public void Dispose()
    {
    }
}

class MyClass2<T> where T : class, IDisposable, new()
{
    public T Method()
    {
        return new T();
    }
}

class Program
{
    public static void Main(string[] args)
    {
        var myClass = new MyClass<string, int>()
        {
            Property1 = "saithanuzun", Property2 = 22
        };

        var myClass2 = new MyClass2<MyClass<string, string>>();

        GenericMethod<MyClass<string, string>>
        (
            new MyClass<string, string>()
            {
                Property1 = "string1", Property2 = "string2"
            }
        );
    }

    private static void GenericMethod<T>(T obj) where T : class
    {
        Console.WriteLine(obj.GetType());
    }
}