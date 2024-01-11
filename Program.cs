using System.Collections;

internal class Program
{
    private static void Main(string[] args)
    {
        // system.collections namespace

        ArrayList list = new ArrayList();

        // list.Add("jane");
        // list.Add(2);
        // list.Add(true);
        // list.Add('A');

        // //içerisindeki verilere erişim
        // Console.WriteLine(list[1]);

        // foreach (var item in list)
        //     Console.WriteLine(item);

        //AddRange

        Console.WriteLine("Add Range");

        //string[] colors = { "Red", "yellow", "green" };
        List<int> numbers = new List<int>() { 1, 8, 3, 7, 9, 92, 5 };
        // list.AddRange(colors);
        list.AddRange(numbers);

        foreach (var item in list)
            Console.WriteLine(item);

        //Sort
        Console.WriteLine("******** Sort ***********");

        list.Sort();

        foreach (var item in list)
            Console.WriteLine(item);

        // Binary Search
        Console.WriteLine("******** Binary Search ***********");

        Console.WriteLine(list.BinarySearch(9));

        //Reverse
        Console.WriteLine("******** Reverse ***********");

        list.Reverse();
        foreach (var item in list)
            Console.WriteLine(item);

        //Clear
        Console.WriteLine("******** Clear ***********");

        list.Clear();

        foreach (var item in list)
            Console.WriteLine(item);


    }
}