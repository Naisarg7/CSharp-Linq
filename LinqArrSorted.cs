using System;
using System.Collections.Generic;
using System.Linq;

namespace linq
{
    class sortArr
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();

            System.Console.WriteLine("Enter the number of elements to store in array : ");
            int limit = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < limit; i++)
            {
                System.Console.Write("Enter element {0} : ", i + 1);
                int element = Convert.ToInt32(Console.ReadLine());
                numbers.Add(element);
            }

            var sortedArrDesc = from Elements in numbers
                                orderby Elements descending
                                select Elements;

            var sortedArrAsce = from Elements in numbers
                                orderby Elements
                                select Elements;

            System.Console.Write("\nSorted elements in descending order : ");
            foreach (int element in sortedArrDesc)
                System.Console.Write(element + " ");

            System.Console.Write("\nSorted elements in descending order : ");
            foreach (int element in sortedArrAsce)
                System.Console.Write(element + " ");

        }
    }
}
