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
           /* try
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
                }*/
                //视频没有声音……
            //第三题:编程实现107653秒是几天几小时几分钟几秒？
                int sec = 107653;
                int days = sec/(3600*24);
                int mod = sec % (3600 * 24);//除去上面的天数，还剩多少秒
                int hour =mod /3600;//看看剩余的秒数还有多少个3600秒
                mod = mod % 3600;//看看生于的秒数中出去上面算的小时，还剩余多少秒
                int min = mod/60;//看看剩余的秒数中有几个60秒，就是几分钟
                mod = mod % 60;
            Console.WriteLine("{0}秒是{1}天{2}小时{3}分{4}秒！",sec,days,hour,min,mod);

            Console.ReadKey();

            }
    }
}
