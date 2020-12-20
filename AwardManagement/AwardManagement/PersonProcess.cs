namespace AwardManagement
{
    public class PersonProcess
    {
        private Person Person;

        private PersonProcess(string Name, string Surname, int ProjectCount, Person person)
        {
            Person = person;
            Person.SetStatus("Assitant");
            Person.SetName(Name);
            Person.SetSurname(Surname);
            Person.SetProjectCount(ProjectCount);
            Person.WriteToScreen();
        }

        public static PersonProcess CreatePerson(string name, string surname, int projectCount)
        {
            PersonProcess personManager = new PersonProcess(name, surname, projectCount, new Assitant());
            return personManager;
        }

        internal void TransitionToState(Person newStatus)
        {
            Person = newStatus;
        }

        internal void Award()
        {
            Person.Award(this);
        }

        internal void Fail()
        {
            Person.Fail(this);
        }

        public void StartRate()
        {
            Person.StartRate(this);
        }

        public void SetProjectCount(int projectCount)
        {
            Person.SetProjectCount(projectCount);
        }

    }
}
