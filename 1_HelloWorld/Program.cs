using System;
//在C#中,大多数语句都以;结尾
//使用using指令是因为用到一个库类System.Console
//using指令允许把这个类简写成Console
//没有using就是System.Console.ReadLine()
namespace Worx
{
    public class MyFirstClass
    //声明一个类,但是因为这个类在Worx里面,
    //所以完整的是Worx.MyFirstClass
    {
        static void Main()
        //每一个C#可执行文件都必须有一个入口点Main()
        //在程序启动时调用这个方法,该方法要么没有返回值,要么返回一个整数
        {
            Console.WriteLine("Hello Form Wrox.");
            Console.ReadLine();
            //此代码读取用户的输入,添加这行代码会让app等待用户按回车
            return;
        }
    }
}