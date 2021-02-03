using System;

namespace _3_Predefine
{
    class Program
    {
        static void Vector()
        {

        }
        static void Main(string[] args)
        {
            //值类型与引用类型
            int i = 20;
            //值类型 --- 存储在堆栈上
            int j = i;
            //引用类型---存储在托管堆上


            //CTS类型
            string k = i.ToString();

            //预定义的值类型
            //整形
            sbyte sbyteA = 127;
            short shortA = 32767;
            int intA = 2147483647;
            long longA = 9223372036854775807;
            byte byteA = 255;
            ushort ushortA = 65535;
            uint uintA = 4294967295;
            ulong ulongA = 18446744073709551615;
            //浮点类型
            float floatA = 3.4E38f;
            double doubleA = 1.7 * 10E307;
            //decimal类型
            decimal decimalA = 12.90000000000M;
            //bool类型
            bool boolA = true;
            //字符类型
            char charA = 'A';

            //预定义的引用类型
            //string类型
            string stringA = "Hello ";
            string stringB = "World!";
            string stringC = stringA + stringB;
            //注意:修改其中一个字符串,就会创建一个全新的string对象
            string exampleA = "Fly Away";
            string exampleB = exampleA;
            Console.WriteLine(exampleA + exampleB);
            exampleA = "Go Away";
            Console.WriteLine(exampleA + exampleB);
            //改变exampleA的值对B没有影响,
            //改变A的值时,堆上会为新值分配一个新对象,B还是原来的对象

        }
    }
}
