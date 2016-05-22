using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime
{
    class Program
    {
        static void Main(string[] args)
        {



            int n = int.Parse(Console.ReadLine());
            int a = 1;
          

            for (int i = 2; i <= n - 1; i++)
            {
                a = n % i;
                if (a == 0)
                {
                    
                    break;
                }
               
            }
            if (a==0 || n==1 || n==0 || n<0)
            {
                Console.WriteLine("Not Prime");
            }
            else                 {
                    Console.WriteLine("Prime");
                }

            
            }
        }
    }


    

