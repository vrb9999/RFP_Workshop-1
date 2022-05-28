using System;

namespace primeFactorisation
{
//    Factors
//a.Desc ­> Computes the prime factorization of N using brute force.
//b.I/P ­> Number to find the prime factors
//c.Logic ­> Traverse till i* i <= N instead of i <= N for efficiency.
//d.O/P ­> Print the prime factors of number N.
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number to get prime factorization : ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i=1; i<=n; i++)
            {
                if(n % i == 0)
                {
                    Console.WriteLine("Prime factors :" + i);
                }
            }
        }
    }
}
