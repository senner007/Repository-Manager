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
        public readonly static List<IPerson> _people = new List<IPerson>();

        public static List<Merged> mergeCache;

        static PersonRepository() // static constructor
        {
            Console.WriteLine("People static contructor");

            //string[] ln = { "Crockford", "Doe", "Gates", "Irish", "Jameson", "Landon", "Madsen", "Poulson", "Robertson", "Williamson" };
            //string[] fn = { "Thomas", "Joe", "Tanner", "Ben", "Johny", "Wilma", "Adam", "Fred", "Finn", "John" };

            //for (uint i = 0; i < 500000; i++)
            //{

            //    _people.Add(new Employed() { TLF = 10000000 + i, FirstName = fn[i / 50000], LastName = ln[i / 50000], Age = 40, Company = "Google", Salary = 10000});

            //}
            //_people = _people.OrderBy(p => p.LastName).ThenBy(p => p.FirstName).ToList();


            
            _people = new List<IPerson>()
            {
              new Employed() { TLF = 11111111, FirstName = "Poul", LastName = "Irish", Age  = 40 , Company= "Google", Salary = 10000},
              new Employed() { TLF = 22222222, FirstName = "Bill", LastName = "Gates", Age = 70, Company = "Microsoft", Salary = 5000000},
              new Employed() { TLF = 33333333, FirstName = "Jeremy", LastName = "McPeak", Age = 40, Company = "Envato", Salary = 3500},
              new Employed() { TLF = 44444444, FirstName = "Douglas", LastName = "Crockford", Age = 70, Company = "Yahoo", Salary = 35000},
              new Student() { TLF = 55555555, FirstName = "Thomas", LastName = "Anderson", Age = 20, Major = "Computer Science 101"},
              new Student() { TLF = 66666666, FirstName = "John", LastName = "Doe", Age = 30, Major = "Computer Science 201"},
              new Student() { TLF = 77777777, FirstName = "Jane", LastName = "Doe", Age = 25, Major = "Programming"}
            }.OrderBy(p => p.LastName).ThenBy(p => p.FirstName).ToList();

            //for (uint i = 0; i < 100000; i++)
            //{
            //    {
            //        _people.Add(new Employed() { TLF = 10000000 + i * 173, FirstName = "Poul", LastName = "Anderson", Age = 40, Company = "Google", Salary = 10000 });
            //    }
            //}
            PersonRepository pr = new PersonRepository();
                mergeCache = pr.MergeTypes().OrderBy(p => p.LastName).ThenBy(p => p.FirstName).ToList();
        }

        public void ReOrder()
        {
            _people.OrderBy(p => p.LastName).ThenBy(p => p.FirstName);
            mergeCache = null;
        }
        public bool UpdatePerson(IPerson personCopy, string propertyName, string value) // IPerson parameter er value kopi fra Datagridview
        {
            IPerson _person = _people.FirstOrDefault(p => p.TLF == personCopy.TLF); // Find matching person in db                                                                                   
            PropertyInfo propInfo = _person.GetType().GetProperty(propertyName);

            if (propInfo == null || propertyName == "TLF" && TlfExists(Convert.ToUInt32(value))) return false;

                propInfo.SetValue(_person, Convert.ChangeType(value, propInfo.PropertyType), null);
                ReOrder();
                return true;
   
        }
        public IEnumerable<T> GetByType<T>(Func<IPerson, T> lambda) where T : IPerson
        {
            return _people.Select(lambda).Where(p => p != null);

        }
        public IEnumerable<Merged> MergeTypes() // TODO : langsommere - cache ? 
        {
            if (mergeCache != null) return mergeCache;
            Console.WriteLine("from merged");
            IEnumerable<Merged> mStudents = GetByType(o => o as Student).Select(s => new Merged // TODO : forbedre/simplificer
            {
                TLF = s.TLF,
                FirstName = s.FirstName,
                LastName = s.LastName,
                Age = s.Age,
                Status = s.Status,
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
                Status = w.Status,
                Major = null,
                Company = w.Company,
                Salary = w.Salary
            });
            mergeCache = mEmployed.Concat(mStudents).OrderBy(m => m.LastName).ThenBy(m => m.FirstName).ToList();
            return mEmployed.Concat(mStudents); // Concat bedre for performance
            // return mEmployed.Union(mStudents); //Union ikke nødvendig da alle gerne skulle være unikke
        }

        internal bool DeletePerson(IPerson person)
        {
            IPerson _person = _people.FirstOrDefault(p => p.TLF == person.TLF); // Find matching person in db

            if (_person != null)
            {
                _people.Remove(_person);
                ReOrder();
                return true;
            }
            return false;
        }

        public bool CreateStudent (uint tlf, string firstname, string lastname, uint age, string major)
        {
            if (TlfExists(tlf)) return false;
           
            _people.Add(new Student() { TLF = tlf, FirstName = firstname, LastName = lastname, Age = age, Major = major });
            Console.WriteLine("Hello from student create model");
            ReOrder();
            return true;
            
        }
        public bool CreateEmployed(uint tlf, string firstname, string lastname, uint age, string company, uint salary)
        {
            if (TlfExists(tlf)) return false;
            _people.Add(new Employed() { TLF = tlf, FirstName = firstname, LastName = lastname, Age = age, Company = company, Salary = salary });
            ReOrder();
            return true;
        }
        private bool TlfExists(uint tlf) => _people.FirstOrDefault(t => t.TLF == tlf) != null;
    }
}
