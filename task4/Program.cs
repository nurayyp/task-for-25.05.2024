using task4;

public static class Program
{
    public static void Main()
    {
        Course programming = new();
        Student student1 = new Student("Nuray", "Pashayeva", 18, "Nur2006");
        Student student2 = new Student("Nadir", "Qasimov", 17, "Nadir07");
        Student student3 = new Student("Aytac", "Elizade", 19, "Ay2005");
        programming.AddStudent(student1);
        programming.AddStudent(student2);
        programming.AddStudent(student3);
        programming.RemoveStudent(student1);
        programming.DisplayStudents();
        programming.Search("Nadir");
        programming.Search("Ayan");
        programming.Exit();
        programming.Count();
    }
}