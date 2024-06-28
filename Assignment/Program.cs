using static System.Runtime.InteropServices.JavaScript.JSType;
using System.ComponentModel;
using System.Drawing;
using System;

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
            //Console.Write("Input starting number of range: ");
            //int start = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Input ending number of range: ");
            //int end = Convert.ToInt32(Console.ReadLine());

            //if (start < 2)
            //{
            //    start = 2;
            //}

            //bool[] isPrime = new bool[end + 1];
            //for (int i = 2; i <= end; i++)
            //{
            //    isPrime[i] = true;
            //}


            //for (int p = 2; p * p <= end; p++)
            //{
            //    if (isPrime[p] == true)
            //    {
            //        for (int i = p * p; i <= end; i += p)
            //        {
            //            isPrime[i] = false;
            //        }
            //    }
            //}
            //Console.WriteLine($"The prime numbers between {start} and {end} are:");
            //for (int i = start; i <= end; i++)
            //{
            //    if (isPrime[i])
            //    {
            //        Console.Write(i + " ");
            //    }
            //}
            //Console.WriteLine();
            #endregion






            // 16- . Write a program in C# Sharp to convert a decimal number into binary without using an array.
            #region Question16
            //Console.Write("Enter  number to convert ");
            //int decimalNum = Convert.ToInt32(Console.ReadLine());

            //Console.Write($"Binary of {decimalNum} is: ");

            //int bits = 0;
            //int temp = decimalNum;
            //while (temp > 0)
            //{
            //    bits++;
            //    temp = temp >> 1;
            //}

            //bool leadZero = true;
            //for (int i = bits - 1; i >= 0; i--)
            //{
            //    int bit = (decimalNum >> i) & 1;
            //    if (bit == 1)
            //    {
            //        leadZero = false;
            //    }
            //    if (!leadZero)
            //    {
            //        Console.Write(bit);
            //    }
            //}
            #endregion

            //17- Create a program that asks the user to input three points (x1, y1), (x2, y2), and (x3, y3), and determines whether these points lie on a single straight line.
            #region Questoin17
            //int x1 = Convert.ToInt32(Console.ReadLine());
            //int y1 = Convert.ToInt32(Console.ReadLine());


            //int x2 = Convert.ToInt32(Console.ReadLine());
            //int y2 = Convert.ToInt32(Console.ReadLine());


            //int x3 = Convert.ToInt32(Console.ReadLine());
            //int y3 = Convert.ToInt32(Console.ReadLine());

            //int m1 = (y2 - y1) * (x3 - x2);
            //int m2 = (y3 - y2) * (x2 - x1);
            //int m3 = (y3 - y1) * (x3 - x1);

            //if (m1 == m2 && m2 == m3)
            //{
            //    Console.WriteLine("Points are collinear ");
            //}
            //else
            //{
            //    Console.WriteLine("Points are not collinear");
            //}
            #endregion

            //18- Within a company, the efficiency of workers is evaluated based on the duration required to complete a specific task. A worker's efficiency level is determined as follows: 
            // -If the worker completes the job within 2 to 3 hours, they are considered highly efficient.
            //- If the worker takes 3 to 4 hours, they are instructed to increase their speed.
            //  - If the worker takes 4 to 5 hours, they are provided with training to enhance their speed.
            //  - If the worker takes more than 5 hours, they are required to leave the company.
            //To calculate the efficiency of a worker, the time taken for the task is obtained via user input
            //from the keyboard.


            #region Question18
            //Console.WriteLine("Enter the time taken ");
            //double time = double.Parse(Console.ReadLine());

            //if (time >= 2 && time < 3)
            //{
            //    Console.WriteLine("Worker is highly efficient.");
            //}
            //else if (time >= 3 && time < 4)
            //{
            //    Console.WriteLine("Worker should increase speed.");
            //}
            //else if (time >= 4 && time < 5)
            //{
            //    Console.WriteLine("Worker should undergo training to enhance speed.");
            //}
            //else if (time >= 5)
            //{
            //    Console.WriteLine("Worker should leave the company.");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input. Time taken must be a positive number.");
            //}
            #endregion


            //19- . Write a program that prints an identity matrix using for loop,
            //in other words takes a value n from the user and shows the identity table of size n * n.

            #region Question19
            //Console.WriteLine("Enter the size of matrix ");
            //int n = int.Parse(Console.ReadLine());

            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //    {
            //        if (i == j)
            //            Console.Write("1 ");
            //        else
            //            Console.Write("0 ");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            //20- Write a program in C# Sharp to find the sum of all elements of the array
            #region Question20
            //int[] arr = [1,2,3,4];
            //int sum = 0;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    sum += arr[i];
            //}
            //Console.WriteLine(sum);
            #endregion

            //21 - Write a program in C# Sharp to merge two arrays of the same size sorted in ascending order.
            #region Question21
            //int[] arr1 = { 1, 3, 5, 7, 9 };
            //int[] arr2 = { 2, 4, 6, 8, 10 };

            //int size = arr1.Length;

            //int[] mergedArr = new int[size * 2]; 

            //Array.Copy(arr1, 0, mergedArr, 0, size);
            //Array.Copy(arr2, 0, mergedArr, size, size);

            // Array.Sort(mergedArr);

            //for (int i = 0; i < mergedArr.Length; i++)
            //{
            //    Console.Write(mergedArr[i] + " ");
            //}
            //Console.WriteLine();
            #endregion


            // 22 - Write a program in C# Sharp to count the frequency of each element of an array.
            //first using frequency array ==>O(n^2)
            #region Question22
            //int[] arr = { 1, 1, 1, 3, 3, 2, 2, 5, 1 };
            //int n = arr.Length;

            //int[] uniqueElement = new int[n];
            //int[] frequency = new int[n];
            //int uniqueCount = 0;

            //for (int i = 0; i < n; i++)
            //{
            //    int element = arr[i];
            //    bool flag = false;
            //    for (int j = 0; j < uniqueCount; j++)
            //    {
            //        if (uniqueElement[j] == element)
            //       {
            //            frequency[j]++;
            //            flag = true;
            //            break;
            //        }
            //    }

            //    if (!flag)
            //    {
            //        uniqueElement[uniqueCount] = element;
            //        frequency[uniqueCount] = 1;
            //        uniqueCount++;
            //    }
            //}

            //Console.WriteLine("Element\tFrequency");
            //for (int i = 0; i < uniqueCount; i++)
            //{
            //    Console.WriteLine($"{uniqueElement[i]}\t{frequency[i]}");
            //}
            #endregion

            //second using map(i know it from c++) ==>O(n)
            #region Question22
            //int[] arr = { 1, 1, 1, 3, 3, 2, 2, 5, 1 };

            //Dictionary<int, int> frequencyMap = new Dictionary<int, int>();
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (frequencyMap.ContainsKey(arr[i]))
            //        frequencyMap[arr[i]]++;
            //    else
            //        frequencyMap[arr[i]] = 1;

            //}
            //Console.WriteLine("Element\tFrequency");
            //foreach (var part in frequencyMap)
            //{
            //    Console.WriteLine($"{part.Key}\t{part.Value}");
            //}
            #endregion

            //23- Write a program in C# Sharp to find maximum and minimum element in an array

            #region Question23

            //int[] arr = {2,43,22,51,66,12,79,76};

      
            //int max = arr[0];
            //int min = arr[0];

            //for (int i = 1; i < arr.Length; i++)
            //{
            //    if (arr[i] > max)
            //    {
            //        max = arr[i];
            //    }
            //    if (arr[i] < min)
            //    {
            //        min = arr[i];
            //    }
            //}

            //Console.WriteLine("Maximum element  is: " + max);
            //Console.WriteLine("Minimum element is: " + min);
            #endregion


            //24- Write a program in C# Sharp to find the second largest element in an array.
            #region Question24

            //int[] arr = { 100, 30, 19, 2,0, 21, 12, 3, 1 };

            //int large = int.MinValue;
            //int secLarge = int.MinValue;

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] > large)
            //    {
            //        secLarge = large;
            //        large = arr[i];
            //    }
            //    else if (arr[i] > secLarge && arr[i] != large)
            //    {
            //        secLarge = arr[i];
            //    }
            //}

            //if (secLarge == int.MinValue)
            //{
            //    Console.WriteLine("There is no second largest element in the array.");
            //}
            //else
            //{
            //    Console.WriteLine("The second largest element is: " + secLarge);
            //}
            #endregion
        }
    }
    }
