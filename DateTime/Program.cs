/*
 * 
 */

class Program
{
    static void Main(string[] args)
    {
        //Create a DateTime object:
        DateTime currentDate = DateTime.Now; // Current date and time
        DateTime specificDate = new DateTime(2023, 4, 6); // April 6, 2023
        
        //Access properties of DateTime:
        int year = currentDate.Year; // Get the year
        int month = currentDate.Month; // Get the month
        int day = currentDate.Day; // Get the day


        //Perform operations on DateTime
        DateTime tomorrow = currentDate.AddDays(1); // Add one day
        DateTime lastMonth = currentDate.AddMonths(-1); // Subtract one month
        TimeSpan difference = currentDate - specificDate; // Calculate the time difference


        //Format DateTime:
        string formattedDate = currentDate.ToString("yyyy-MM-dd"); // Format as "2023-04-06"
        string formattedTime = currentDate.ToString("HH:mm:ss"); // Format as "14:30:00"


        //Parse a string to DateTime:
        string dateString = "2023-04-06";
        DateTime parsedDate = DateTime.Parse(dateString);


        //Compare DateTime objects:
        bool isEarlier = specificDate < currentDate;
        bool isSameDay = specificDate.Date == currentDate.Date;
    }
}