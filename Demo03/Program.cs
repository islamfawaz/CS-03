﻿namespace Demo03
{
    internal class Program
    {
        public class Person
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int Age { get; set; }
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

            #region Video5
            // Prompt user for budget
            // Console.Write("Please Enter Your Budget: ");
            //string input = Console.ReadLine();

            //if (int.TryParse(input, out int Budget))
            //{
            //    Console.WriteLine($"Your budget is: {Budget}");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input. Please enter a valid integer.");
            //}
            #endregion

            #region Video6
            //// Using switch
            //switch (Name)
            //{
            //    case "Ahmed" when age >22 && age <30:
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
            //        
            #endregion

            #region Video7


            // Switch Expression [Available in C# 8.0]
            //string option = "1";
            //string Message = option switch
            //{
            //    "1" => "Using Option 1",
            //    "2" => "Using Option 2",
            //    "3" => "Using Option 3",
            //    _ => "Unsupported option"
            //};
            //Console.WriteLine(Message);

            //Person person = new Person { Id = 10, Name = "Ahmed Nasr", Age = 24 };

            //switch (person)
            //{
            //    case Person p when p.Id == 10 && p.Name == "Ahmed Nasr" && p.Age == 24:
            //        Console.WriteLine("Hello Ahmed Nasr, Your Age is 24");
            //        break;
            //    case Person { Id: 10, Name: "Ahmed Nasr", Age: 24 }:
            //        Console.WriteLine("Hello Ahmed Nasr, Your Age is 24");
            //        break;
            //    case Person { Age: 24 }:
            //        Console.WriteLine("Hello, Anonymous. Your Age is 24");
            //        break;
            //    default:
            //        break;
            //}


            #endregion

            #region Video8
            //Person person = new Person { Id = 10, Name = "Ahmed Nasr", Age = 24 };
            //string Message = "";

            //// Switch statement
            //Message = person switch
            //{
            //    { Id: 10, Name: "Ahmed Nasr", Age: > 24 and < 30 } => "Hello Ahmed Nasr, Your Age is between 25 and 29",
            //    { Age: 30 } => "Hello ya Anonymous, Your Age is 30",
            //    _ => "Unknown Person"
            //};

            //Console.WriteLine(Message);
            #endregion

            #region Video9
            //Console.WriteLine(1);
            //Console.WriteLine(2);   
            //Console.WriteLine(3);   
            //Console.WriteLine(4);   
            //    Console.WriteLine(5);
            //    Console.WriteLine(6);
            //Console.WriteLine(7);   
            //Console.WriteLine(8);   
            //    Console.WriteLine(9);
            //    Console.WriteLine(10);

            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(i);
            //}
            #endregion

            #region Video10

            //int[] Numbers = { 9, 3, 10, 2, 8, 10, 6, 5, 1 };


            //for (int i = 0; i < Numbers.Length / 5 /; i++)
            //{
            //    // if (i == 2)
            //    //     break;
            //    Numbers[i] += 10;
            //    Console.WriteLine(Numbers[i]);
            //    Console.WriteLine("******");
            //}

            //foreach (int number in Numbers)
            //{
            //    // number += 10; // This line is invalid because 'number' is a copy of the array element
            //    Console.WriteLine(number);
            //}

            #endregion


            // Region: Control Statements 2. Loop Statements [while, do...while]
            #region Video11

            //int Number;
            //bool Flag;

            //do
            //{
            //    Console.Write("Please Enter an Even Number: ");
            //    // Number = int.Parse(Console.ReadLine());
            //    // Flag = int.TryParse(Console.ReadLine(), out Number);
            //} while (int.TryParse(Console.ReadLine(), out Number) || Number % 2 == 1);

            #endregion
        }
    }
}
