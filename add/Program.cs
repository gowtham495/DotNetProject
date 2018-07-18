using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace add
{
    
        public class program
        {
            public int sum(int n1, int n2)
            {
                int c;
                c = n1 + n2;
                return c;
            }
            public static void Main(String[] args)
            {
                program d = new program();
                Console.WriteLine("enter the number");
                int a = int.Parse(Console.ReadLine());

                Console.WriteLine("enter the number");
                int b = int.Parse(Console.ReadLine());




                Console.WriteLine("the number is:{0}", d.sum(a, b));

            }

        }
    }

