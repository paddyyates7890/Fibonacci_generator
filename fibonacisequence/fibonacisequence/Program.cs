using System;

namespace fibonacisequence
{
    class Program
    {
        static void Main(string[] args)
        {
            fibonachi();


        }
       
        public static int fibonachi(int final = 1) 
        {
            bool run = true;
            int num1 = 0;
            int num2 = 1;

            Console.WriteLine(0);
            System.Threading.Thread.Sleep(2000);
            while (run)
            {
                Console.WriteLine(final);
                System.Threading.Thread.Sleep(2000);
                final = num1 + num2;
                num1 = num2;
                num2 = final;
            } 
            return 0;
        }
    }
}
