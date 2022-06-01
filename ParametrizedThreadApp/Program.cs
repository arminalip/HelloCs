using System;
using System.Threading;

namespace ParametrizedThreadApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Helper helper = new Helper();
            Thread t1 = new Thread(new ParameterizedThreadStart(helper.Loop));
            t1.Start(100);
        }
    }

    class Helper
    {
        public void Loop(object number)
        {
            for (int i = 0; i < int.Parse(number.ToString()); i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
