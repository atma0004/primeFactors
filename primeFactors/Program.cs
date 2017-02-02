using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primeFactors
    {
    class Program
        {
        static void Main(string[] args)
            {
            long a = 600851475143;
            long ta = 0;
            for (long i = 2; i<=a;)
                {
                if (a%i==0)
                    {
                    a/=i;
                    ta=i;
                    }
                else
                    i++;
                }
            Console.Write(ta.ToString());
            Console.ReadLine();
            }
        }
    }
