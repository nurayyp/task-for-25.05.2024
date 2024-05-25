internal class CustomList<T>
{
    private T[] array;
    private int capacity;
    private int count;
    private readonly int initialCount;

    public int Capacity { get => capacity; }
    public int Count { get => count; }
    public CustomList()
    {
        array = new T[4];
        capacity = array.Length;
    }
    public void Add(T item)
    {
        if (count == Capacity)
        {
            Array.Resize(ref array, capacity == 0 ? initialCount : array.Length * 2);
            capacity = array.Length;
        }
        array[count] = item;
        count++;
    }
    public void Remove(T item)
    {
        var index = Array.IndexOf(array, item);
        if (index != -1)
        {
            for (int i = index; i < count; i++)
                array[i] = array[i + 1];

            count--;
        }
    }
    public void GetAll()
    {
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine(array[i]);
        }
    }
    public bool Contains(T item)
    {
        var index = Array.IndexOf(array, item);
        if (index != -1)
            return true;
        return false;
    }
    public void Clear()
    { 
        array = new T[0]; 
    }
    public bool Any()
    {
        if (count > 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public void FirstOrDefault()
    {
        if (count>0)
        {
            Console.WriteLine($"first - {array[0]}");
        }
        else
        {
            Console.WriteLine("default");
        }
    }
    public void LastOrDefault()
    {
        if (count>0)
            Console.WriteLine($"last - {array[array.Length - 1]}");
        else
        {
            Console.WriteLine("default");
        }
    }
    public void ElementAtOrDefault(int index)
    {
        if (index >= 0 && index < count)
        {
                Console.WriteLine($"element - {array[index]}");
        }
        else
        {
            Console.WriteLine("default");
        }
    }
}    

