﻿namespace Demo03
{
    internal class Program
    {
        public class Person
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }

        static void Main(string[] args)
        {
            #region Video1

            // Parse the input to an integer
            //int monthNumber;
            //int.TryParse(Console.ReadLine(), out monthNumber);

            // Conditional statements to determine the month name
            //if (monthNumber == 1)
            //{
            //    Console.WriteLine("Hello January");
            //}
            //else if (monthNumber == 2)
            //{
            //    Console.WriteLine("Hello February");
            //}
            //else if (monthNumber == 3)
            //{
            //    Console.WriteLine("Hello March");
            //}
            //else
            //{
            //    Console.WriteLine("The Entered Month Number is not in the 1st Quarter");
            //} 
            //switch (monthNumber)
            //{
            //    case 1:
            //        Console.WriteLine("Hello January");
            //        break;
            //    case 2:
            //        Console.WriteLine("Hello February");
            //        break;
            //    case 3:
            //        Console.WriteLine("Hello March");
            //        break;
            //    default:
            //        Console.WriteLine("Invalid month number");
            //        break;
            // }
            #endregion

            #region Video2
            // Using if-else
            //Console.Write("Please Enter Your Age: ");
            //string input = Console.ReadLine();
            //if (int.TryParse(input, out int Age))
            //{
            //    // If-else version
            //    if (Age > 22)
            //    {
            //        Console.WriteLine("Your Age is Greater than 22");
            //    }
            //    else if (Age < 22)
            //    {
            //        Console.WriteLine("Your Age is Less than 22");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Your Age equals 22");
            //    }

            //    // Switch statement with relational patterns
            //    switch (Age)
            //    {
            //        case > 22:
            //            Console.WriteLine("Your Age is Greater than 22");
            //            break;
            //        case < 22:
            //            Console.WriteLine("Your Age is Less than 22");
            //            break;
            //        default:
            //            Console.WriteLine("Your Age equals 22");
            //            break;
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input. Please enter a valid integer.");
            //}
            #endregion

            #region Video3

            //// Prompt user for name
            //Console.Write("Please Enter Your Name: ");
            //string Name = Console.ReadLine() ?? "No Name";

            //// Using if-else
            //if (Name == "Ahmed")
            //{
            //    Console.WriteLine("Hello Ahmed");
            //}
            //else if (Name == "Omar")
            //{
            //    Console.WriteLine("Hello Omar");
            //}
            //else if (Name == "Aya")
            //{
            //    Console.WriteLine("Hello Aya");
            //}
            //else if (Name == "Yassmin")
            //{
            //    Console.WriteLine("Hello Yassmin");
            //}
            //else if (Name == "Maged")
            //{
            //    Console.WriteLine("Hello Maged");
            //}

            //// Using switch
            //switch (Name)
            //{
            //    case "Ahmed":
            //        Console.WriteLine("Hello Ahmed");
            //        break;
            //    case "Omar":
            //        Console.WriteLine("Hello Omar");
            //        break;
            //    case "Aya":
            //        Console.WriteLine("Hello Aya");
            //        break;
            //    case "Yassmin":
            //        Console.WriteLine("Hello Yassmin");
            //        break;
            //    case "Maged":
            //        Console.WriteLine("Hello Maged");
            //        break;
            //    default:
            //        Console.WriteLine("Hello, stranger!");
            //        break;
            //}
            #endregion
            #region Video4
            //object input = new object();
            //input = 5; // Boxing
            //input = new Person() { Id = 100, Name = "Ahmed" };

            //switch (input)
            //{
            //    // This checks if input is of type int and greater than 1
            //    case int localInput when localInput > 1:
            //        Console.WriteLine("integer input");
            //        break;

            //    // This checks if input is of type double
            //    case double localInput:
            //        Console.WriteLine("double input");
            //        break;

            //    // This checks if input is of type Person with Id 100
            //    case Person person when person.Id == 100:
            //        Console.WriteLine(person.Name);
            //        break;

            //    // Default case for any other input types
            //    default:
            //        Console.WriteLine("Unknown input");
            //        break;

                    #endregion

            }
    }
}
