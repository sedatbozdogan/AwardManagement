using System;

namespace AwardManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonProcess person = PersonProcess.CreatePerson("Sedat", "Bozdogan", 5);
            person.StartRate();
            person.SetProjectCount(6);
            person.StartRate();
            person.SetProjectCount(8);
            person.StartRate();
            person.SetProjectCount(9);
            person.StartRate();
            Console.ReadLine();
        }
    }
}
