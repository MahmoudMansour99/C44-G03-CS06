using System.Data;
using System.Security.Cryptography.X509Certificates;

namespace C__Basics_Session_06
{
    internal class Program
    {
        //. Method
        // 1.1 Class Member Method [Static Method]
        // 1.2 Object Member Method [Non-Static Method]

        #region Method

        //public static void PrintShape(int Count = 5, string Pattern = "_-_")
        //{
        //    for (int i = 0; i < 5; i++)
        //    {
        //        Console.WriteLine(Pattern);
        //    }
        //}
        //public static void Swap(ref int X, ref int Y)
        //{
        //    int Temp = X;
        //    X = Y;
        //    Y = Temp;
        //}
        //public static int SumArray(params int[] Arr)
        //{
        //    int Sum = 0;
        //    //Arr[0] = 100;
        //    //Arr = new int[] { 100, 200, 300};
        //    for (int i = 0; i < Arr.Length; i++)
        //    {
        //        Sum += Arr[i];
        //    }
        //    return Sum;
        //}
        //public static int SumArray(ref int[] Arr)
        //{
        //    int Sum = 0;
        //    //Arr[0] = 100;
        //    Arr = new int[] { 100, 200, 300 };
        //    for (int i = 0; i < Arr.Length; i++)
        //    {
        //        Sum += Arr[i];
        //    }
        //    return Sum;
        //}
        //public static void SumSub(int X, int Y, out int Sum, out int Sub)
        //{
        //    Sum = X + Y;
        //    Sub = X - Y;
        //    //return new int[] { Sub, Sum };
        //    //return [Sub, Sum];
        //    //return new { Sub, Sum };
        //}
        //public static void Conact<T>(params ReadOnlySpan<T> items)
        //{
        //    for (int i = 0; i < items.Length; i++)
        //    {
        //        Console.Write($"{items[i]} ");
        //    }
        //}


        #endregion

