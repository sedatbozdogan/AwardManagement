using System;

namespace AwardManagement
{
    public abstract class Person
    {
        private string Status;
        private string Name;
        private string Surname;
        private int ProjectCount;

        internal abstract void StartRate(PersonProcess ticket);
        internal abstract void Award(PersonProcess personManager);
        internal abstract void Fail(PersonProcess personManager);

        public void SetName(string name)
        {
            Name = name;
        }

        public void SetSurname(string surname)
        {
            Surname = surname;
        }

        public string GetNameSurname()
        {
            return string.Format($"{Name} {Surname}");
        }

        public void SetProjectCount(int projectCount)
        {
            ProjectCount = projectCount;
        }

        public int GetProjectCount()
        {
            return ProjectCount;
        }

        public void SetStatus(string status)
        {
            Status = status;
        }

        public string GetStatus()
        {
            return Status;
        }

        public void WriteToScreen()
        {
            string _text = $"Status: {Status} Name: {Name} Surname: {Surname} ProjectCount: {ProjectCount}";
            Console.WriteLine(_text);
        }

        public void WriteToScreen(string Text)
        {
            Console.WriteLine(Text);
        }

    }
}
