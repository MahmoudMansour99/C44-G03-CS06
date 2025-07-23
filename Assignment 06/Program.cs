namespace Assignment_06
{
    internal class Program
    {

        // Pass by Value
        public static void PassByValue(int number)
        {
            number += 10;
            Console.WriteLine();
            Console.WriteLine("Inside PassByReference: " + number);
        }

        // Pass by Reference
        public static void PassByReference(ref int number)
        {
            number += 10;
            Console.WriteLine("Inside PassByReference: " + number);
        }

        // Passing by Value
        public static void amendByValue(Person obj)
        {
            obj.Value = 10;
            obj = new Person();
            obj.Value = 20;
        }
        public static void amendByRef(ref Person obj)
        {
            obj.Value = 30;
            obj = new Person();
            obj.Value = 40;
        }

        public static int[] Calculate(int num1, int num2, int num3 = 0, int num4 = 0)
        {
            int sum = num1 + num2;
            int sub = num1 - num2;
            return new int[] { sum, sub };
        }

        public static int SumOfDigits(int number)
        {
            int sum = 0;

            if (number < 0)
            {
                number = -number;
            }

            while (number > 0)
            {
                int digit = number % 10;
                sum += digit;
                number /= 10;
            }
            return sum;
        }
        public static bool IsPrime(int number)
        {
            if (number <= 1)
                return false;

            if (number == 2)
                return true;

            if (number % 2 == 0)
                return false;

            for (int i = 3; i <= Math.Sqrt(number); i += 2)
            {
                if (number % i == 0)
                    return false;
            }

            return true;
        }
        public static void MinMaxArray(int[] array, ref int min, ref int max)
        {
            if (array == null || array.Length == 0)
            {
                Console.WriteLine("Array is empty. Cannot find min and max.");
                return;
            }

            min = array.Min();
            max = array.Max();
        }
        public static long Factorial(int number)
        {
            if (number < 0)
            {
                Console.WriteLine("Factorial is not defined for negative numbers.");
                return -1; 
            }

            long result = 1;

            for (int i = 2; i <= number; i++)
            {
                result *= i;
            }

            return result;
        }
        static void Main(string[] args)
        {
            #region 1-	Explain the difference between passing (Value type parameters) by value and by reference then write a suitable c# example.
            // in C# Value Types are normally passed by value, and this is considered as a copy of the variable , so any modification will not be affect to the original vatiable, but we can explicitly pass value type by refernce using the key word ref , so the method gets the reference to the original vatiable  

            //    int A = 5;

            //Console.WriteLine("Before PassByValue: " + A);
            //PassByValue(A);
            //Console.WriteLine("After PassByValue: " + A);

            //Console.WriteLine("\nBefore PassByReference: " + A);
            //PassByReference(ref A);
            //Console.WriteLine("After PassByReference: " + A);

            #endregion
            #region 2-	Explain the difference between passing (Reference type parameters) by value and by reference then write a suitable c# example.
            // in Pass by Value both the original and method will be point to the same object, we can modify but we can't change the original one, the pass by reference allow us to modify in both object and Original one 

            //Person MyPerson01 = new Person();
            //MyPerson01.Value = 1;

            //Console.WriteLine("Before ModifyByValue: " + MyPerson01.Value);
            //amendByValue(MyPerson01);
            //Console.WriteLine("After ModifyByValue: " + MyPerson01.Value); 

            //Person MyPerson02 = new Person();
            //MyPerson02.Value = 1;

            //Console.WriteLine("\nBefore ModifyByReference: " + MyPerson02.Value);
            //amendByRef(ref MyPerson02);
            //Console.WriteLine("After ModifyByReference: " + MyPerson02.Value);  

            #endregion
            #region 3-	Write a c# Function that accept 4 parameters from user and return result of summation and subtracting of two numbers

            //int a, b;

            //Console.Write("Enter first number: ");
            //while (!int.TryParse(Console.ReadLine(), out a))
            //{
            //    Console.Write("Invalid input. Please enter a valid integer: ");
            //}

            //Console.Write("Enter second number: ");
            //while (!int.TryParse(Console.ReadLine(), out b))
            //{
            //    Console.Write("Invalid input. Please enter a valid integer: ");
            //}

            //int[] result = Calculate(a, b);

            //Console.WriteLine($"\nSum: {result[0]}");
            //Console.WriteLine($"Sub: {result[1]}");


            #endregion
            #region 4-	Write a program in C# Sharp to create a function to calculate the sum of the individual digits of a given number. Output should be like Enter a number: 25 The sum of the digits of the number 25 is: 7

            //int num;

            //Console.Write("Enter a number: ");

            //while (!int.TryParse(Console.ReadLine(), out num))
            //{
            //    Console.Write("Invalid input. Please enter a valid integer: ");
            //}

            //int result = SumOfDigits(num);
            //Console.WriteLine($"The sum of the digits of the number {num} is: {result}");

            #endregion
            #region 5-	Create a function named "IsPrime", which receives an integer number and retuns true if it is prime, or false if it is not:

            //Console.Write("Enter a number: ");
            //string input = Console.ReadLine();

            //if (int.TryParse(input, out int num))
            //{
            //    bool result = IsPrime(num);
            //    Console.WriteLine($"{num} is {(result ? "a prime number" : "not a prime number")}");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input. Please enter a valid integer.");
            //}

            #endregion
            #region 6-	Create a function named MinMaxArray, to return the minimum and maximum values stored in an array, using reference parameters

            //Console.Write("Enter the number of elements in the array: ");
            //int size;

            //while (!int.TryParse(Console.ReadLine(), out size) || size <= 0)
            //{
            //    Console.Write("Invalid input. Please enter a positive integer: ");
            //}

            //int[] numbers = new int[size];

            //for (int i = 0; i < size; i++)
            //{
            //    Console.Write($"Enter element {i + 1}: ");
            //    while (!int.TryParse(Console.ReadLine(), out numbers[i]))
            //    {
            //        Console.Write("Invalid input. Please enter a valid integer: ");
            //    }
            //}

            //int min = 0, max = 0;
            //MinMaxArray(numbers, ref min, ref max);

            //Console.WriteLine($"\nMinimum value: {min}");
            //Console.WriteLine($"Maximum value: {max}");

            #endregion
            #region 7-	Create an iterative (non-recursive) function to calculate the factorial of the number specified as parameter

            //Console.Write("Enter a non-negative integer: ");
            //int num;

            //while (!int.TryParse(Console.ReadLine(), out num) || num < 0)
            //{
            //    Console.Write("Invalid input. Please enter a non-negative integer: ");
            //}

            //long factorial = Factorial(num);
            //Console.WriteLine($"Factorial of {num} is: {factorial}");

            #endregion
            #region 8-	Create a function named "ChangeChar" to modify a letter in a certain position (0 based) of a string, replacing it with a different letter

            // Couldn't figure it out, but hopefully the workshop will help me get the idea.

            #endregion
        }
    }
}
