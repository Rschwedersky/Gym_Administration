using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymAdministration.Core
{
    public class Student
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string MedicalObservation { get; private set; }
        public DateTime BirthdayDate { get; private set; }

        public StatusEnum StudentStatus { get; private set; }



        public Student(string name, string medicalObservation, DateTime birthdayDate)
        {
            Random random = new Random();
            Id = random.Next(50000, 100000);
            Name = name;
            MedicalObservation = medicalObservation;
            StudentStatus = StatusEnum.Active;

        }
    }



}
