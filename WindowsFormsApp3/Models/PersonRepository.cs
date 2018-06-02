using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Reflection;
using System.Collections;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Manager.Models
{

    public class PersonRepository
    {

        private static OrderedDictionary myOrderedDictionary;

        public static List<IPerson> GetPeople { get; private set; } = null;// TODO : skal være static ?

        public OrderedDictionary GetDict => myOrderedDictionary;

        static PersonRepository() // static constructor
        {
            Console.WriteLine("People static contructor");

            myOrderedDictionary = new OrderedDictionary();

            AddSortedDict("11111111", new Employed() { TLF = "11111111", FirstName = "Poul", LastName = "Irish", Age = 40, Company = "Google", Salary = 10000 });
            AddSortedDict("22222222", new Employed() { TLF = "22222222", FirstName = "Poul", LastName = "Anderson", Age = 40, Company = "Google", Salary = 10000 });
            AddSortedDict("33333333", new Employed() { TLF = "33333333", FirstName = "Poul", LastName = "Adams", Age = 40, Company = "Google", Salary = 10000 });
            AddSortedDict("44444444", new Employed() { TLF = "44444444", FirstName = "Bill", LastName = "Gates", Age = 70, Company = "Microsoft", Salary = 5000000 });
            AddSortedDict("55555555", new Employed() { TLF = "55555555", FirstName = "Jeremy", LastName = "McPeak", Age = 40, Company = "Envato", Salary = 3500 });
            AddSortedDict("66666666", new Employed() { TLF = "66666666", FirstName = "Douglas", LastName = "Crockford", Age = 70, Company = "Yahoo", Salary = 35000 });
            AddSortedDict("77777777", new Student() { TLF = "77777777", FirstName = "Thomas", LastName = "Anderson", Age = 20, Major = "Computer Science 101" });
            AddSortedDict("88888888", new Student() { TLF = "88888888", FirstName = "John", LastName = "Doe", Age = 30, Major = "Computer Science 201" });
            AddSortedDict("99999999", new Student() { TLF = "99999999", FirstName = "Jane", LastName = "Doe", Age = 25, Major = "Programming" });

            //myOrderedDictionary = BigListTest.GetBigList(500000, 200);
            //GetPeople = myOrderedDictionary.Values.OfType<IPerson>().ToList();

        }

        public bool UpdatePerson(dynamic clone, string propertyName, string value) // IPerson parameter er value kopi fra Datagridview
        {
            IPerson _person = myOrderedDictionary[clone.TLF]; // Find matching person in db                                                                                   
            PropertyInfo propInfo = clone.GetType().GetProperty(propertyName);

            if (propInfo == null || propertyName == "TLF" && TlfExists(value)) return false;

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
        public List<IPerson> GetByType<T>(Func<IPerson, T> lambda) where T : IPerson
        {
           // IEnumerable<T> valueCollection = myOrderedDictionary.Values.OfType<T>();
            // return GetPeople.Select(lambda).Where(p => p != null); // bruges til at indætte i liste
           return GetPeople;


        }
        public IEnumerable<Merged> MergeTypes<T>(IEnumerable<T> list) // TODO : langsommere - cache ? 
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
            Console.WriteLine("deleting person:!");
           
            Stopwatch sw = Stopwatch.StartNew();
            var index = GetPeople.BinarySearch(person, Comparer<IPerson>.Default);
            myOrderedDictionary.RemoveAt(index);
            GetPeople.RemoveAt(index);
            sw.Stop();
            Console.WriteLine(sw.Elapsed);

            return true;
        }

        public bool CreateStudent(string tlf, string firstname, string lastname, uint age, string major)
        {
            if (TlfExists(tlf)) return false;

            //  _people.AddSorted(new Student() { TLF = tlf, FirstName = firstname, LastName = lastname, Age = age, Major = major });
            AddSortedDict(tlf, new Student() { TLF = tlf, FirstName = firstname, LastName = lastname, Age = age, Major = major });
            return true;

        }
        public bool CreateEmployed(string tlf, string firstname, string lastname, uint age, string company, uint salary)
        {
            if (TlfExists(tlf)) return false;
            // _people.AddSorted(new Employed() { TLF = tlf, FirstName = firstname, LastName = lastname, Age = age, Company = company, Salary = salary });
           AddSortedDict(tlf, new Employed() { TLF = tlf, FirstName = firstname, LastName = lastname, Age = age, Company = company, Salary = salary });
            return true;
        }
        private bool TlfExists(string tlf) => myOrderedDictionary[tlf] != null;

        private static void AddSortedDict(string tlf, IPerson person) 
        {
            Comparer<IPerson> comparer = Comparer<IPerson>.Default;
            int i = 0; 

            if (GetPeople != null )
            {
                i = ~GetPeople.BinarySearch(person, comparer);

            } else
            {
                while (i < myOrderedDictionary.Count && comparer.Compare(GetPeople[i], person) < 0) i++;
                
            }
            Console.WriteLine("inserting");
            Stopwatch sw = Stopwatch.StartNew();
            myOrderedDictionary.Insert(i, tlf, person);
            sw.Stop();
            Console.WriteLine(sw.Elapsed);
            GetPeople = myOrderedDictionary.Values.OfType<IPerson>().ToList();
           
        }
    }
}