        static void Main(string[] args)
        {
            #region Arrays

            #region 1D Array

            #region Example 01

            //int x = 0;
            //int y = 1;
            //int z = 2;
            //int d = 3;

            //int[] Numbers;

            //Numbers = new int[3];

            //Console.WriteLine(Numbers[0]);
            //Console.WriteLine(Numbers[1]);
            //Console.WriteLine(Numbers[2]);

            //Numbers[0] = 1;
            //Numbers[1] = 2;
            //Numbers[2] = 3;

            //Console.WriteLine(Numbers[0]);
            //Console.WriteLine(Numbers[1]);
            //Console.WriteLine(Numbers[2]);

            //Console.WriteLine($"Length of Array is {Numbers.Length}");
            //Console.WriteLine($"Rank of Array is {Numbers.Rank}");

            //Console.WriteLine($"Hash Code of Array is {Numbers.GetHashCode()}");
            //Console.WriteLine($"Hash Code of Array Index '0' is {Numbers[0].GetHashCode()}");
            //Console.WriteLine($"Hash Code of Array Index '1' is {Numbers[1].GetHashCode()}");
            //Console.WriteLine($"Hash Code of Array Index '2' is {Numbers[2].GetHashCode()}");

            //for (int i = 0; i < Numbers.Length; i++)
            //{
            //    Console.WriteLine(Numbers[i]);
            //}

            //foreach (int item in Numbers)
            //{
            //    Console.WriteLine(item);
            //}



            #endregion

            #region Array Creation Way

            //int[] Numbers01 = new int[3];
            //int[] Numbers02 = new int[] {1, 2, 3};
            //int[] Numbers03 = new int[3] {1, 2, 3};
            //int[] Numbers04 = { 1, 2, 3 };

            #endregion

            #endregion

            #region 2D Array [Rectangular]

            //int[,] Marks = new int[2, 5] { { 100, 900, 30, 50, 40 },
            //                               { 20, 10, 60, 100, 55 } };

            //Marks[0, 0] = 100;
            //Marks[1, 4] = 100;

            //Console.WriteLine($"Length of Array is {Marks.Length}");
            //Console.WriteLine($"Length of Array is {Marks.GetLength(0)}");
            //Console.WriteLine($"Length of Array is {Marks.GetLength(1)}");
            //Console.WriteLine($"Rank of Array is {Marks.Rank}");

            //int[,] Marks = new int[2, 5];

            //for (int i = 0; i < Marks.GetLength(0); i++)
            //{
            //    Console.WriteLine($"The Grades of student Number {i + 1}: ");
            //    for (int j = 0; j < Marks.GetLength(1); /*j++*/)
            //    {
            //        Console.Write($"Subjecr Number {j + 1}: ");
            //        //Marks[i, j] = int.Parse(Console.ReadLine());
            //        bool Flag = int.TryParse(Console.ReadLine(), out Marks[i, j]);
            //        if (Flag)
            //            j++;
            //    }
            //    Console.WriteLine("//////////////////////////////////");
            //}

            //for (int i = 0; i < Marks.GetLength(0); i++)
            //{
            //    Console.WriteLine($"The Grades of student Number {i + 1}: ");
            //    for (int j = 0; j < Marks.GetLength(1); j++)
            //    {
            //        Console.WriteLine($"Sub No {j + 1} = {Marks[i, j]}");
            //    }
            //    Console.WriteLine("//////////////////////////////////");
            //}

            //for (int i = 0; i < Marks.Length; i++)
            //{
            //    Console.WriteLine(Marks[i/Marks.GetLength(1), i % Marks.GetLength(1)]);
            //}

            #endregion

            #region Jagged Array

            //int[][] JaggedArray = new int[3][];

            //JaggedArray[0] = new int[3] { 1, 2, 3 };
            //JaggedArray[1] = new int[2] { 4, 5 };
            //JaggedArray[2] = new int[1] { 6 };

            //for (int i = 0; i < JaggedArray.Length; i++)
            //{
            //    for (int j = 0; j < JaggedArray[i].Length; j++)
            //    {
            //        Console.WriteLine(JaggedArray[i][j]);
            //    }
            //}

            #endregion

            #endregion

            #region Array Method

            //int[] Numbers = { 5, 3, 4, 1, 2, 4 };
            //foreach (int Number in Numbers)
            //    Console.WriteLine(Number);

            //Console.WriteLine("///////////////////");

            //Array.Sort(Numbers);
            //foreach (int Number in Numbers)
            //    Console.WriteLine(Number);

            //Array.Sort(Numbers);
            //Array.Reverse(Numbers);
            //foreach (int Number in Numbers)
            //    Console.WriteLine(Number);

            //Array.Sort(Numbers);
            //Array.Reverse(Numbers);
            //Array.Clear(Numbers);
            //foreach (int Number in Numbers)
            //    Console.WriteLine(Number);

            //Array.Sort(Numbers);
            //Array.Reverse(Numbers);
            //Array.Clear(Numbers, 2, 2);
            //foreach (int Number in Numbers)
            //    Console.WriteLine(Number);

            //Console.WriteLine(Array.IndexOf(Numbers, 4));
            //Console.WriteLine(Array.LastIndexOf(Numbers, 4));

            //int[] Arr01 = { 1, 2, 3, 4, 5 };
            //int[] Arr02 = new int[4];

            //foreach (int item in Arr02)
            //{
            //    Console.WriteLine(item);
            //}

            //Array.Copy(Arr01, Arr02, 4);

            //foreach (int item in Arr02)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Functions

            #region Function Prototype
            //PrintShape(5, ":)");
            //PrintShape(Pattern: ":)", Count: 5);
            //PrintShape(Pattern: ":)");

            //PrintShape(Pattern: @"/*\");

            //Console.WriteLine("@Welcome Mostafa' Hello Amr");
            #endregion

            #region Function Parameters [Value Type]

            #region Passing by Value
            //int A = 9;
            //int B = 4;
            //Console.WriteLine(A);
            //Console.WriteLine(B);
            //Swap(A, B);
            //Console.WriteLine(A);
            //Console.WriteLine(B);
            #endregion

            #region Passing by Reference
            //int A = 9;
            //int B = 4;
            //Console.WriteLine(A);
            //Console.WriteLine(B);
            //Swap(ref A, ref B);
            //Console.WriteLine(A);
            //Console.WriteLine(B);
            #endregion

            #endregion

            #region Function Parameters [Reference Type]

            #region Example 01
            #region Passing By Value

            //int[] Numbers = { 1, 2, 3 };
            //Console.WriteLine(SumArray(Numbers));
            //Console.WriteLine(Numbers.GetHashCode());

            #endregion
            #region Passing by Reference 

            //int[] Numbers = { 1, 2, 3 };
            //Console.WriteLine(SumArray(ref Numbers));
            //Console.WriteLine(Numbers.GetHashCode());

            #endregion
            #endregion

            #region Example 02

            #region Passing by Value

            //int[] Numbers = { 1, 2, 3 };
            //Console.WriteLine(SumArray(Numbers));
            //Console.WriteLine(Numbers.GetHashCode());
            //Console.WriteLine(Numbers[0]);


            #endregion

            #region Passing by Reference

            //int[] Numbers = { 1, 2, 3 };
            //Console.WriteLine(SumArray(ref Numbers));
            //Console.WriteLine(Numbers.GetHashCode());
            //Console.WriteLine(Numbers[0]);

            #endregion

            #endregion

            #endregion

            #region Function Parameters [Passing by Out]

            //SumSub(10, 5, out int M, out int B);

            //Console.WriteLine(M);
            //Console.WriteLine(B);

            #endregion

            #region Function Parameters [Params]

            #region Before C#13

            //int[] Numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //int Result = SumArray(1, 2, 3, 4, 5, 6, 7, 8, 9);

            //Console.WriteLine(Result);

            //string Message = string.Format("Hello {0} Your Age is {1}", "Ahmed", );

            #endregion

            #region After C#13

            //Conact<object>("Hello Ahmed", "Welcome To Route", "Your Number is", 123456789, "Date is", DateTime.Now);

            #endregion

            #endregion

            #endregion

            #region Boxing, Unboxing

            #region Boxing [Value Type => Reverence Type]

            //int X = 100;

            //object obj = (object)X;

            //obj = 1.2;
            //obj = 'A';
            //obj = true;
            //obj = 1.2m;

            #endregion

            #region Unboxing [Reference Type => Value Type]

            //object obj = 10;

            //int X = (int)obj;

            //Console.WriteLine(X);

            #endregion

            #endregion

            #region Nullable Value Type

            #region Example 01

            //int X = 10;
            ////X = null; Invalid
            //Nullable<int> Y = 10;

            //Y = null; // Valid

            //int? Z = 100;

            //Z = null;

            //Console.WriteLine(Z);

            #endregion

            #region Example 02 [Casting from Nullable Type to non-Nullable Type]

            //int X = 10;
            //int? Y = X;

            // Implicit Casting

            //int? A = 10;
            //int B = (int)A;
            //// Explicit Casting

            //if (A is not null)
            //    B = (int)A;
            //else
            //    B = 0;

            //if (A.HasValue)
            //    B = (int)A;
            //else
            //    B = 0;

            //B = A.HasValue ? (int)A : 0;
            //B = A.HasValue ? A.Value : 0;

            //B = A ?? 0;

            //B = A.GetValueOrDefault();

            #endregion

            #endregion

            #region Nullable Reference Type

            //string? Name = null;

            //Console.WriteLine(Name);

            #endregion
        }
    }
}
