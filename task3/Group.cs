namespace task3
{
    internal class Group
    {
        public string Name { get; set; }
        public Group(string name)
        {
            Name = name;
        }
        List<Group> groups = new List<Group>();
        public void Add(Group group)
        {
            if (!groups.Contains(group))
                Console.WriteLine("bu qrup artiq movcuddur");
            else
                groups.Add(group);
        }
        public void GetAllGroups()
        {
            foreach (Group group in groups)
            {
                Console.WriteLine(group.Name);
            }
        }
    }
}
