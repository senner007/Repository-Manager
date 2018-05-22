using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager.Models
{
    static class MyComparer
    {
        static MyComparer()  => ENG = new CultureInfo("en-US");
        public static readonly CultureInfo ENG; 
        public const CompareOptions COMPOPTIONS = CompareOptions.IgnoreCase;
        public const StringComparison STRINGCOMP = StringComparison.InvariantCultureIgnoreCase;
    }
}
