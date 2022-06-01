using System;
using System.IO;
namespace CreateFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            string file = "/Users/Armin/Desktop/Cs/names.txt";
            //Directory.CreateDirectory(@"/Users/Armin/Desktop/Cs/Cucumber");
            //StreamWriter sw = new StreamWriter(file,true);
            //sw.WriteLine("James");
            //sw.WriteLine("Harden");
            //sw.Close();

            StreamReader sr = new StreamReader(file);
            Console.WriteLine(sr.ReadToEnd());
            Console.WriteLine("End of File");
            sr.Close();
        }
    }
}
