using System;
using System.Threading.Tasks;

namespace csharp_seven_kata
{
    /*
     * From: https://docs.microsoft.com/en-us/dotnet/articles/csharp/csharp-7#generalized-async-return-types
     * Returning a Task object from async methods can introduce performance bottlenecks in certain paths.
     * Task is a reference type, so using it means allocating an object.
     *
     * In cases where a method declared with the async modifier returns a cached result, or completes synchronously,
     * the extra allocations can become a significant time cost in performance critical sections of code. 
     * It can become very costly if those allocations occur in tight loops.
     *
     * The new language feature means that async methods may return other types in addition to Task, Task<T> and void.
     * The returned type must still satisfy the async pattern, meaning a GetAwaiter method must be accessible.
     * As one concrete example, the ValueTask type has been added to the .NET framework to make use of this new language feature.
     */

    public class AsyncReturnKata
    {
        // KATA: Convert this method to use the new "ValueTask" syntax; specifically to use ValueTask<string>
        // Note: You will need the System.Threading.Tasks.Extensions nuget package. ValueTask is not yet in C# 7
        // Note: Even in this contrived scenario, ValueTask should still be faster than Task
        // Note: In this method's current form it uses Heap allocation

        // Bonus: Duplicate the existing method, test and compare the timings of Task vs ValueTask
        public async Task<string> ProcessWidget(int delay)
        {
            await Task.Delay(delay);
            return "Widget processed";
        }
    }
}
