namespace AwardManagement
{
    public class Manager : Person
    {
        internal override void StartRate(PersonProcess person)
        {
            SetStatus("Manager");
            int projectCount = GetProjectCount();
            if (projectCount > 10)
                person.Award();
            else if (projectCount < 8)
                person.Fail();
            else
                WriteToScreen("Manager Seviyesindesiniz.Proje Sayısı: " + projectCount);
        }

        internal override void Award(PersonProcess personManager)
        {
            WriteToScreen("Tebrikler 2020 yılını Manager olarak tamamladınız");
        }

        internal override void Fail(PersonProcess personManager)
        {
            personManager.Fail();
        }

    }
}
