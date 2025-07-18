namespace C__Basics_Session_06
{
    internal class Program
    {
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

            #endregion
        }
    }
}
