using System;

namespace csharp_seven_kata
{
    /*
     * From: https://docs.microsoft.com/en-us/dotnet/articles/csharp/csharp-7#tuples
     * C# provides a rich syntax for classes and structs that is used to explain your design intent.
     * But sometimes that rich syntax requires extra work with minimal benefit.
     * You may often write methods that need a simple structure containing more than one data element.
     * To support these scenarios tuples were added to C#.
     * Tuples are lightweight data structures that contain multiple fields to represent the data members.
     * The fields are not validated, and you cannot define your own methods.
     */

    /*
     * The primary reason for introduction of ValueTuple is performance.
     *
     * Differences between ValueTuple and Tuple:
     *
     *                       [ValueTuple]            [Tuple]
     * Class or structure     struct                  class
     * Mutability             mutable                 immutable
     * Naming members         yes                     no (TBD)
     */


    // Note: You will need the System.ValueTuple nuget package to complete this kata
    // https://www.nuget.org/packages/System.ValueTuple/
    public class TupleKata
    {

        // KATA: Convert the two methods below to one method that returns a ValueTuple (int StringCount, int IntCount).
        // Modify the unit test to validate the values from the new tuple.
        private string[] StringArr= new string[] { "one", "two", "three", "four"};
        private int[] IntArr = new int[] {1,2,3};

        public int GetStringCount() {
            return StringArr.Length;
        }

        public int GetIntCount()
        {
            return IntArr.Length;
        }


    }
}
