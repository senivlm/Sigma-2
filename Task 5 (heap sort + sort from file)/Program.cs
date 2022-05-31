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
                Console.WriteLine(vector);
                vector.HeapSort();
                Console.WriteLine(vector);


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }



        }
    }
}
