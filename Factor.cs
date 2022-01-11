using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCoreProgram
{
    class Factor
    {
        public static void PrimeFactor(int n)
        {
            while (n % 2 == 0)
            {
                Console.Write(2 + " ");
                n /= 2;
            }

            for (int i = 3; i <= Math.Sqrt(n); i += 2)
            {
                while (n % i == 0)
                {
                    Console.Write(i + " ");
                    n /= i;
                }
            }

            if (n > 2)
                Console.Write(n);
        }

        internal static void PrimeFactor(int v, object n)
        {
            throw new NotImplementedException();
        }

        public static void PrimeFactor()
        {
            int n = 320;
            PrimeFactor(n);
        }

    }
}


