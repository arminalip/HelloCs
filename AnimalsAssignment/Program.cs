using System;
using System.Diagnostics;
namespace AnimalsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            GermanShepard max = new GermanShepard();
            max.Origin = Origins.Germany;
            max.Name = "Max";
            max.BirthDate = new DateTime(2017, 10, 10);
            max.Gender = Gender.Male;
            max.Weight = 32.54;
            max.SecurityGuard = false;
            max.Size = Sizes.Large;
            max.Training = TrainingAbility.Easy;
            max.DisplayDogInformation();
            max.Sit(max.Name);
            max.Eat();
            max.SayHi();
            Debug.WriteLine("Test!");
        }
    }
}
