using System;
using System.Text.RegularExpressions;

namespace Telephony
{
    public class Smartphone : StationaryPhone, IBrowsable
    {
        private Regex siteRegex;
        
        public Smartphone(string URLOrPhoneNumber) : base(URLOrPhoneNumber)
        {
            this.siteRegex = new Regex(@"^[^\s\d]+$");
        }

        public bool IsLegitSite { get => siteRegex.IsMatch(this.URLOrPhoneNumber); }

        public override void Call() => Console.WriteLine($"Calling... {this.URLOrPhoneNumber}");
        public void Browse() => Console.WriteLine($"Browsing: {this.URLOrPhoneNumber}!");
    }
}
