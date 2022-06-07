using System;

namespace Vector
{
    class Program
    {
        static void Main(string[] args)
        {



            Vector vector = new Vector(100);
            vector.RandomInitialization(1, 50);

            try
            {
                //Console.WriteLine(vector);
                //vector.HeapSort();
                //Console.WriteLine(vector);
                using (StreamReader reader = new StreamReader("matrix.txt"))
                {
                    Matrix matrix = new Matrix();
                    matrix.ReadMatrixFromFile(reader);
                    matrix.Print();
                }

                string str1 = "Hello world. I am Dima";
                int index = str1.LastIndexOf(' ');

                Console.WriteLine(str1);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }



        }
    }
}
