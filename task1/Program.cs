public static class Program
{
    public static void Main(string[] args)
    {
        CustomList<int> list = new CustomList<int>();
        list.Add(1);
        list.Add(3);
        list.Add(4);
        list.Remove(4);
        list.Add(5);
        list.Remove(3);
        list.GetAll();
        list.ElementAtOrDefault(0);
        list.ElementAtOrDefault(3);
        list.FirstOrDefault();
        list.LastOrDefault();
    }
}