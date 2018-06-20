using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bConvert转换
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("请输入你的语文成绩？");
            //string chinese = Console.ReadLine();
            //Console.WriteLine("请输入你的数学成绩？");
            //string math = Console.ReadLine();

            //int chineseScore = Convert.ToInt32(chinese);
            //int mathScore = Convert.ToInt32(math);

            //简化代码
            //Console.WriteLine("请输入你的语文成绩？");
            //int chinese = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("请输入你的数学成绩？");
            //int math = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("你的总成绩为：{0}",chinese+math);

            try
            {
                Console.WriteLine("请输入你的语文成绩？");
                int chinese = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("请输入你的数学成绩？");
                int math = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("你的总成绩为：{0}", chinese + math);
            }
            catch
            {
                Console.WriteLine("你刚刚输入的代码有问题，请重新运行！");
            }

            /*C# 中异常捕获如何来完成：
            try
            {
                有可能出现错误的代码写在这里
            }
            catch
            {
                出错后的处理
            }
            上面的程序如何执行：
            如果try中的代码没有出错，则程序正常运行try中的内容后，不会执行catch中的内容；
            如果try中的代码一旦出错，程序立即跳入catch中去执行代码，那么try中的出错代码后面的代码不在执行了。*/

            Console.ReadKey();

        }
    }
}
