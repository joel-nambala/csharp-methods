using System;

namespace methods
{
    class Methods
    {
        static void Main(string[] args)
        {
            // Call methods
            PrintMessage();

            // Method with arguments
            PrintName("Joel", "Nambala", "Nairobi");

            // Method with multiple data types
            Introduce("Joel Nambala", 22, "Computer programing");

            // Method with default parameters
            WhereAmI("Switzerland", "Cern");

            // Method returning a value
            int age = CalculateAge(1998);
            Console.WriteLine(age);

            string retirement = RetirementCheck("Joel Nambala", 1967);
            Console.WriteLine(retirement);

            // Named arguments
            FindLastborn(child2:"John", child3:"Liam", child1:"Joel");
        }

        // Creating methods
        // Method to print message to the console
        static void PrintMessage()
        {
            Console.WriteLine("My first method in C Sharp");
        }

        // Methods with parameters
        static void PrintName(string firstName, string lastName, string city)
        {
            string str = $"My name is {firstName} {lastName}, and I come from {city}.";
            Console.WriteLine(str);
        }

        // Multiple parameters with different data type
        static void Introduce(string fullName, int age, string course)
        {
            string introduce = $"Good morning, My name is {fullName} and I am {age} years old. I persue {course}";
            Console.WriteLine(introduce);
        }

        // Methods with default parameters
        static void WhereAmI(string country = "Kenya", string city = "Nairobi")
        {
            string location = $"I am currently in {city}, {country}.";
            Console.WriteLine(location);
        }

        // Return values from a method
        static int CalculateAge(int birthYear)
        {
            int age = 2037 - birthYear;
            return age;
        }

        // Return a string value
        static string RetirementCheck(string fullName, int birthYear)
        {
            int age = 2037 - birthYear;
            int retirementAge = 70 - age;
            string retirement;

            if(retirementAge > 0)
            {                
                retirement = $"{fullName} retires in {retirementAge} years.";
            }
            else
            {
                retirement = $"{fullName} is already retired.";
            }

            return retirement;
        }

        // Named arguments
        static void FindLastborn(string child1, string child2, string child3)
        {
            string lastborn = $"The last born in this family is {child3}";
            Console.WriteLine(lastborn);
        }
    }
}