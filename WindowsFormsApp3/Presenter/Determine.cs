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
        public bool IfTLF(string input) => Regex.IsMatch(input, @"^\d{8}$");

        public bool IfUint(string input) => UInt32.TryParse(input, out UInt32 parsed)  ? true : false;

        public bool IfName(string input) => Regex.IsMatch(input, @"^[a-zA-Z]+$") && input.Length > 1 && input.Length < 50 ? true : false;

        public bool IfAge(string input) => UInt32.TryParse(input, out UInt32 parsed) && parsed > 15 && parsed < 100 ? true : false;

        public bool IfMisc(string input) => input.Length > 3 ? true : false;

        public bool IfDec(string input) => Decimal.TryParse(input, out decimal parsed) ? true : false;

        public bool IfCPR(string input) => Int64.TryParse(input, out Int64 parsed) && parsed.ToString().Length == 10 ? true : false;

        public bool IfAddress(string input) => Regex.IsMatch(input, @"^([a-zA-Z]).+\s(?=.*[0-9]).*$") == true ? true : false;
        // TODO: forbedre adressekode - tilføj adresse
        public string FirstNameFail => "Indtast et FORnavn (bogstaver)";
        public string LastNameFail => "Indtast et EFTERnavn (bogstaver)";
        public string CompanyNameFail => "Indtast et firmanavn";
        public string MajorNameFail => "Indtast et fag";
        public string AgeFail => "Indtast alder (tal 16-99)";
        public string TlfFail => "Indtast telefonnummer (8 tal)";
        public string NumberFail => "Indtast (tal)";

        public bool ValidateNewStudent(string tlf, string firstname, string lastname, string age, string major)
        {
            return (IfTLF(tlf) && IfName(firstname) && IfName(lastname) && IfAge(age) && IfMisc(major) == true) ? true : false;
        }
        public bool ValidateNewEmployed(string tlf, string firstname, string lastname, string age, string company, string salary)
        {
            return (IfTLF(tlf) && IfName(firstname) && IfName(lastname) && IfAge(age) && IfMisc(company) && IfUint(salary) == true) ? true : false;
        }
        public bool ValidateUpdate(string prop , string input)
        { 
            if ((prop == "FirstName" || prop == "LastName") && IfName(input)) return true;
            if (prop == "Age" && IfAge(input)) return true;
            if (prop == "TLF" && IfTLF(input)) return true;
            if (prop == "Salary" && IfUint(input)) return true;
            if (prop == "Company") return true;
            if (prop == "Major") return true;
            return false;
            // Status kan ikke ændres
        }
      

    }


    
    

}
