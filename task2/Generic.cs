namespace task2
{
    internal class Generic<T>
    {
        public void SwapValues(T value1, T value2)
        {
            T addition;
            addition = value1;
            value1 = value2;
            value2 = addition;
            Console.WriteLine($"{value1}, {value2}");
        }
    }
}
