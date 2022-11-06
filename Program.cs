namespace Based
{
    class Program
    {
        static void Main(string[] args)
        {
        MyList<int> list = new MyList<int>();
        list.Add(12);
        list.Add(42);
        list.Replace(0, 1);
        Console.WriteLine($"Length of list is: {list.Capacity()}");
        Console.WriteLine($"Element of index 0 is: {list.Indexator(0)}");
        Console.WriteLine($"Length of list is: {list.Capacity()}");
        Console.WriteLine($"Element of index 1 is: {list.Indexator(1)}");
        Console.WriteLine($"Length of list is: {list.Capacity()}");
        Console.WriteLine($"Element of index 2 is: {list.Indexator(2)}");
        Console.WriteLine("End of Task 1!");

        
        }
    }
}
