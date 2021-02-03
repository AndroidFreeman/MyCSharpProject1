//datatype identifier;
using System;
namespace _2_Variable
{
    class Program
    {
        static void Main(string[] args)
        {
            /*example:int i
                      int i = 100;
                      int x = 100,y = 20;
                      bool y = true;     */
            //int d;
            //Console.WriteLine(d);
            //Something.objSomething
            //这行代码仅会为Something创建一个引用,但是没有指向任何对象
            //C#实例化一个引用对象需要new关键字
            //objSomething = new Something();

            //类型推断用var关键字
            var name = "Bugs Bunny";
            var age = 25;
            var isRabbit = true;

            Type nameType = name.GetType();
            Type ageType = age.GetType();
            Type isRabbitType = isRabbit.GetType();

            Console.WriteLine("name is type" + nameType.ToString());
            Console.WriteLine("age is type" + ageType.ToString());
            Console.WriteLine("isRabbit is type" + isRabbitType.ToString());

            //变量的作用域
            for (int i = 0; i < 1; i++)
            {
                Console.WriteLine(i);
            } 

            for(int i = 9; i >= 0; i--)
            {
                Console.WriteLine(i);
            }
            //在不同的for循环中,i的数值也不同
            //我们称之为作用域

            //常量的定义
            const int a = 100;
            //常量必须在声明时初始化,指定了值就不能改写了
            //常量的值必须在编译时用于计算,不能用一个变量中提取出的值初始化
        }
    }
}
