using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager.Models // TODO : tilføj flere egenskaber
{
    abstract class Person : IPerson
    {
     //   [System.ComponentModel.DisplayName("Key")]
        public uint TLF { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public uint Age { get; set; }
        public virtual string Status { get; set; }

        public override string ToString()
        {
            return FirstName + " " + LastName + ", Alder: " +  Age + ", Tlf: " + TLF;
        }
    }

    class Employed : Person // TODO : Implementer IEmployed interface ?
    {
       
        public override string Status { get; set; } = "Employed";
        public uint Salary { get; set; }
        public string Company { get; set; }
        public override string ToString()
        {
            return base.ToString() + ", " + Status;
        }
    }
    class Student : Person
    {
        public string Major{ get; set; }
        public override string Status { get; set; } = "Student";
        public override string ToString()
        {
            return base.ToString() + ", " + Status;
        }
    }
    class Merged : Person // Merged : Student og Employed som ét object
    {
        public string Major { get; set; }
        public uint Salary { get; set; }
        public string Company { get; set; }
        public override string ToString()
        {
            return base.ToString() + ", " + Status;
        }
    }

}
