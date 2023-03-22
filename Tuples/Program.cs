class Sample
{
    public Tuple<string, int> GetPersonDetails()
    {
        Tuple<string, int> Person = new Tuple<string, int>("sait", 22);

        return Person;
    }

    public (int id, string name, string email) GetCustomerDetails()
    {
        return (1, "saithanuzun", "saithan.uzun@gmail.com");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Tuple<string, int> Person = new Tuple<string, int>("sait", 22);

        Sample sample = new();
        Console.WriteLine(sample);
        Console.WriteLine(sample.GetPersonDetails().Item1);

        Console.WriteLine(sample.GetCustomerDetails());

        // get details
        (int id, string name, string email) cust = sample.GetCustomerDetails();
        Console.WriteLine(cust.email);
        Console.WriteLine(cust.id);
        Console.WriteLine(cust.name);

        // or 
        (int id, string name, string email) = sample.GetCustomerDetails();
        Console.WriteLine(email);
        Console.WriteLine(id);
        Console.WriteLine(name);

        // discard the value by using underscore 
        (int id2, string name2, _) = sample.GetCustomerDetails();
        Console.WriteLine(id2);
        Console.WriteLine(name2);
    }
}