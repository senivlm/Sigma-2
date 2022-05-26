using System;

namespace matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {



            Matrix.VerticalSnake();
            Console.WriteLine(); Console.WriteLine();
            
            Matrix.DiagonalSnake();
            Console.WriteLine(); Console.WriteLine();

            Matrix.SpiralSnake();
            Console.WriteLine(); Console.WriteLine();
        }


    }
}