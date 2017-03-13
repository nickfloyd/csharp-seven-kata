namespace csharp_seven_kata
{
    /*
     * From: https://docs.microsoft.com/en-us/dotnet/articles/csharp/csharp-7#more-expression-bodied-members
     * C# 6 introduced expression-bodied members for member functions, and read-only properties.
     * C# 7 expands the allowed members that can be implemented as expressions.
     * In C# 7, you can implement constructors, finalizers, and get and set accessors on properties and indexers.
     */
    public class ExpressionBodyKata
    {
        // KATA: Write the following property using the Expression-bodied get / set accessors syntax
        private string expressionBody;
        public string ExpressionBody {
            get {
                return expressionBody;
            }
            set {
                expressionBody = value;
            }
        }

        // KATA: Write the following constructor using the Expression-bodied syntax
        public ExpressionBodyKata(string expressionBody) {
            ExpressionBody = expressionBody;
        }

        // KATA: Write the following property using the Expression-bodied finalizer
        // Note: It should be called out that this class does not need or should implement a finalizer (destructor) but for the kata one has been added
        ~ExpressionBodyKata() {
            expressionBody = null;
        }
        
    }
}
