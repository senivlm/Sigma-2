using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vector
{
    internal class Matrix
    {
        private int rows;
        private int Rows
        {
            get
            {
                return rows;
            }
            set
            {
                rows = value;
            }
        }
        private int columns { get; set; }
        private int[,] matrix;
        public Matrix() : this(default, default)
        {

        }
        public Matrix(int size)
        {
            Rows = size;
            columns = size;
            matrix = new int[columns, Rows];
        }
        public Matrix(int Width, int Height)
        {
            this.Rows = Width;
            this.columns = Height;
            matrix = new int[Height, Width];
        }

        public enum Direction { Right, Down }

        public void DiagonalSnake(Direction direction)
        {


            int temp = 1;

            for (int diag = 0; diag < Rows * 2; diag++)
                for (int i = 0; i < columns; i++)
                    for (int j = 0; j < Rows; j++)
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
            for (int i = 0; i < columns; i++)
            {
                for (int j = 0; j < Rows; j++)
                    Console.Write(matrix[i, j] + " ");
                Console.WriteLine();
            }
        }
        public void ReadMatrixFromFile(StreamReader reader)
        {
            string? line = reader.ReadLine();
            string[] sizes = line.Split(' ');
            columns = int.Parse(sizes[0]);
            rows = int.Parse(sizes[1]);
            matrix = new int[columns, rows];
            for (int i = 0; i < columns; i++)
            {
                string[] items = reader.ReadLine().Split(' ');
                for (int j = 0; j < rows; j++)
                {
                    matrix[i, j] = int.Parse(items[j]);
                }
            }

        }
    }


}
