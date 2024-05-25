namespace task4
{
    internal class Student
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string PIN { get; set; }
        public Student(string name, string surname, int age, string pin)
        {
            Name = name;
            Surname = surname;
            Age = age;
            PIN = pin;
        }
        public void GetDetails()
        {
            Console.WriteLine($"{Name},{Surname},{Age},PIN-****");
        }
    }
}
