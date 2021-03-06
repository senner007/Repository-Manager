﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager.Models 
{  
    public abstract class Person : IPerson, IComparable
    {
     //   [System.ComponentModel.DisplayName("Key")]
        public string TLF { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public uint Age { get; set; }
        public virtual string Status { get; set; }

        public int CompareTo(object obj)
        {
            Person p = obj as Person;
            if(p !=null)
            {
                int result;
                result = string.Compare(LastName, p.LastName, MyComparer.ENG, MyComparer.COMPOPTIONS); // hvis EFTERnavn
                if (result != 0) return result;
                result = string.Compare(FirstName,p.FirstName, MyComparer.ENG, MyComparer.COMPOPTIONS); // hvis FORnavn
                if (result != 0) return result;

                return TLF.CompareTo(p.TLF); // hvis TLF
            }


            return -1;
        }

        public override string ToString()
        {
            return FirstName + " " + LastName + ", Alder: " +  Age + ", Tlf: " + TLF;
        }
    }

    public class Employed : Person 
    {
       
        public override string Status { get; set; } = "Employed";
        public uint Salary { get; set; }
        public string Company { get; set; }
        public override string ToString()
        {
            return base.ToString() + ", " + Status;
        }
    }
    public class Student : Person
    {
        public string Major{ get; set; }
        public override string Status { get; set; } = "Student";
        public override string ToString()
        {
            return base.ToString() + ", " + Status;
        }
    }
    public class Merged : Person // Merged : Student og Employed som ét object
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
