using System;

namespace csharp_seven_kata
{
    /*
     * From: https://docs.microsoft.com/en-us/dotnet/articles/csharp/csharp-7#out-variables
     * Previously, you would need to separate the declaration of the out variable and its initialization into two different statements.
     * You can now declare out variables in the argument list of a method call, rather than writing a separate declaration statement.
     */
    public class OutVariablesKata
    {
        // KATA: Convert the method body to use an inline out varible 
        // Note: When declaring the inline out varible you can use either an implicit (var) or explicit (int) type
        public int ParseInteger(string val) {
           
            if (!int.TryParse(val, out var parsedInt))
            {
                parsedInt = int.MinValue;
            }

            return parsedInt;
        }
    }
}
