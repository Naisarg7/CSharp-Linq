/*  Using the linq query to sort the list elements
 *  in ascending order and asking the user from which specific value
 *  to apply the sorting.
 */
using System;
using System.Linq;
using System.Collections.Generic;

namespace linq {
    class LinqSortSpecificMembers
    {
        static void Main(string[] args)
        {
            List<Int32> userInputList = new List<Int32>();

            System.Console.Write("Enter the number of elements you want to store in list : ");
            int size = Convert.ToInt32(Console.ReadLine());

            System.Console.WriteLine();
            for( int i = 0; i < size ; i++ )
            {
                System.Console.Write("Enter value {0} => ", i+1);
                int listMembers = Convert.ToInt32(Console.ReadLine());
                userInputList.Add(listMembers);
            }

            System.Console.WriteLine("\nEnter value from which to sort the list : ");
            int sortFromValue = Convert.ToInt32(Console.ReadLine());

            var sortSpecific = from numbers in userInputList
                               orderby numbers where numbers >= sortFromValue   // by adding keyword 'descending', we can retrieve the result in reversed order
                               select numbers;

            
            System.Console.WriteLine("\nSorted elements having value greater than {0} : ",sortFromValue);
            foreach( int member in sortSpecific )
            {
                System.Console.Write( member + " " );
            }
        }
    }
}