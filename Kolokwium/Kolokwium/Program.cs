﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium
{
    class Program
    {
        static void Main(string[] args)
        { 
            int[] A = new int[] { -3, 1, 2, -2, 5, 6};

        }

        public static int LiczTriplet(int[] A, int P, int Q, int R)
        {
            return (A[P] * A[Q] * A[R]);
        }
    }
}
