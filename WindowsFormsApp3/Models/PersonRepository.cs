using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Manager.Models
{
    public class PersonRepository
    {
        protected static readonly List<IPerson> _people;

        public List<IPerson> GetPeople { get => _people; }

        static PersonRepository() // static constructor
        {
            Console.WriteLine("People static contructor"); 
            _people = new List<IPerson>()
            {
              new Employed() { TLF = 11111111, FirstName = "Poul", LastName = "Irish", Age  = 40 , Company= "Google", Salary = 10000},
              new Employed() { TLF = 22222222, FirstName = "Bill", LastName = "Gates", Age = 70, Company = "Microsoft", Salary = 5000000},
              new Employed() { TLF = 33333333, FirstName = "Jeremy", LastName = "McPeak", Age = 40, Company = "Envato", Salary = 3500},
              new Employed() { TLF = 44444444, FirstName = "Douglas", LastName = "Crockford", Age = 70, Company = "Yahoo", Salary = 35000},
              new Student() { TLF = 55555555, FirstName = "Thomas", LastName = "Anderson", Age = 20, Major = "Computer Science 101"},
              new Student() { TLF = 66666666, FirstName = "John", LastName = "Doe", Age = 30, Major = "Computer Science 201"},
              new Student() { TLF = 77777777, FirstName = "Jane", LastName = "Doe", Age = 25, Major = "Programming"}
            };
        }

        public bool UpdatePerson(IPerson personCopy, string propertyName, string value) // IPerson parameter er value kopi fra Datagridview
        {
            IPerson _person = _people.FirstOrDefault(p => p.TLF == personCopy.TLF); // Find matching person in db
            Console.WriteLine(propertyName);
            Console.WriteLine(value);
            if (_person != null)
            {   
                if (propertyName == "TLF" || propertyName == "Age")
                {
                    Console.WriteLine("Hello number");
                    _person.GetType().GetProperty(propertyName).SetValue(_person, Convert.ToUInt32(value), null);

                } else if (propertyName == "FirstName" || propertyName == "LastName")
                {
                    Console.WriteLine("Hello string");
                    _person.GetType().GetProperty(propertyName).SetValue(_person, value, null);
                }               
            }
            return true;

        }
        public List<T> GetByType<T>(Func<IPerson, T> lambda) where T : IPerson
        {
            return _people.Select(lambda).Where(p => p != null).ToList();

        }
        internal List<Merged> MergeTypes()
        {
            IEnumerable<Merged> mStudents = GetByType(o => o as Student).Select(s => new Merged // TODO : forbedre/simplificer
            {
                TLF = s.TLF,
                FirstName = s.FirstName,
                LastName = s.LastName,
                Age = s.Age,
                Type = s.Type,
                Major = s.Major,
                Company = null,
                Salary = 0
            });

            IEnumerable<Merged> mEmployed = GetByType(o => o as Employed).Select(w => new Merged
            {
                TLF = w.TLF,
                FirstName = w.FirstName,
                LastName = w.LastName,
                Age = w.Age,
                Type = w.Type,
                Major = null,
                Company = w.Company,
                Salary = w.Salary
            });

            return mEmployed.Union(mStudents).ToList();
        }

        internal bool DeletePerson(IPerson person)
        {
            IPerson _person = _people.FirstOrDefault(p => p.TLF == person.TLF); // Find matching person in db

            if (_person != null)
            {
                _people.Remove(_person);
                return true;
            }
            return false;
        }

        public bool CreateStudent (uint tlf, string firstname, string lastname, uint age, string major)
        {
            if (TlfExists(tlf)) return false;
            _people.Add(new Student() { TLF = tlf, FirstName = firstname, LastName = lastname, Age = age, Major = major });
            Console.WriteLine("Hello from student create model");
            return true;
            
        }
        public bool CreateEmployed(uint tlf, string firstname, string lastname, uint age, string company, uint salary)
        {
            if (TlfExists(tlf)) return false;
            _people.Add(new Employed() { TLF = tlf, FirstName = firstname, LastName = lastname, Age = age, Company = company, Salary = salary });
            return true;
        }
        private bool TlfExists(uint tlf) => _people.FirstOrDefault(t => t.TLF == tlf) != null;


    }
}
