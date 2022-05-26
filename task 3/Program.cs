using System;

namespace Vector
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            int[] palindrom = { 2, 0, 2, 3, 2, 0, 2 };
            Vector arr1 = new Vector(palindrom);

            int[] reverse = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Vector arr2 = new Vector(reverse);

            int[] continuity = { 2, 2, 2, 0, 0 };
            Vector arr3 = new Vector(continuity);

            Vector arr4 = new Vector(20);
            arr4.RandomInitialization(1, 50);

            Matrix matrix = new Matrix(5);
            try
            {
                //перевірка на паліндром
                Console.Write(arr1);
                Console.WriteLine();
                Console.WriteLine("цей масив {0} паліндром", arr1.IsArrPalindrom() ? "" : "не");

                //реверс масиву
                Console.WriteLine("\nMy reverse");
                Console.Write(arr2);
                Console.WriteLine();
                arr2.Reverse();
                Console.Write(arr2);                

                Console.WriteLine("\nOriginal reverse");
                foreach (var i in reverse)
                    Console.Write(i + " ");
                Console.WriteLine();
                Array.Reverse(reverse);
                foreach (int i in reverse)
                    Console.Write(i + " ");
                Console.WriteLine();

                foreach (var i in continuity)
                    Console.Write(i + " ");
                Console.WriteLine();
                Console.WriteLine(arr3.Continuity());
                Console.WriteLine(); Console.WriteLine();

                //???
                matrix.DiagonalSnake(Matrix.Direction.Right);
                matrix.Print();

                Console.WriteLine(); Console.WriteLine();

                matrix.DiagonalSnake(Matrix.Direction.Down);
                matrix.Print();

                Console.WriteLine(); Console.WriteLine();
                arr4.Counting();
                Console.WriteLine(arr4);



                //arr[0] = 999;
                //Console.WriteLine(arr[21]);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


            /*            Pair[] pairs = arr.CalculateFreq();

                        for (int i = 0; i < pairs.Length; i++)
                        {
                            Console.Write(pairs[i] + "\n"); 
                        }
                        Console.WriteLine();*/

            //Console.WriteLine(pairs);
            //arr.RandomInitialization();
            //Console.WriteLine(arr);


        }
    }
}
