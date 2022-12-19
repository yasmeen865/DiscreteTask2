using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_2
{
    internal class Program
    {
       
        
            public static int Factors(int n2)
            {
                int sum = 0;
                for (int i = 1; i < n2; i++)
                {
                    if (n2 % i == 0)
                    {
                        sum = sum + i;
                    }
                }

                return sum;
            }


            public static void Main(string[] args)
            {
                int n2, n1;

                Console.WriteLine("enter frist number");
                n1 = int.Parse(Console.ReadLine());

                Console.WriteLine("enter provide number");
                n2 = int.Parse(Console.ReadLine());

                for (int i = n1; i <= n2; i++)
                {
                    int result = Factors(i);
                    if (result == i)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
    }
}
