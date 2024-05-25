namespace task4
{
    internal class Course
    {
        List<Student> students { get; set; }
        public Course() 
        { 
            students = new List<Student>();
        }
        public void AddStudent(Student newstudent)
        {
            foreach (var student in students)
            {
                if (newstudent.PIN == student.PIN)
                {
                    Console.WriteLine("bu pinde sagird artiq movcuddur");
                    return;
                }
            }
            students.Add(newstudent);
        }
        public void RemoveStudent(Student student)
        {
            students.Remove(student);
        }
        public void DisplayStudents()
        {
            foreach (var student in students)
            {
                student.GetDetails();
            }
        }
        public void Search(string Name)
        {
            foreach (var student in students)
            {
                if (Name == student.Name)
                {
                    student.GetDetails();
                }
                else
                {
                    continue;
                }
            }
            Console.WriteLine("bele sagird yoxdur");
        }
        public void Count()
        {
            int count = 0;
            foreach (var student in students)
                if (student.Age > 18) 
                { 
                    count++;
                }
            Console.WriteLine(count);
        }
        public void Exit()
        {
            Console.WriteLine("exitted");
        }
    }
}
