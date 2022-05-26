using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vector
{
    internal class Matrix
    {
        private int width;
        public int Width
        {
            get
            {
                return width;
            }
            private set
            {
                width = value;
            }
        }
        public int Height { get; }
        private int[,] matrix;
        public Matrix()
        {

        }
        public Matrix(int size)
        {
            Width = size;
            Height = size;
            matrix = new int[Height, Width];
        }
        public Matrix(int Width, int Height)
        {
            this.Width = Width;
            this.Height = Height;
            matrix = new int[Height, Width];
        }

        public enum Direction { Right, Down }

        public void DiagonalSnake(Direction direction)
        {


            int temp = 1;

            for (int diag = 0; diag < Width * 2; diag++)
                for (int i = 0; i < Height; i++)
                    for (int j = 0; j < Width; j++)
                    {
                        if (direction == Direction.Right)
                            if (i + j == diag)
                            {
                                if (diag % 2 == 0)
                                    matrix[j, i] = temp;
                                else
                                    matrix[i, j] = temp;
                                temp++;
                            }
                            else
                        if (i + j == diag)
                            {
                                if (diag % 2 == 0)
                                    matrix[i, j] = temp;
                                else
                                    matrix[j, i] = temp;
                                temp++;
                            }

                    }



        }

        public void Print()
        {
            for (int i = 0; i < Height; i++)
            {
                for (int j = 0; j < Width; j++)
                    Console.Write(matrix[i, j] + " ");
                Console.WriteLine();
            }
        }

    }
}
