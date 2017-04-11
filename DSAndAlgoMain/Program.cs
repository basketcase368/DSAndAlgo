using System;
using DSAndAlgo.Lib;

namespace DSAndAlgoMain
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var da = new DynamicArray<int>();
            Console.WriteLine("Current Size: {0}", da.GetSize());
            da.Add(1);
            Console.WriteLine("Current Size: {0}", da.GetSize());
            da.Add(2);
            Console.WriteLine("Current Size: {0}", da.GetSize());
            da.Add(3);
            Console.WriteLine("Current Size: {0}", da.GetSize());
            da.Add(4);
            Console.WriteLine("Current Size: {0}", da.GetSize());
            da.Add(5);

            Console.ReadLine();
        }
    }
}