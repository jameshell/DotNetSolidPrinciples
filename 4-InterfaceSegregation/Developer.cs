namespace InterfaceSegregation
{
    public class Developer : IWorkTeamActivities, IDevelopActivities
    {
        public Developer()
        {
        }

        public void Develop()
        {
            throw new NotImplementedException();
        }

        public void Plan()
        {
            throw new NotImplementedException();
        }

        public void Communicate()
        {
            throw new NotImplementedException();
        }
    }
}