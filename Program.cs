using System;

namespace DezToBin
{
    class Program
    {
        public static String x(int n)
        {
            String s = "";
            while (n > 0)
            {
                s = ((n % 2) == 0 ? "0" : "1") + s;
                n = n/ 2;
            }
            return s;
        }
        static void Main(string[] args)
        {

            Console.WriteLine("Hello World!");
            Console.WriteLine(x(0));
            Console.WriteLine(x(5));
            Console.WriteLine(x(42));
        }
    }
}
