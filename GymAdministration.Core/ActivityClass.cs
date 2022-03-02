using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymAdministration.Core
{
    public class ActivityClass
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Description { get; private set; }
        public DateTime StartedDate { get; private set; }
        public DateTime FinishedDate { get; private set; }

        public StatusEnum Status { get; private set; }

        public Employee Employee { get; private set; }

        public Student Student { get; private set; }

        public ActivityClass(int id, string name, string description, DateTime startedDate, DateTime finishedDate, StatusEnum status, Employee employee, Student student)
        {
            Random random = new Random();
            Id = random.Next(50000, 100000);
            Name = name;
            Description = description;
            StartedDate = startedDate;
            FinishedDate = finishedDate;
            Status = StatusEnum.Active;
            Employee = employee;
            Student = student;

        }
    }
}
