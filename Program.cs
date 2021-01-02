using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 循环语句
{
    class Program
    {
        static void Main1(string[] args) //短路语句0
        {
            //短路与
            int n1 = 1, n2 = 2;
            bool re1 = n1 > n2 && n1++ > 1;//n1++是等于2的，但是n1>n2 是假的，直接不运行了出结果
            Console.WriteLine(n1);//n1 == 1 
            //对于&&运算符，当第一个操作数为false时，将不会判断第2个操作数，因此无论第2个操作数为何，最后都的运行结果一直是false。



            //短路或
            bool re2 = n1 < n2 || n2++ < 1;//n2++是等于3的，但是n1<n2是真的,直接不运行了出结果
            Console.WriteLine(n2);//n2 ==2
            //对于||运算符，当第一个操作数为trus时，将不会判断第2个操作数，因此无论第2个操作数为何，最后都的运行结果一直是trus。

        }

        static void Main2()///循环语句  跳转语句  方法
        {
            /*
            for (初始化;循环条件 ;增减变量 )
            {
                循环体
            }
            **/
            /*for (int i = 0; i < 2; ++i)
            {
               Console.WriteLine("i");
            }

            for (int i = 0; i < 2; i++)
            {
               Console.WriteLine("i");
            }   
            **/


            //int i可以作用于其他地方，与上面只是作用域不同而已，功能是一样的
            int i = 0;
            for (; i <= 6;)
            { //0 2 4 6
                Console.WriteLine("i");
                i += 2;

            }
        }


        //练习：一张纸的厚度为0.01毫米
        //计算 对折30次以后的厚度多少米
        static void Main3()
        {
            double thickness = 0.00001;
            //先定义变量在累加或其他，比较方便
            for (double i = 0; i < 30; i++)
            {
                thickness = thickness * 2;
            }
            Console.WriteLine("厚度为：" + thickness);
        }




        //1———到100累加
        static void Main4() //数据结构高斯算法
        {
            int number = 0;
            for (int i = 0; i <= 100; i++)
            {
                number = number + i;
            }
            Console.WriteLine("结果为" + number);
        }



        //while语句(和for差不多)
        static void Main5()
        {
            int i = 0;
            while (i < 5)
            {
                i++;
                Console.WriteLine("wo1");
            }
        }


        //练习：一个球从100米高度下落
        //每次落地后，弹回一半，计算最小高度（0.01米）
        static void Main6()
        {
            float i = 100;
            int k = 0;//k是多少次
            while (i / 2 >= 0.01)//i/2是下次弹起高度（不加第一次）
            {
                i = i / 2;
                k++;

                Console.WriteLine("第{0}次弹起高度为：{1}米", k, i);
                Console.WriteLine("第{0}次落地", k);
            }
        }





        //do while语句

        /*
         do
             {
                循环体
              }while(条件)；
        先执行1次循环体，再判断条件。
        **/
        static void Main7()
        {
            //练习猜数字
            //程序产生1————100之间的随机数
            //让玩家重复猜测，直到猜猜对
            //大了 小了 猜对了 多少次猜对
            Random number = new Random();//new（新）Random（随机） 创建随机的新数组
            int number2 = number.Next(1, 101);
            int number4;
            int count = 0;
            do
            {
                count++;
                Console.WriteLine("请输入数字");
                string number3 = Console.ReadLine();
                number4 = int.Parse(number3);
                if (number4 > number2)
                {
                    Console.WriteLine("大了");
                }
                else if (number4 < number2)
                {
                    Console.WriteLine("小了");
                }
                else
                {
                    Console.WriteLine("你猜对了，一共猜了{0}次", count);
                }
            } while (number2 != number4);//满足条件继续执行循环体
        }



        //
        static void Main8()
        {
            //练习猜数字
            //程序产生1————100之间的随机数
            //让玩家重复猜测，直到猜猜对
            //大了 小了 猜对了 多少次猜对
            Random number = new Random();//new（新）Random（随机） 创建随机的新数组
            int number2 = number.Next(1, 101);
            int number4;
            int count = 0;
            while (true)
            {
                count++;
                Console.WriteLine("请输入数字");
                string number3 = Console.ReadLine();
                number4 = int.Parse(number3);
                if (number4 > number2)
                {
                    Console.WriteLine("大了");
                }
                else if (number4 < number2)
                {
                    Console.WriteLine("小了");
                }
                else
                {
                    Console.WriteLine("你猜对了，一共猜了{0}次", count);
                    break;
                }
            }
        }





        static void Main9()//计算1到100之间能被3整除的数累加
        {
            int sum = 0;
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 != 0)
                {
                    continue;//跳转语句
                }
                sum += i;
            }
            Console.WriteLine("结果为：" + sum);
        }
    }
}
