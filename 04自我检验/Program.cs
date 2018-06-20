using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04自我检验
{
    class Program
    {
        static void Main(string[] args)
        {
            //举一反三练习，升级编程实现用户输入的秒数是几月几周几天几小时几分钟几秒？
            Console.WriteLine("请输入你想要计算的秒数");
            int sec = Convert.ToInt32(Console.ReadLine());//用户输入的数字
            //int sec = 1689966660;
            int moth = sec / (30 * (60 * 60 * 24 * 7)); 
            int mod = sec % (30 * (60 * 60 * 24 * 7));//求到月数之后还剩多少秒
            int week = mod / (60 * 60 * 24 * 7);
            mod = mod % (60 * 60 * 24 * 7); //求到周数之后还剩多少秒
            int day = mod / (60 * 60 * 24 );
            mod = mod % (60 * 60 * 24);
            int hour = mod / (60 * 60);
            mod = mod % (60 * 60 );
            int min = mod / 60;
            mod = mod % 60;
            Console.WriteLine("你输入的{0}数字，包含{1}月{2}周{3}天{4}小时{5}分钟{6}秒。",
                sec,moth,week,day,hour,min,mod);

            Console.ReadKey();

        }
    }
}
