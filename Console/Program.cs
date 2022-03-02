using GymAdministration.Core;

Student student1 = new Student("rodrigo", "saudavel", new DateTime(1987,05,04));
Student student2 = new Student("pedro", "saudavel", new DateTime(1987, 05, 04));
Student student3 = new Student("joao", "saudavel", new DateTime(1987, 05, 04));
Student student4 = new Student("rafael", "saudavel", new DateTime(1987, 05, 04));
Student student5 = new Student("luisa", "saudavel", new DateTime(1987, 05, 04));
Student student6 = new Student("bruna", "saudavel", new DateTime(1987, 05, 04));
Student student7 = new Student("carolina", "saudavel", new DateTime(1987, 05, 04));
Student student8 = new Student("joana", "saudavel", new DateTime(1987, 05, 04));
Student student9 = new Student("maria", "saudavel", new DateTime(1987, 05, 04));
Student student10 = new Student("zion", "saudavel", new DateTime(1987, 05, 04));

Employee employee1 = new Employee(01, "augusto", DateTime.Now);


ActivityClass class1 = new ActivityClass("musculação", "salao grande", DateTime.Now, employee1, student9);

Equipament equipament = new Equipament(01, "LegPress", "legs", DateTime.Now);

Console.WriteLine("----------Student------------");
Console.WriteLine($"Client: {student1.Name} Status: {student1.StudentStatus}");
Console.WriteLine("");
Console.WriteLine("----------Classes------------");
Console.WriteLine($"Name:{class1.Name} " +
    $"      local:{class1.Description}");
Console.WriteLine("");
Console.WriteLine("----------Employee------------");
Console.WriteLine($"Teacher: {employee1.Name} Id: {employee1.Id}");
Console.WriteLine("");
Console.WriteLine("----------Main equipament------------");
Console.WriteLine($"Equipament: {equipament.Name} Id: {equipament.Id}");
Console.WriteLine("************************************");
Console.WriteLine("");