using System;

namespace Task
{
    public class Matrix
    {
        private int rowCount;
        private int columnCount;
        private int[,] matr;
        public Matrix() { }
        public int RowCount
        {
            get { return rowCount; }
            set { if (value > 0) rowCount = value; }
        }

        public int ColumnCount
        {
            get { return columnCount; }
            set { if (value > 0) columnCount = value; }
        }

        public Matrix(int rowCount, int columnCount)
        {
            this.rowCount = rowCount;
            this.columnCount = columnCount;
            matr = new int[rowCount, columnCount];
        }
        public int this[int i, int j]
        {
            get { return matr[i, j]; }
            set { matr[i, j] = value; }
        }

        public void trianglePattern()
        {
            int s = rowCount / 2;
            int tmp = 0;
            for (int i = 0; i < s; i++)
            {
                for (int j = 0; j < s - tmp; j++)
                {
                    matr[i, j] = 1;

                }
                tmp++;
            }
            tmp = 0;
            for (int i = 0; i < s; i++)
            {
                for (int j = columnCount - 1; j > s + tmp; j--)
                {
                    matr[i, j] = 2;

                }
                tmp++;
            }
            tmp = 0;

            for (int i = columnCount - 1; i > s; i--)
            {
                for (int j = 0; j < (s - tmp); j++)
                {
                    matr[i, j] = 3;
                }
                tmp++;
            }
            tmp = 0;

            for (int i = columnCount - 1; i > s; i--)
            {
                for (int j = columnCount - 1; j > (s + tmp); j--)
                {
                    matr[i, j] = 4;
                }
                tmp++;
            }

        }
        public void snakePattern()
        {
            int counter = 1;
            for (int j = 0; j < columnCount; j++)
            {
                if (j % 2 == 0)
                {
                    for (int i = 0; i < rowCount; i++)
                    {
                        matr[i, j] = counter;
                        counter++;
                    }
                }
                else
                {
                    for (int i = rowCount - 1; i >= 0; i--)
                    {
                        matr[i, j] = counter;
                        counter++;
                    }
                }

            }
        }

        public void diagonalPattern()
        {
            int i = 0, j = 0;         
            bool isUp = true;
            int counter = 1;
            
            for (int k = 0; k < columnCount * columnCount;)
            {
               
                if (isUp)
                {
                    for (; i >= 0 && j < columnCount; j++, i--)
                    {
                       matr[i, j]=counter++;
                        k++;
                    }
                    if (i < 0 && j <= columnCount - 1)
                        i = 0;
                    if (j == columnCount)
                    {
                        i = i + 2;
                        j--;
                    }
                }
                else
                {
                    for (; j >= 0 && i < columnCount; i++, j--)
                    {
                        matr[i, j] = counter++;
                        k++;
                    }

                    if (j < 0 && i <= columnCount - 1)
                        j = 0;
                    if (i == columnCount)
                    {
                        j = j + 2;
                        i--;
                    }
                }            
                isUp = !isUp;
            }
        }
        public void spiralPattern()
        {

            int counter = 1;
            int m = rowCount;
            int n = columnCount;
            int k = 0, l = 0;
            while (k < m && l < n)
            {
               
                for (int i = l; i < n; ++i)
                {
                    matr[k, i] = counter++;
                }
                k++;
                
                for (int i = k; i < m; ++i)
                {
                    matr[i, n - 1] = counter++;
                }
                n--;

               
                if (k < m)
                {
                    for (int i = n - 1; i >= l; --i)
                    {
                        matr[m - 1, i] = counter++;
                    }
                    m--;
                }

               
                if (l < n)
                {
                    for (int i = m - 1; i >= k; --i)
                    {
                        matr[i, l] = counter++;
                    }
                    l++;
                }
            }
        }
    
        

        public void MatrixPrint()
        {
            for (int i = 0; i < rowCount; i++)
            {
                for (int j = 0; j < columnCount; j++)
                {
                    Console.Write(matr[i, j] + " ");
                }
                Console.WriteLine();
            }
        }




    }
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введіть кількість рядків матриці");
            int rowCount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введіть кількість стовпців матриці ");
            int columnCount = Convert.ToInt32(Console.ReadLine());
            Matrix matrix = new Matrix(rowCount, columnCount);
            matrix.trianglePattern();
            matrix.MatrixPrint();
            matrix.diagonalPattern();
            matrix.MatrixPrint();
            matrix.snakePattern();
            matrix.MatrixPrint();
            matrix.spiralPattern();
            matrix.MatrixPrint();
        }
    }
}
