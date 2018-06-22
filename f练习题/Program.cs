using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace f练习题
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入张三的语文成绩：");
            int chinese = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("请输入张三的数学成绩：");
            int math = Convert.ToInt32(Console.ReadLine());
            //张三的语文和数学成绩都大于90分
            bool first = chinese >= 90 && math >= 90;
            //语文和数学至少一门是大于90分的
            bool sec = chinese >= 90 || math >= 90;
            Console.WriteLine("\"张三的语文和数学成绩都大于90分\":{0}",first);
            Console.WriteLine("\"语文和数学至少一门是大于90分的\":{0}", sec);


            Console.ReadKey();
        }
    }
}
