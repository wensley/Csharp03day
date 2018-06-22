using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e关系表达式
{
    class Program
    {
        static void Main(string[] args)
        {
            //下面是练习题讲解20180622
            //int xiang = 1500, shu = 1;
            //bool isRight = xiang > shu;
            //Console.WriteLine(isRight);

            //int tuzi = 3, wugui = 1000;
            //bool isRight = tuzi > wugui;
            //Console.WriteLine(isRight);

            //int my = 20, you = 20;
            //bool isRight = my == you;
            //Console.WriteLine(isRight);

            //逻辑运算符讲解示例
            //int age = 18;
            //int wight = 120;
            //bool result = age >= 18 && wight >= 100;
            //Console.WriteLine(result);

            //int age = 10;
            //int wight = 90;
            //bool result = age >= 18  &&  wight >= 100;
            //Console.WriteLine(result);

            //写程序让用户输入张三的身高和体重，如果需要买票输入True，否则输出False
            //火车站规定，一个人的身高>=120CM或者体重>=50Kg就必须买票
            Console.WriteLine("请输入你的身高（cm）？");
            int hight = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("请输入你的体重（kg）？");
            int wight = Convert.ToInt32(Console.ReadLine());
            bool result = hight >= 120 || wight >= 50;  //逻辑或
            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}
