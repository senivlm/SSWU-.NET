using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson19052022
{
    public class Vector
    {
        private int[] array; 
        
            public Vector(int n)
        {
            array = new int[n];
        }

        public void Init()
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i;
            }
        }
        public void InitKeyboard()
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        public void InitRand(int a, int b)
        {
            Random random = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(a, b);
            }
        }
  
        public void ShuffeInit()
        {
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                int number = random.Next(0, array.Length + 1);
                while (Array.IndexOf(array, number) != -1)
                {
                    number = random.Next(0, array.Length + 1);
                }
                array[i] = number;
            }
        }
        public int this[int index]
        { 
            get { 
                if(index >=0 && index < array.Length)
                    return array[index];
            else
                {
                    throw new IndexOutOfRangeException();
                }
                    }
            set { array[index] = value; }
        }
        public override string ToString()
        {
            string str = "";
            for (int i = 0; i < array.Length; i++)
            {
                str += array[i] + " ";
            }
            return str;
        }
        public Pair[] CalculateFreq()
        {

            Pair[] pairs = new Pair[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                pairs[i] = new Pair(0, 0);

            }
            int countDifference = 0;

            for (int i = 0; i < array.Length; i++)
            {
                bool isElement = false;
                for (int j = 0; j < countDifference; j++)
                {
                    if (array[i] == pairs[j].Number)
                    {
                        pairs[j].Freq++;
                        isElement = true;
                        break;
                    }
                }
                if (!isElement)
                {
                    pairs[countDifference].Freq++;
                    pairs[countDifference].Number = array[i];
                    countDifference++;
                }
            }

            Pair[] result = new Pair[countDifference];
            for (int i = 0; i < countDifference; i++)
            {
                result[i] = pairs[i];
            }

            return result;
        }

        public bool IsPalindrom()
        {
            int counter = 0;
            if (array == null)
            {
                return false;
            }
            else
            {
                for (int i = 0; i < array.Length / 2; i++)
                {
                    if (array[i] == array[array.Length-1 - i])
                    {
                        counter++;
                    }
                }
                if (counter == array.Length / 2) return true;
            }
            return false;
            
        }
        public bool IsPalindrom(int number)
        {
            int _number = 0;
            int tmp=number;
            for(int i = 0; i < number; i++)
            {
                _number = _number * 10 + tmp%10;
                tmp /= 10;
            }
            if(_number == number) return true;
            else return false;
        }
        public void Reverse()
        {
            int tmp;
            for(int i=0; i < array.Length/2; i++)
            {
                tmp = array[i];
                array[i] = array[array.Length-1-i];
                array[array.Length - 1 - i] = tmp;

            }
        }
        public int[] MaxSubVecror()
        {
            int max=0;
            int maxTmp=0;
            int indexMax = 0;
            
            for(int i=1; i<array.Length; i++)
            {
                if (array[i - 1] == array[i])
                {
                    maxTmp++;
                    if (maxTmp > max)
                    {
                        max = maxTmp;
                        indexMax = i;
                    }

                }
                else
                {
                    maxTmp = 0;
                }
                
            }
           
            int[] subVector=new int[max+1];
            //Console.WriteLine($"{max}, {indexMax},{indexMax - max}");
            for (int i = 0; i < subVector.Length; i++)
            {
                subVector[i] = array[indexMax - max + i];

            }
            return subVector;
            //for (int i = 0; i < subVector.Length; i++)
            //{
            //    Console.WriteLine(subVector[i]);
            //}
        }
        public void QuickSort1(int L, int R)
        {
            
            int B, tmp, i, j;
            
            B = array[(L + R) / 2];
            i = L; j = R;
            while (i <= j)
            {
                while (array[i] < B) i = i + 1;
                while (array[j] > B) j = j - 1;
                if (i <= j)
                {
                    tmp = array[i];
                    array[i] = array[j];
                    array[j] = tmp;
                    i = i + 1;
                    j = j - 1;
                }
            }
            if (L < j) QuickSort1(L, j);
            if (i < R) QuickSort1(i, R);
        }
        public void QuickSort2(int L, int R)
        {
            int B, tmp, i, j;
            B = array[L];
            i = L; j = R;
            while (i <= j)
            {
                while (array[i] < B) i = i + 1;
                while (array[j] > B) j = j - 1;
                if (i <= j)
                {
                    tmp = array[i];
                    array[i] = array[j];
                    array[j] = tmp;
                    i = i + 1;
                    j = j - 1;
                }
            }
            if (L < j) QuickSort1(L, j);
            if (i < R) QuickSort1(i, R);
        }
        public void QuickSort3(int L, int R)
        {
            int B, tmp, i, j;
            B = array[R];
            i = L; j = R;
            while (i <= j)
            {
                while (array[i] < B) i = i + 1;
                while (array[j] > B) j = j - 1;
                if (i <= j)
                {
                    tmp = array[i];
                    array[i] = array[j];
                    array[j] = tmp;
                    i = i + 1;
                    j = j - 1;
                }
            }
            if (L < j) QuickSort1(L, j);
            if (i < R) QuickSort1(i, R);
        }
        public void Merge(int l, int q, int r)
        {
            int i = l;
            int j = q+1;
            int k = 0;
            int[] temp = new int[r - l + 1];
            while (i <=q && j <= r)
            {
                if (this.array[i] <= this.array[j])
                {
                    temp[k] = this.array[i];
                    i++;
                    k++;
                }
                else
                {
                    temp[k] = this.array[j];
                    j++;
                    k++;
                }

            }
            while (i <= q)
            {
                temp[k] = array[i];
                i++;
                k++;
            }
            while (j <= r)
            {
                temp[k] = array[j];
                k++;
                j++;
            }
            for (i = l; i <= r; i += 1)
            {
                array[i] = temp[i - l];

            }
        }
        public void SplitMerge(int start, int end)
        {
            if (start < end)
            {
                int mid = (start + end) / 2;
                SplitMerge(start, mid);
                SplitMerge( mid + 1, end);
                Merge( start, mid, end);
            }
        }
        void HeapFormation(int root, int bottom)
        {
            int indexMax;
            bool flag = false; 
                         
            while ((root * 2 <= bottom) && (!flag))
            {
                if (root * 2 == bottom)
                {
                    indexMax = root * 2;
                }
                else if (array[root * 2] > array[root * 2 + 1])
                {
                    indexMax = root * 2;
                }
                else
                {
                    indexMax = root * 2 + 1;
                }
                if (array[root] < array[indexMax])
                {
                    int tmp = array[root]; 
                    array[root] = array[indexMax];
                    array[indexMax] = tmp;
                    root = indexMax;
                }
                else
                { 
                    flag = true;
                }
            }
        }
       
        public void HeapSort(int length)
        {

            for (int i = (length / 2); i >= 0; i--)
            {
                HeapFormation(i, length - 1);
            }
            for (int i = length - 1; i >= 1; i--)
            {
                int temp = array[0];
                array[0] = array[i];
                array[i] = temp;
                HeapFormation(0, i - 1);
            }
        }

        public static Vector operator +(Vector a, Vector b)
        {
            if (a.array.Length != b.array.Length) throw new Exception("вектори різної довжини додавати не можна");
            else
            {
                Vector c = new Vector(a.array.Length);
                for (int i = 0; i < a.array.Length; i++) c[i] = a[i] + b[i];
                return c;
            }
        }
        public static Vector operator +(Vector a, int b)
        {
            Vector c = new Vector(a.array.Length);
            for (int i = 0; i < a.array.Length; i++) c[i] = a[i] + b;
            return c;
        }
        public static bool operator >(Vector a, Vector b)
        {
            return a.array.Length > b.array.Length;
        }
        public static bool operator <(Vector a, Vector b)
        {
            return a.array.Length < b.array.Length;
        }
        public static explicit operator int(Vector a)
        {
            return a[0];
        }
    }
}
