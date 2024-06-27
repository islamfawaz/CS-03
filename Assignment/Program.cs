using static System.Runtime.InteropServices.JavaScript.JSType;
using System.ComponentModel;
using System.Drawing;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1- Write a program that takes a number from
            //the user then print yes if that number can be divided by 3 and 4 otherwise print no.
            #region Question1
            //int Num;
            //Num=int.Parse(Console.ReadLine());
            //if (Num % 3 == 0 && Num % 4 == 0)
            //{
            //    Console.WriteLine("yes");
            //}
            //else
            //{
            //    Console.WriteLine("no");
            //}
            #endregion        }

            // 2- Write a program that allows the user to insert an integer
            //   then print negative if it is negative number otherwise print positive.

            #region Question2
            // int Number;
            //Number= int.Parse(Console.ReadLine());
            // if (Number>0)
            // {
            //     Console.WriteLine("positive");
            // }
            // else if (Number < 0)      
            // {
            //     Console.WriteLine("negative");
            // }
            // else
            // {
            //     Console.WriteLine("zero");
            // }
            #endregion



            //3- Write a program that takes 3 integers from the user then prints
            //the max element and the min element.
            #region Question3
            //int num1, num2, num3;
            //num1=int.Parse(Console.ReadLine());
            //num2 = int.Parse(Console.ReadLine());
            //num3 = int.Parse(Console.ReadLine());

            //if (num1 >= num2 && num1 >= num3)
            //    Console.WriteLine(num1);


            //else if (num2 >= num1 && num2 >= num3)
            //    Console.WriteLine($"max element = {num2}");


            //else if (num3 >= num1 && num3 >= num2)
            //    Console.WriteLine($"max element = {num3}");



            //if (num1 <= num2 && num1 <= num3)
            //    Console.WriteLine($"min element = {num1}");


            //else if (num2 <= num1 && num2 <= num3)
            //    Console.WriteLine($"min element = {num2}");


            //else if (num3 <= num1 && num3 <= num2)
            //    Console.WriteLine($"min element = {num3}");


            //anoter way

            //int num1, num2, num3;
            //num1 = int.Parse(Console.ReadLine());
            //num2 = int.Parse(Console.ReadLine());
            //num3 = int.Parse(Console.ReadLine());

            //int maxElement = Math.Max(num1, Math.Max(num2, num3));
            //int minElement = Math.Min(num1, Math.Min(num2, num3));

            //Console.WriteLine($"max element = {maxElement}");
            //Console.WriteLine($"min element = {minElement}");



            #endregion


            //4- Write a program that allows the user to insert an integer number then check
            //If a number is even or odd.
            #region Question4
            //int Number;
            //Number = int.Parse(Console.ReadLine());
            //if (Number % 2 == 0)
            //{
            //    Console.WriteLine("even");
            //}

            //else {
            //    Console.WriteLine("odd");

            //}

            #endregion


            //5- Write a program that takes character from the user then if it is a vowel chars (a,e,I,o,u)
            //then print (vowel) otherwise print (consonant)

            #region Question5
            // char letter;
            //letter= char.Parse(Console.ReadLine());
            // switch (letter) {
            //     case 'a':
            //     case 'A':
            //         Console.WriteLine("vowel");
            //         break;
            //     case 'e':
            //     case 'E':
            //         Console.WriteLine("vowel");
            //         break;
            //     case 'i':
            //     case 'I':

            //         Console.WriteLine("vowel");
            //         break;
            //     case 'o':
            //     case 'O':
            //         Console.WriteLine("vowel");
            //         break;
            //     case 'u':
            //     case 'U':
            //         Console.WriteLine("vowel");
            //         break;
            //     default:
            //         Console.WriteLine("consonant");
            //         break;


            //  }

            #endregion

            //  6 - Write a program that allows the user to insert an integer then print all numbers
            //  between 1 to that number.


            #region Question6
            //int Number;
            //Number=int.Parse(Console.ReadLine());
            //for (int i = 1; i <= Number; i++)
            //{
            //    Console.WriteLine(i);
            //}

            #endregion

            //7- Write a program that allows the user to insert an integer then 
            //   print a multiplication table up to 12.
            //   Example
            //Input: 5
            // Outputs: 5 10 15 20 25 30 35 40 45 50 55 60


            #region Question7
            //int Number;
            //Number= int.Parse(Console.ReadLine());
            //for (int i = 1; i <=12; i++)
            //{
            //  Console.WriteLine(Number*i);
            //}
            #endregion

            //8- Write a program that allows to user to insert number then print all even numbers
            //between 1 to this number

            #region Question8
            //int Number;
            //Number = int.Parse(Console.ReadLine());
            //for (int i = 0; i <= Number; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            #endregion
            //9- Write a program that takes two integers then prints the power.
            #region Question9

            //Console.WriteLine("Enter the base (x):");
            //int x = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter the exponent (n):");
            //int n = int.Parse(Console.ReadLine());

            //int result = 1;
            //int baseValue = x;  

            //while (n > 0)
            //{
            //    if (n % 2 == 1)
            //    {
            //        result *= x;
            //    }
            //    x = x * x;
            //    n = n / 2;
            //}

            //Console.WriteLine(result);


            #endregion


            //    10 - Write a program to enter marks of five subjects and calculate total,
            //    average and percentage.
            #region Question10

            //int[] marks = new int[5];
            //int total = 0;

            //Console.WriteLine("Enter marks of five subjects:");

            //for (int i = 0; i < 5; i++)
            //{
            //    marks[i] = int.Parse(Console.ReadLine());
            //    total += marks[i];
            //}
            //int average = total / 5;
            //int percentage = (total / 500) * 100;

            //Console.WriteLine($"Total marks = {total}");
            //Console.WriteLine($"Average Marks = {average}");
            //Console.WriteLine($"Percentage = {percentage}");

            #endregion

            // 11 - Write a program to input the month number and print the number of days in that month.

            #region Question11
            //int month = int.Parse(Console.ReadLine());
            //int day = 0;
            //switch (month)
            //{
            //    case 1:
            //    case 3:
            //    case 5:
            //    case 7:
            //    case 8:
            //    case 10:
            //    case 12:
            //     day = 31;
            //        break;

            //    case 4:
            //    case 6:
            //    case 9:
            //    case 11:
            //        day = 30;
            //        break;

            //        case 2:
            //        Console.WriteLine("Enter the year to check 29 or 28:");
            //        int year = int.Parse(Console.ReadLine());
            //        if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
            //        {
            //            day = 29;
            //            Console.WriteLine("leap year");
            //        }
            //        else
            //        {
            //            day = 28;
            //        }
            //        break;
            //       default:
            //        Console.WriteLine("Invalid month number");
            //        return;

            //}
            //Console.WriteLine($"The days in month {month} is: {day}");


            #endregion



            //12- Write a program to create a Simple Calculator.

            #region Question12
            //Console.WriteLine("Enter the first Num");
            //double num1 = double.Parse(Console.ReadLine());

            //Console.WriteLine("Enter an operator [+, -, *, /,%]");
            //char operation = Console.ReadLine()[0];

            //Console.WriteLine("Enter the second Num");
            //double num2 = double.Parse(Console.ReadLine());

            //double result = 0;
            //bool flag = true;

            //switch (operation)
            //{
            //    case '+':
            //        result = num1 + num2;
            //        break;
            //    case '-':
            //        result = num1 - num2;
            //        break;
            //    case '*':
            //        result = num1 * num2;
            //        break;
            //    case '/':
            //        if (num2 != 0)
            //        {
            //            result = num1 / num2;
            //        }
            //        else
            //        {
            //            Console.WriteLine("Error: Division by zero is not allowed.");
            //            flag = false;
            //        }
            //        break;
            //    case '%':
            //        result = num1 % num2;
            //        break;


            //    default:
            //        Console.WriteLine("Error");
            //        flag = false;
            //        break;
            //}

            //if (flag)
            //{
            //    Console.WriteLine($"Result: {num1} {operation} {num2} = {result}");
            //}

            #endregion

            //13- Write a program to allow the user to enter a string and print the REVERSE of it.
            #region Question13
            //string str =Console.ReadLine();
            //char[] arrayOfChar = str.ToCharArray();
            //Array.Reverse(arrayOfChar);
            //string reversed = new string(arrayOfChar);
            //Console.WriteLine(reversed); 
            #endregion

            //14- Write a program to allow the user to enter int and print the REVERSED of it.
            #region Question14
            //int num = int.Parse(Console.ReadLine());
            //bool isNegative = num < 0;

            //if (isNegative)
            //{
            //    num = -num; 
            //}
            //int reversedNum = 0;

            //while (num > 0)
            //{
            //    int digit = num % 10; 
            //    reversedNum = reversedNum * 10 + digit;
            //    num /= 10;
            //}

            //if (isNegative)
            //{
            //    reversedNum = -reversedNum;
            //}

            //Console.WriteLine(reversedNum);

            #endregion


            //15- Write a program in C# Sharp to find prime numbers within a range of numbers.
            //using Sieve of Eratosthenes
            #region Question15
            Console.Write("Input starting number of range: ");
            int start = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input ending number of range: ");
            int end = Convert.ToInt32(Console.ReadLine());

            if (start < 2)
            {
                start = 2;
            }

            bool[] isPrime = new bool[end + 1];
            for (int i = 2; i <= end; i++)
            {
                isPrime[i] = true;
            }


            for (int p = 2; p * p <= end; p++)
            {
                if (isPrime[p] == true)
                {
                    for (int i = p * p; i <= end; i += p)
                    {
                        isPrime[i] = false;
                    }
                }
            }
            Console.WriteLine($"The prime numbers between {start} and {end} are:");
            for (int i = start; i <= end; i++)
            {
                if (isPrime[i])
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();
            #endregion






            // 16- . Write a program in C# Sharp to convert a decimal number into binary without using an array.

        }
    }
}