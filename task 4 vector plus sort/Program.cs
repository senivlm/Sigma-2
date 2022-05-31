using System;

namespace Vector
{
    class Program
    {
        static void Main(string[] args)
        {
            //Vector vec1 = new Vector(25);
            //vec1.RandomInitialization(); 
            //Vector vec2 = new Vector(25);
            //vec2.RandomInitialization();
            //Vector vec3 = new Vector(25);
            //vec3.RandomInitialization();

            Vector vector = new Vector(10);
            vector.RandomInitialization(1, 50);

            try
            {
                Console.WriteLine(vector);
                vector.SplitMergeSort();
                Console.WriteLine(vector);
                //Console.WriteLine("QuickSort\n"); 

                //Console.WriteLine("First element\n" + vec1);
                //vec1.QuickSort(0, vec1.Length - 1, Vector.Pivot.first);
                //Console.WriteLine(vec1.ToString());

                //Console.WriteLine("Middle element\n" + vec2);
                //vec2.QuickSort(0, vec2.Length - 1, Vector.Pivot.middle);
                //Console.WriteLine(vec2.ToString());

                //Console.WriteLine("Last element\n" + vec3);
                //vec3.QuickSort(0, vec3.Length - 1, Vector.Pivot.last);
                //Console.WriteLine(vec3.ToString());

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }



        }
    }
}
