using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium
{
    public class Program
    {
        public static void Main(string[] args)
        { 
            int[] A = new int[] { -3, 1, 2, -2, 5, 6};

        }

        public static int LiczTriplet(int[] A, int P, int Q, int R)
        {
            return (A[P] * A[Q] * A[R]);
        }

        public static int ZnajdzTriplet(int[] A, int R)
        {
            int aktualna;
            int najwieksza = 0;
            int temp1, temp2, temp3;

            for (int i = 5; i>=0; i--)
            {
                aktualna = A[i];

                if(aktualna > najwieksza)
                {
                    R = i;
                    najwieksza = aktualna;   
                }
            }

            return R;
        }

    }
}
