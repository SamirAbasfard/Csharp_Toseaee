using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace azmon_csharp_podamn_1_tosaee_trace_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            //int k = 1;
            //for (int x = -4; x < 4; x++)
            //{
            //    k += x;
            //}
            //Console.WriteLine(k);



            //for (int g = 7; g > 3; g--)
            //{
            //    Console.WriteLine(g);
            //}


            //int q = 0;
            //for (int m = 10; m > 6; m--)
            //{
            //    q += m;            
            //}
            //    Console.WriteLine(q);





            //int q = 0;
            //for (int m = 10; m > 6; m--)
            //{
            //    q += m;
            //    Console.WriteLine(q);
            //}


            //int q = 0;for (int m = 10; m > 6; m--)q += m;Console.WriteLine(q);


            //5-	دو عدد از ورودی دریافت نموده،حاصل ضرب آنها را نمایش دهید
            //int a, b;
            //a = int.Parse(Console.ReadLine());
            //b = int.Parse(Console.ReadLine());
            //int c = a * b;
            //Console.WriteLine(c);

            //6-	دو عدد از ورودی دریافت نموده،عدد بزرگتر را نمایش دهد
            //int a, b;
            //a = int.Parse(Console.ReadLine());
            //b = int.Parse(Console.ReadLine());
            //if(a>b)
            //    Console.WriteLine(a);
            //else
            //    Console.WriteLine(b);


            //7-	سه عدد از ورودی دریافت نموده،عدد بزرگتر را نمایش دهد. 
            // 14   7   9
            // 14   18   15
            // 15  12   19

            //int a, b, c;
            //a = int.Parse(Console.ReadLine());
            //b = int.Parse(Console.ReadLine());
            //c = int.Parse(Console.ReadLine());
            //if (a > b && a > c)
            //    Console.WriteLine(a);
            //else if (b > a && b > c)
            //    Console.WriteLine(b);
            //else if (c > a && c > b)
            //    Console.WriteLine(c);


            //int x, y, z, m;
            //x = int.Parse(Console.ReadLine());
            //y = int.Parse(Console.ReadLine());
            //z = int.Parse(Console.ReadLine());
            //m = x;
            //if (m < y) 
            //    m = y;
            //if (m < z)
            //    m = z;
            //Console.WriteLine(m);


            int x, y;
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());
            if(x < y)
            {
            int t = x;
                x=y;
                y=t;
            }
            for (int i = x+1; i < y; i++)
            {
                Console.WriteLine(i);
            }




            Console.ReadKey();

        }
    }
}
