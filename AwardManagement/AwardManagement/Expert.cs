namespace AwardManagement
{
    public class Expert : Person
    {
        internal override void StartRate(PersonProcess personProcess)
        {
            SetStatus("Expert");
            int projectCount = GetProjectCount();
            if (projectCount > 8)
                personProcess.Award();
            else if (projectCount < 5)
                personProcess.Fail();
            else
                WriteToScreen("Expert Seviyesindesiniz Project Sayısı " + projectCount);
        }

        internal override void Award(PersonProcess personManager)
        {
            personManager.TransitionToState(new Manager());
            WriteToScreen("Manager seviyesine geçtiniz. Project Sayısı " + GetProjectCount());
        }

        internal override void Fail(PersonProcess personManager)
        {
            personManager.TransitionToState(new Assitant());
            WriteToScreen("Assitant seviyesine geçtiniz. Project Sayısı " + GetProjectCount());
        }
    }
}
