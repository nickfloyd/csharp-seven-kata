using System;

namespace csharp_seven_kata
{
    /*
     * From: https://docs.microsoft.com/en-us/dotnet/articles/csharp/csharp-7#throw-expressions
     * In C#, throw has always been a statement. Because throw is a statement, not an expression, there were C# constructs where you could not use it.
     * These included conditional expressions, null coalescing expressions, and some lambda expressions.
     * The addition of expression-bodied members adds more locations where throw expressions would be useful.
     * So that you can write any of these constructs, C# 7 introduces throw expressions.
     *
     * The syntax is the same as you've always used for throw statements. 
     * The only difference is that now you can place them in new locations, such as in a conditional expression.
     */
    public class ThrowExpressionsKata
    {
        // KATA: Take this assignment out of the constructor and throw an error when Settings is initialized to null
        // Hint: You should be able to remove the null check from the constructor
        // Hint: You should be able to move the initialization logic from the setter on the property to the private and use an expression body to initialize and throw if null
        // Note: Doing exceptions this way will cause exceptions to be thrown during the construction of an object. This is generally discouraged. 
        public ThrowExpressionsKata() {
            if (Settings == null) {
                throw new ArgumentNullException("Could not load settings");
            }
        }


        private ISettings settings;
        public ISettings Settings { get => settings; set => settings = InitializeSettings(); }

        // KATA: Replace the conditional in the setter with an expression-body (see the getter) and a throw expression
        // Making the setter a single line of code.
        // Hint: you can use the null coalese 
        // Note: Doing exceptions this way will cause exceptions to be thrown during the construction of an object.  This is generally discouraged. 
        private string propertyException = "Default";
        public string PropertyException
        {
            get => propertyException;
            set
            {
                if (value != null)
                {
                    propertyException = value;
                }
                else {
                    throw new ArgumentNullException("Cannot assign null");
                }
            }
        }

        private ISettings InitializeSettings() {
            return null;
        }
        
    }

    public interface ISettings {
        int Id { get; set; }
        string Name { get; set; }
    }

    public class Settings : ISettings {
        public int Id { get; set; }
        public string Name { get; set; }
    }

}

