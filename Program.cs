using System;

namespace GenericKeyValue
{
    class Program
    {
        static void Main(string[] args)
        {
            var d = new MyDictionary();
            try
            {
                Console.WriteLine(d["Water1"]);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            d["Water1"] = 42;
            d["Monster2"] = 100;
            Console.WriteLine($"{(int)d["Water1"]}, {(int)d["Monster2"]}");
            d["Water1"] = 85;
            d["Monster2"] = 45;
            Console.WriteLine($"{(int)d["Water1"]}, {(int)d["Monster2"]}");
            Console.ReadLine();
        }
    }
}
