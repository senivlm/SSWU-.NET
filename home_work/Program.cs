using System;

namespace Task
{
    public class Matrix
    {
        private int rowCount;
        private int columnCount;
        private int[,] matr;
        public enum startAngle { 
            Right, Down
        }
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

        public void KeyboardInput()
        {
           
              for(int i = 0; i < rowCount; i++)
              {
                for( int j = 0; j < columnCount; j++)
                {
                    matr[i, j] = Convert.ToInt32(Console.ReadLine());
                }
              }
                
            
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
        
        public void diagonalPattern(startAngle angle)
        {
            int counter = 1;
            
            int counter2 = 1;
            if (angle == startAngle.Right)
            {
                for (int line = 0; line < rowCount; line++)
                {
                    if (line % 2 == 0)
                    {
                        int ii = line;
                        int jj = 0;
                        for (int j = 0; j < line+1 ; j++)
                        {
                            matr[ii, jj] = counter++;
                            matr[rowCount - 1 - ii, rowCount - 1 - jj] = rowCount* rowCount+2-counter;
                            jj++;
                            ii--;
                            
                        }
                    }
                    else
                    {
                        int ii = 0;
                        int jj = line;
                        for (int j = 0; j < line+1 ; j++)
                        {
                            matr[ii, jj] = counter++;
                            matr[rowCount - 1 -  ii, rowCount - 1 - jj] = rowCount * rowCount + 2 - counter;
                            jj--;
                            ii++;

                        }
                    }


                }
            }
            else if (angle == startAngle.Down)
            {
                for (int line = 0; line < rowCount; line++)
                {
                    if (line % 2 == 0)
                    {
                        int ii = 0;
                        int jj = line;
                        for (int j = 0; j < line + 1; j++)
                        {
                            matr[ii, jj] = counter++;
                            matr[rowCount - 1 - ii, rowCount - 1 - jj] = rowCount * rowCount + 2 - counter;

                            jj--;
                            ii++;

                        }

                    }
                    else
                    {
                        int ii = line;
                        int jj = 0;
                        for (int j = 0; j < line + 1; j++)
                        {
                            matr[ii, jj] = counter++;
                            matr[rowCount - 1 - ii, rowCount - 1 - jj] = rowCount * rowCount + 2 - counter;
                            jj++;
                            ii--;

                        }
                    }


                }
            }
            
            
        }
        public void diagonalPattern2(startAngle angle)
        {
            int counter = 1;

            int counter2 = 1;
            if (angle == startAngle.Right)
            {
                for (int line = 0; line < rowCount; line++)
                {
                    if (line % 2 == 0)
                    {
                        int ii = line;
                        int jj = 0;
                        for (int j = 0; j < line + 1; j++)
                        {
                            matr[ii - jj, jj] = counter;
                            matr[rowCount - 1 - jj, rowCount - 1 - line + jj] = counter2 - +counter;
                            jj++;
                            counter++;
                        }




                    }
                    else
                    {
                        int ii = 0;
                        int jj = line;
                        for (int j = 0; j < line + 1; j++)
                        {
                            matr[ii, jj - ii] = counter++;
                            matr[rowCount - 1 - line + ii, rowCount - 1 - ii] = counter2++;


                            ii++;

                        }
                    }


                }
            }
            else if (angle == startAngle.Down)
            {
                for (int line = 0; line < rowCount; line++)
                {
                    if (line % 2 == 0)
                    {
                        int ii = 0;
                        int jj = line;
                        for (int j = 0; j < line + 1; j++)
                        {
                            matr[ii, jj - ii] = counter++;
                            matr[rowCount - 1 - line + ii, rowCount - 1 - ii] = counter2++;
                            ii++;

                        }

                    }
                    else
                    {
                        int ii = line;
                        int jj = 0;
                        for (int j = 0; j < line + 1; j++)
                        {
                            matr[ii - jj, jj] = counter++;
                            matr[rowCount - 1 - jj, rowCount - 1 - line + jj] = counter2++;
                            jj++;

                        }
                    }


                }
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

        public void MaxSquare()
        {
            int max = 0;
            int maxTmp = 0;
            int indexMaxj = 0;
            int indexMaxi = 0;
            for (int i = 0; i < rowCount; i++)
            {
                for(int j=1; j<columnCount; j++)
                {
                    if(matr[i, j-1] == matr[i, j])
                    {
                        maxTmp++;
                        if (maxTmp > max)
                        {
                            max = maxTmp;
                            indexMaxj = j;
                            indexMaxi = i;
                        }

                    }
                    else
                    {
                        maxTmp = 0;
                    }
                }
            }
            Console.WriteLine($"{max+1}, {indexMaxi},{indexMaxj}");
        }


        public void MatrixPrint()
        {
            for (int i = 0; i < rowCount; i++)
            {
                for (int j = 0; j < columnCount; j++)
                {
                    Console.Write(matr[i, j]+"\t");
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
            matrix.KeyboardInput();
            matrix.MatrixPrint();
            matrix.MaxSquare();
            matrix.trianglePattern();
            matrix.MatrixPrint();
            matrix.diagonalPattern(Matrix.startAngle.Down);
            matrix.MatrixPrint();
            matrix.snakePattern();
            matrix.MatrixPrint();
            matrix.spiralPattern();
            matrix.MatrixPrint();
        }
    }
}
