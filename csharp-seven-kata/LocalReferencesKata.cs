using System;

namespace csharp_seven_kata
{
    /*
     * From: https://docs.microsoft.com/en-us/dotnet/articles/csharp/csharp-7#ref-locals-and-returns
     * This feature enables algorithms that use and return references to variables defined elsewhere.
     * These are useful for changing and returning references to specific memory instead of copying memory.
     * 
     * Avoiding the overhead of copying resources or pinning memory can be benefitial for high performance applications.
     */
    public class LocalReferencesKata
    {
        //KATA: Replace _shootingStar.SetMessage(message) using ref locals and returns with GetMessageByRef()
        //Note: You'll need to modify ShootingStar.GetMessageByRef() along with LocalReferencesKata.SetMessage(string message)
        public void SetMessage(string message)
        {
            _shootingStar.SetMessage(message);
        }

        private ShootingStar _shootingStar;

        public LocalReferencesKata()
        {
            _shootingStar = new ShootingStar();
        }

        public ShootingStar GetShootingStar()
        {
            return _shootingStar;
        }
    }

    public class ShootingStar
    {
        private string _message;

        public string GetMessageByRef()
        {
            return _message;
        }

        public void SetMessage(string message)
        {
            _message = message;
        }
        
        public override string ToString()
        {
            return _message;
        }
    }
}
