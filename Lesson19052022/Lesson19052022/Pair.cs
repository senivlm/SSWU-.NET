﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson19052022
{
    public class Pair
    {
        private int number;
        private int freq;

        public Pair(int number, int freq)
        {
            this.Number = number;
            this.Freq = freq;
        }

        public int Number { get => number; set => number = value; }
        public int Freq { get => freq; set => freq = value; }

        public override string ToString()
        {
            return $"{number} - {freq}";
        }
        public override bool Equals(object obj)
        {
            if(obj == null)
            {
                return false;
            }
            if(!(obj is Pair))
            {
                return false;   
            }
            return (this.Number == ((Pair)obj).Number) && (this.Freq == ((Pair)obj).Freq);

        }
        public override int GetHashCode()
        {
            return base.GetHashCode();

        }
    }
}
