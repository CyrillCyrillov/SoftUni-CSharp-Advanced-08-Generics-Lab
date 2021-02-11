using System;

namespace GenericScale
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            

            //string[] left = new string[3] { "Ivan", "Kiril", "Alex" };
            //string[] left = new string[4] { "Ivan", "Kiril", "Alex", "Sophia" };
            //string[] right = new string[4] { "Ivan", "Kiril", "Alex", "Sophia" };

            EqualityScale<int> scale = new EqualityScale<int>(5, 6);
            //EqualityScale<int[]> scale = new EqualityScale<int[]>(new int[]{ 1, 2, 5}, new int[]{1, 2, 5 });

            Console.WriteLine(scale.AreEqual());
        }
    }
}
