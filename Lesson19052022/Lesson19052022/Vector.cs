﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson19052022
{
    internal class Vector
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
            int x;
            for (int i = 0; i < array.Length; i++)
            {
                while (array[i] == 0)
                {
                    x = random.Next(1, array.Length + 1);
                    bool isExist = false;
                    for (int j = 0; j < i; j++)
                    {
                        if (x == array[j])
                        {
                            isExist = true;
                            break;
                        }
                    }
                    if (!isExist)
                    {
                        array[i] = x;
                        break;
                    }
                }
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
    }
}
