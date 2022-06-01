using System;
using System.IO;

namespace EnhacementofRecursiveMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            ShowAllFoldersUnder(@"/Users/Armin/Desktop/Cs", 0);
        }

        private static void ShowAllFoldersUnder(string path, int indent)
        {
            foreach (var folder in Directory.GetDirectories(path))
            {
                files(folder, indent);
                Console.WriteLine("{0}{1}", new string(' ', indent), folder + " : created on (" + File.GetCreationTime(folder) + ")");
                ShowAllFoldersUnder(folder, indent + 2);
            }
        }

        public static void files(string folder, int indent)
        {
            string[] dirs = Directory.GetFiles(folder);

            foreach (var dir in dirs)
            {
                Console.WriteLine("{0}{1}", new string(' ', indent), dir + " : created on (" + File.GetCreationTime(dir) + ")");
            }
        }
    }
}
