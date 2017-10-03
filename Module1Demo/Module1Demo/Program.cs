using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module1Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create variables of different data types
            // Initialize with a "default" value
            string firstName, lastName, street, city, country = "";
            int age = 0;
            DateTime birthDate;

            // Assign some values
            firstName = "John";
            lastName = "Smith";
            age = 17;
            street = "1010 Sub Sandwich Street";
            city = "Fries";
            country = "Lunch";
            birthDate = new DateTime(2017, 1, 1);

            // Output to the console window

            // Use simple output with just variable name
            Console.WriteLine(firstName);
            Console.WriteLine(lastName);

            // Use placeholder style
            Console.WriteLine("{0} years old", age);

            // Use string concatenation
            Console.WriteLine(street + ", " + city + ", " + country);

            //Use string interpolation
            Console.WriteLine($"Born on {birthDate}");
        }
    }
}
