using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Manager.Presenter
{
    public class Determine
    {
        public bool IfTLF(string input) => UInt32.TryParse(input, out UInt32 parsed) && parsed.ToString().Length == 8 ? true : false;

        public bool IfUint(string input) => UInt32.TryParse(input, out UInt32 parsed)  ? true : false;

        public bool IfName(string input) => Regex.IsMatch(input, @"^[a-zA-Z]+$") && input.Length > 1 && input.Length < 50 ? true : false;

        public bool IfAge(string input) => UInt32.TryParse(input, out UInt32 parsed) && parsed > 15 && parsed < 100 ? true : false;

        public bool IfMisc(string input) => input.Length > 3 ? true : false;

        public bool IfDec(string input) => Decimal.TryParse(input, out decimal parsed) ? true : false;

        public bool IfCPR(string input) => Int64.TryParse(input, out Int64 parsed) && parsed.ToString().Length == 10 ? true : false;

        public bool IfAddress(string input) => Regex.IsMatch(input, @"^([a-zA-Z]).+\s(?=.*[0-9]).*$") == true ? true : false; 
        // TODO: forbedre adressekode - tilføj adresse

        public bool ValidateNewStudent(string tlf, string firstname, string lastname, string age, string major)
        {
            return (IfTLF(tlf) && IfName(firstname) && IfName(lastname) && IfAge(age) && IfMisc(major) == true) ? true : false;
        }
        public bool ValidateNewEmployed(string tlf, string firstname, string lastname, string age, string company, string salary)
        {
            return (IfTLF(tlf) && IfName(firstname) && IfName(lastname) && IfAge(age) && IfMisc(company) && IfUint(salary) == true) ? true : false;
        }
    }
}
