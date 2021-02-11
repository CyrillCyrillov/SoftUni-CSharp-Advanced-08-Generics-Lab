using System;

namespace GenericScale
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            //int left = int.Parse(Console.ReadLine());
            //int right = int.Parse(Console.ReadLine());

            //string left = Console.ReadLine();
            //string right = Console.ReadLine();

            string[] left = new string[3] { "Ivan", "Kiril", "Alex" };
            //string[] left = new string[4] { "Ivan", "Kiril", "Alex", "Sophia" };
            string[] right = new string[4] { "Ivan", "Kiril", "Alex", "Sophia" };

            bool isEquality = EqualityScale.AreEqual(left, right);

            

            Console.WriteLine(isEquality);
        }
    }
}
