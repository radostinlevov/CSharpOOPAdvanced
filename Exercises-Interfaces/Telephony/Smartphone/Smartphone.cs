using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Telephony.Smartphones
{
    public class Smartphone : ICollable, IBrowseable
    {
        public string Call(string number)
        {
            bool hasChar = number.Any(c => char.IsLetter(c));

            if (hasChar)
            {
                return "Invalid number!";
            }
            else
            {
                return $"Calling... {number}";
            }
        }

        public string Browse(string site)
        {
            bool hasDigit = site.Any(c => char.IsDigit(c));

            if (hasDigit)
            {
                return "Invalid URL!";
            }
            else
            {
                return $"Browsing: {site}!";
            }
        }
    }
}
