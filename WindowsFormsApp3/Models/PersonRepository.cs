using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Reflection;
using System.Collections;
using System.Text;
using System.Threading.Tasks;

namespace Manager.Models
{

    public class PersonRepository
    {

        private readonly static OrderedDictionary myOrderedDictionary;

        public IEnumerable<IPerson> GetPeople => myOrderedDictionary.Values.OfType<IPerson>();
        public OrderedDictionary GetDict => myOrderedDictionary;

        static PersonRepository() // static constructor
        {
            Console.WriteLine("People static contructor");

         
            OrderedDictionary _temp = new OrderedDictionary();

            _temp.AddSortedDict(11111111, new Employed() { TLF = 11111111, FirstName = "Poul", LastName = "Irish", Age = 40, Company = "Google", Salary = 10000 });
            _temp.AddSortedDict(22222222, new Employed() { TLF = 22222222, FirstName = "Poul", LastName = "Anderson", Age = 40, Company = "Google", Salary = 10000 });
            _temp.AddSortedDict(33333333, new Employed() { TLF = 33333333, FirstName = "Poul", LastName = "Adams", Age = 40, Company = "Google", Salary = 10000 });
            _temp.AddSortedDict(44444444, new Employed() { TLF = 44444444, FirstName = "Bill", LastName = "Gates", Age = 70, Company = "Microsoft", Salary = 5000000 });
            _temp.AddSortedDict(55555555, new Employed() { TLF = 55555555, FirstName = "Jeremy", LastName = "McPeak", Age = 40, Company = "Envato", Salary = 3500 });
            _temp.AddSortedDict(66666666, new Employed() { TLF = 66666666, FirstName = "Douglas", LastName = "Crockford", Age = 70, Company = "Yahoo", Salary = 35000 });
            _temp.AddSortedDict(77777777, new Student() { TLF = 77777777, FirstName = "Thomas", LastName = "Anderson", Age = 20, Major = "Computer Science 101" });
            _temp.AddSortedDict(88888888, new Student() { TLF = 88888888, FirstName = "John", LastName = "Doe", Age = 30, Major = "Computer Science 201" });
            _temp.AddSortedDict(99999999, new Student() { TLF = 99999999, FirstName = "Jane", LastName = "Doe", Age = 25, Major = "Programming" });

            myOrderedDictionary = _temp;

            // myOrderedDictionary = BigListTest.GetBigList(500000, 200);


        }

        public bool UpdatePerson(dynamic clone, string propertyName, string value) // IPerson parameter er value kopi fra Datagridview
        {
            IPerson _person = myOrderedDictionary[clone.TLF]; // Find matching person in db                                                                                   
            PropertyInfo propInfo = clone.GetType().GetProperty(propertyName);

            if (propInfo == null || propertyName == "TLF" && TlfExists(Convert.ToUInt32(value))) return false;

            propInfo.SetValue(clone, Convert.ChangeType(value, propInfo.PropertyType), null);
            //if (TlfExists(clone.TLF)) return false;
            if (_person is Employed)
            {
                //Objektet slettes først og derpå oprettes på ny.
                // På den måde kan vi genbruge metoder som bruger addSorted, hvor listen ikke behøver sortering.
                DeletePerson(_person);
                CreateEmployed(clone.TLF, clone.FirstName, clone.LastName, clone.Age, clone.Company, clone.Salary);
            }
            else if (_person is Student)
            {
                DeletePerson(_person);
                CreateStudent(clone.TLF, clone.FirstName, clone.LastName, clone.Age, clone.Major);
            }
            return true; // TODO : hvornår/hvoprfor skal der returneres true ?

        }
        public IEnumerable<T> GetByType<T>(Func<IPerson, T> lambda) where T : IPerson
        {
            IEnumerable<T> valueCollection = myOrderedDictionary.Values.OfType<T>();
            // return _people.Select(lambda).Where(p => p != null);
            return valueCollection;


        }
        public IEnumerable<Merged> MergeTypes<T>(List<T> list) // TODO : langsommere - cache ? 
        {

            return list.Select(p =>
            {

                if (p is Student)
                {
                    Student s = p as Student;
                    Console.WriteLine(s.FirstName);
                    return new Merged
                    {
                        TLF = s.TLF,
                        FirstName = s.FirstName,
                        LastName = s.LastName,
                        Age = s.Age,
                        Status = s.Status,
                        Major = s.Major,
                        Company = null,
                        Salary = 0
                    };
                }
                else
                {
                    Employed e = p as Employed;
                    return new Merged
                    {
                        TLF = e.TLF,
                        FirstName = e.FirstName,
                        LastName = e.LastName,
                        Age = e.Age,
                        Status = e.Status,
                        Major = null,
                        Company = e.Company,
                        Salary = e.Salary
                    };
                }
            });

        }

        internal bool DeletePerson(IPerson person)
        {
            myOrderedDictionary.Remove(person.TLF);
            return true;
        }

        public bool CreateStudent(uint tlf, string firstname, string lastname, uint age, string major)
        {
            if (TlfExists(tlf)) return false;

            //  _people.AddSorted(new Student() { TLF = tlf, FirstName = firstname, LastName = lastname, Age = age, Major = major });
            myOrderedDictionary.AddSortedDict(tlf, new Student() { TLF = tlf, FirstName = firstname, LastName = lastname, Age = age, Major = major });
            return true;

        }
        public bool CreateEmployed(uint tlf, string firstname, string lastname, uint age, string company, uint salary)
        {
            if (TlfExists(tlf)) return false;
            // _people.AddSorted(new Employed() { TLF = tlf, FirstName = firstname, LastName = lastname, Age = age, Company = company, Salary = salary });
            myOrderedDictionary.AddSortedDict(tlf, new Employed() { TLF = tlf, FirstName = firstname, LastName = lastname, Age = age, Company = company, Salary = salary });
            return true;
        }
        private bool TlfExists(uint tlf) => myOrderedDictionary[tlf] != null;
    }
}