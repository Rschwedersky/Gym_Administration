namespace GymAdministration.Core
{
    public class Employee
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public DateTime StartedDate { get; private set; }
        public DateTime? FinishedDate { get; private set; }

        public StatusEnum Status { get; private set; }



        public Employee(int id, string name, DateTime startedDate)
        {
            Random random = new Random();
            Id = random.Next(50000, 100000);
            Name = name;
            StartedDate = startedDate;
            Status = StatusEnum.Active;

        }
    }



}