using System;

namespace _4_FlowControl
{
    class Program
    {
        static void Main(string[] args)
        {
            //条件语句
            //if语句
            int i = 0;
            bool isZero;
            if (i == 0)
            {
                isZero = true;
                Console.WriteLine("i is zero");
            }
            else
            {
                isZero = false;
                Console.WriteLine("i is not zero");
            }
        }
    }
}
