using System;

namespace 运行
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入4位整数");
            string number3 = Console.ReadLine();
            char c1 = number3[0];
            string s1 = c1.ToString();
            int n1 = int.Parse(s1);
            char c2 = number3[1];
            string s2 = c2.ToString();
            int n2 = int.Parse(s2);
            char c3 = number3[2];
            string s3 = c3.ToString();
            int n3 = int.Parse(s3);
            char c4 = number3[3];
            string s4 = c4.ToString();
            int n4 = int.Parse(s4);
            int result = n1 + n2 + n3 + n4;
            Console.WriteLine("结果为:" + result);
        }
    }
}
