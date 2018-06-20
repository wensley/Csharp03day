using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c练习题
{
    class Program
    {
        static void Main(string[] args)
        {
            //第一题
            /*
            string name;
            Console.WriteLine("请输入你的姓名：");
            name=Console.ReadLine();
            Console.WriteLine("请输入你的语文分数：");
            int chinese=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("请输入你的数学分数：");
            int math = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("请输入你的英语分数：");
            int english = Convert.ToInt32(Console.ReadLine());
            int zong = chinese + math + english;
            int ping = zong / 3;

            Console.WriteLine("{0}你的总分数为：{1}分，平均分数为{2}分。",name,zong,ping);
            Console.ReadKey();
            */

            //第二题
            try
            {
                Console.WriteLine("请输入您想要计算的天数：");
                int days = Convert.ToInt32(Console.ReadLine());
                int week = days / 7;
                int mod = days % 7; //取余数之前视频没有讲怎么用，在此栽倒！
                Console.WriteLine("{0}天是{1}周{2}天",days,week,mod);
                Console.ReadKey();

                }
                catch
                {
                Console.WriteLine("error");
                }

            //第三题

            }
    }
}
