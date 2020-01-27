using System;
using System.Collections.Generic;

namespace TwoSum
{
    class Program
    {
        public static Tuple<int, int> FindTwoSum(IList<int> list, int sum)
        {

                //create a new tuple and assign it a null reference
                Tuple<int, int> myTuple = null;

                //iterate through all indices checking if there is a combination that adds up to sum
                for (int firstIndex = 0; firstIndex < list.Count - 1; firstIndex++)
                {
                    for (int secondIndex = firstIndex + 1; secondIndex < list.Count; secondIndex++)
                    {
                        //if there exists such a combination, get the indices and assign them as values to "myTuple"
                        if (list[firstIndex] + list[secondIndex] == sum)
                        {
                            myTuple = Tuple.Create(list[firstIndex], list[secondIndex]);

                        }
                    }
                }

                //return "myTuple" with the last pair of those newly inserted values
                return myTuple;
        }

        public static void Main(string[] args)
        {
            try
            {
                Tuple<int, int> indices = FindTwoSum(new List<int>() { 1, 3, 5, 7, 9 }, 12);
                Console.WriteLine(indices.Item1 + " " + indices.Item2);
            }

            catch(NullReferenceException)
            {
                Console.WriteLine("The list contains no such two distinct elements");
            }
        }
    }
}
