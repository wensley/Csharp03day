using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace g闰年
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请你输入一个年份：");
            int year = Convert.ToInt32(Console.ReadLine());
            //bool result =(400 / year == 0) || ((year/4==0)&&(year/100!=0));运算错误
            bool result = (year % 400 == 0) || ((year % 4 == 0) && (year% 100 != 0));
            //bool result = year % 400 == 0 || year % 4 == 0 && year % 100 != 0;
            //因为运算优先级的关系，逻辑与&&高逻辑或||低，
            //所以上面不加括号运算结果也正确，只是不规范，可读性差！
            Console.WriteLine(result);

            Console.ReadKey();
            
        }
    }
}
