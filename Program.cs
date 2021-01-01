using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 字符串池
{
    class Program
    {
        static void Main1(string[] args)
        {
            //字符串池
            //可以提高内存的利用率（优化）
            string s1 = "八戒";
            string s2 = "八戒";//同一个字符串
            bool r1 = object.ReferenceEquals(s1, s2);
            string s3 = new string(new char[] { '八','戒' });
            string s4 = new string(new char[] { '八', '戒' });
            bool r2 = object.ReferenceEquals(s3, s4);//不是同一个，因为new

            s1 = "悟空";
            //字符串不可变性
            //重新开辟空间 存储 新字符串，再替换栈中引用
            //每次修改都是重新开辟新的空间存储数据，替换栈中引用
            Console.WriteLine(s1);
            string strNumber = "";
            for (int i = 0; i < 10; i++)
            {
                //这种拼接会消耗大量内存性能
                //产生大量垃圾，gc就要运行
                //""+"0"
                //"0"+"1"
                strNumber += i.ToString();
            }
            Console.WriteLine(strNumber);
            //可变字符串  一次开辟可以容纳10个字符大小的空间
            //优点：可以避免产生垃圾
            StringBuilder NewNumber = new StringBuilder(10);
            for (int i = 0; i < 10; i++)
            {
                NewNumber.Append(i);
            }
            NewNumber.Append("我来了");//超过字节，又重新开辟更大的空间
            // s1 = NewNumber.Insert(0,"s1");插入 有返回值
            //NewNumber.Replace();替换
            //NewNumbe .Remove();删除
            string result = NewNumber.ToString();//这是转换为string

            int a;//在栈中
            a = 1;//数据1存储数据在栈中

            int[] arr01 = new int[2];//在栈中
            arr01[0] = 1;//数据存储在堆中 arr01 存数据的引用 这个是值类型

            string[] arr02 = new string[1];//在栈中，存的是数据的引用
            arr02[0] = "how";//在堆中，arr02存的是how在堆中的数据的引用   这个是引用类型
            arr02[0] = "are";//在堆中，把arr02[0]的内存地址改掉  这个是引用类型

            string name = "two";//在栈中 two在堆中
            name = "one";//把内存地址改为one在堆中所在的内存地址


        }
        static void Main(string[] args) 
        {
            //1.单词反转 how are you ==>you are how
            //2.uoy era woh
            //3.查找指定字符串不重复出现的文字（重复的文字保留一个）
        }
    }
}
