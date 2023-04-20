using System;
using System.Text.RegularExpressions;

namespace Telephony
{
    public class StationaryPhone : ICallable
    {
        private Regex digitRegex;
      
        public StationaryPhone(string URLOrPhoneNumber)
        {
            this.URLOrPhoneNumber = URLOrPhoneNumber;
            this.digitRegex = new Regex(@"^\d+$");
        }

        public string URLOrPhoneNumber { get; private set; }
        public bool IsLegitPhone { get => digitRegex.IsMatch(URLOrPhoneNumber); }

        public virtual void Call() => Console.WriteLine($"Dialing... {this.URLOrPhoneNumber}");
    }
}
