using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace h与或短路
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 5;
            bool result = ++a > 5 && ++b > 1;
            //a=11   b=5
            //在进行逻辑与运算的时候，由于要求两边的表达式都为True，
            //所以当第一个为False的时候，后面的表达式不在进行运算；

            bool result = ++a > 5 || ++b > 1;
            //a=11   b=5;在进行逻辑或运算的时候，由于要求两边的表达式有一个为True，其结果为True;
            bool result = ++a > 50 || ++b > 1;
            //a=11   b=6
            //当逻辑或前面的表达式不成立时，才会进行后面表达式的运算;

            Console.WriteLine("a={0}     b={1}",a,b);
            Console.ReadKey();

        }
    }
}
