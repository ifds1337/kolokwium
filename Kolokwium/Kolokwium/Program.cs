using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium
{
    public class Program
    {
        public static int P, Q, R;

        public static void Main(string[] args)
        { 
            int[] A = new int[] { -3, 1, 2, -2, 5, 6};
            int wynik;

            wynik = ZnajdzTriplet(A);

            Console.WriteLine(wynik);
            Console.WriteLine(P);
            Console.WriteLine(Q);
            Console.WriteLine(R);
            Console.ReadKey();

        }

        public static int LiczTriplet(int[] A, int P, int Q, int R)
        {
            return (A[P] * A[Q] * A[R]);
        }

        public static int ZnajdzTriplet(int[] A)
        {
            int aktualna;
            int najwieksza = 0;


            for (int i = 5; i>=0; i--)
            {
                aktualna = A[i];

                if(aktualna > najwieksza)
                {
                    R = i;
                    najwieksza = aktualna;   
                }
            }

            for (int i = R; i >= 0; i--)
            {
                aktualna = A[i];

                if (aktualna > najwieksza)
                {
                    Q = i;
                    najwieksza = aktualna;
                }
            }

            for (int i = P; i >= 0; i--)
            {
                aktualna = A[i];

                if (aktualna > najwieksza)
                {
                    P = i;
                    najwieksza = aktualna;
                }
            }

            return LiczTriplet(A,P,Q,R);
        }

    }
}
