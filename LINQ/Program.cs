/* LINQ methods
 * filtering => where, ofType
 * sorting => OrderBy ,OrderByDescending,ThenBy, ThenByDescending , Reverse
 * grouping => GroupBy
 * Join => Join
 * Project => Select ,SelectMany
 * Aggregation => Average , Count , Max, Min , Sum
 * Quantifiers => All , Any, Contains,
 * Elements => ElementAt , ElementAtOrDefault,First, FirstOrDefault , Last, LastOrDefault ,Single,SingleOrDefault
 * Set Operation => Distinct , Except , Intersect, Union
 * Partitioning => Skip, SkipWhile, Take , TakeWhile
 * concatenation => Concat
 * Equality => SequenceEqual
 * Generation => DefaultEmpty ,Empty, Range, Repeat
 * Conversion => AsEnumerable ,AsQueryable, Cast ,ToArray ,ToDictionary ,ToList
*/

using System.Security.Cryptography.X509Certificates;
using Bogus;
class Employee
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string City { get; set; }
    public int Salary { get; set; }
}
class Person
{
    public string Name { get; set; }
    public string Email { get; set; }
}
class Program
{
    public static void Main(string[] args)
    {
        //fake data generator
        var employeeFaker = new Faker<Employee>("en")
            .RuleFor(i => i.Id, i => i.Random.Guid())
            .RuleFor(i => i.Name, i => i.Person.FullName)
            .RuleFor(i => i.City, i => i.Address.City())
            .RuleFor(i => i.Email, i => i.Person.Email)
            .RuleFor(i => i.Salary, i => i.Company.Random.Int(0,5000));
        
        var employees = employeeFaker.Generate(100);
        
        //filtering
        var result = employees.Where(i => i.Name.Contains('a'));
        var result2 = employees.OfType<Employee>();
        // Sorting
        var result3 = employees.OrderBy(i => i.Salary);
        var result4 = employees.OrderByDescending(i => i.Salary)
            .ThenBy(i => i.Name).Reverse();
        // grouping 
        
        
        /* Elements
         * first and last  cannot return null they return invalidOperationException 
         * firstOrDefault and lastOrDefault can return null
         * single singleordefault , if there is  more than one matching element, it throws invalid exception
         * for singleordefault it returns null instead of invalid exception
         */
        var result5 = employees.FirstOrDefault(i  => i.Salary < 2000);
        var result6 = employees.ElementAt(2);
        var result7 = employees.ElementAtOrDefault(2);
        
        //project
        // Select and SelectMany
        var result8 = employees.Select(i => new Person() {Name = i.Name , Email = i.Email});

        // Aggregations
        var result9 = employees.Min(i => i.Salary);
        var result10 = employees.Max(i => i.Salary);
        var result11 = employees.Average(i => i.Salary);
        var result12 = employees.Count();
        var result13 = employees.Sum(i => i.Salary);
        
        

    }
}