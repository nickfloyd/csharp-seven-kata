using System;
using System.Collections.Generic;
using System.Linq;

namespace csharp_seven_kata
{

    /*
     * From: https://docs.microsoft.com/en-us/dotnet/articles/csharp/csharp-7#local-functions
     * Many designs for classes include methods that are called from only one location.
     * These additional private methods keep each method small and focused.
     * However, they can make it harder to understand a class when reading it the first time.
     * These methods must be understood outside of the context of the single calling location.
     *
     * For those designs, local functions enable you to declare methods inside the context of another method.
     * This makes it easier for readers of the class to see that the local method is only called from the context in which is it declared.
     *
     * There are two very common use cases for local functions: public iterator methods and public async methods.
     * Both types of methods generate code that reports errors later than programmers might expect.
     * In the case of iterator methods, any exceptions are observed only when calling code that enumerates the returned sequence.
     * In the case of async methods, any exceptions are only observed when the returned Task is awaited.
     */
    public class LocalFunctionsKata
    {
        // KATA: Collapse ManufactureWidgets, BuildWidget, and GenerateWidgetName all into a single method with local functions.
        // Note: Make sure to nest according to scope and use

        public List<Widget> ManufactureWidgets() {

            var widgets = new List<Widget>();

            for (int i = 0; i < 10; i++)
            {
                widgets.Add(BuildWidget(i, $"Widget{i}"));
            }

            return widgets;
        }

        private Widget BuildWidget(int id, string name) {
            var newName = GenerateWidgetName(name);
            return new Widget { Id = id, Name = newName };
        }

        private string GenerateWidgetName(string name) {
            var random = new Random();
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            return new string(
                Enumerable.Repeat(chars, name.Length)
              .Select(s => s[random.Next(s.Length)]).ToArray()
              );
        }
    }

    public class Widget {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
