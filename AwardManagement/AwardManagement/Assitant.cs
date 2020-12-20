namespace AwardManagement
{
    public class Assitant : Person
    {
        internal override void StartRate(PersonProcess person)
        {
            SetStatus("Assitant");
            int projectCount = GetProjectCount();
            if (projectCount > 5)
                person.Award();
            else
                person.Fail();
        }

        internal override void Award(PersonProcess personManager)
        {
            personManager.TransitionToState(new Expert());
            WriteToScreen("Expert seviyesine geçtiniz. Project Sayısı " + GetProjectCount());
        }

        internal override void Fail(PersonProcess personManager)
        {
            WriteToScreen("Daha çok çalışmalısın. Proje Sayısı: " + GetProjectCount());
        }

    }
}
