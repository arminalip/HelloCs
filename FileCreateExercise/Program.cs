using System;
using System.IO;

namespace FileCreateExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter sw;
            string language = string.Empty;
            int count = Enum.GetNames(typeof(Languages)).Length;

            for (int i = 0; i < count; i++)
            {
                language = Enum.GetValues(typeof(Languages)).GetValue(i).ToString();
                Console.WriteLine(language);
                Directory.CreateDirectory("/Users/Armin/Desktop/Cs/Languages");
                Directory.CreateDirectory("/Users/Armin/Desktop/Cs/Languages/" + language);
                sw = new StreamWriter("/Users/Armin/Desktop/Cs/Languages/" + language + "/log.txt");
                sw.WriteLine("File no " + i + " created on " + DateTime.Now);
                sw.Close();
            }
        }
    }

    enum Languages
    {
        Arabic,
        Azerbaijani,
        Bengali,
        Czech,
        Dutch,
        English,
        French,
        German,
        Greek,
        Hindi,
        Hungarian,
        Italian,
        Japanese,
        Javanese,
        Korean,
        Kurdish,
        Malay,
        Mandarin,
        Persian,
        Polish,
        Portuguese,
        Romanian,
        Russian,
        Spanish,
        Swedish,
        Thai,
        Turkish,
        Ukrainian,
        Urdu,
        Vietnamese,
        Zulu
    }
}
