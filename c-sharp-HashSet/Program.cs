internal class Program
{
    private static void Main(string[] args)
    {
        HashSet<int> set = new HashSet<int>();
        set.Add(1);
        set.Add(2);
        set.Add(3);
        set.Add(4);
        set.Add(5);
        set.Contains(3);
       

        foreach (var item in set)
        {
            Console.WriteLine(item);
        }

        HashSet<int> ints = new HashSet<int>() { 1, 2, 4, 5, 3, 7 };
        HashSet<int> ints1 = new HashSet<int>() { 1, 8, 9, 10, 11 };
        Console.WriteLine("*******************************************");
        ints.UnionWith(ints1);
        foreach (var item in ints)
        {
            Console.WriteLine(item);
        }



    }
}