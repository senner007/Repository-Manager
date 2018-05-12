using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Manager.Models
{
    public static class Extentions
    {
        // extenstion metode der indsætter objekted på den rigtige plads i stedet for at sortere hele listen
        //(O(n)) TODO: kan forbedres med binær ?
        public static void AddSorted<T>(this IList<T> list, T item, IComparer<T> comparer = null)
        {
            if (comparer == null)
                comparer = Comparer<T>.Default;

            int i = 0;
            while (i < list.Count && comparer.Compare(list[i], item) < 0)
                i++;

            list.Insert(i, item);
        }
    }
    public class PersonRepository
    {

        
        private readonly static List<IPerson> _people;

        public List<IPerson> GetPeople { get => _people; }

        // public static List<Merged> mergeCache;
        private static Random random = new Random();
        public static string RandomString(int length)
        {
          
            const string chars = "abcdefghijklmnopqrstuvwxyz";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        static PersonRepository() // static constructor
        {

            //Console.WriteLine("People static contructor");

            // testing large numbers

            //uint largeNumber = 500000;
            //_people = new List<IPerson>();
            //List<string> ln = new List<string>();
            //string saved = RandomString(12);
            //int counter = 5;
            //for (int i = 0; i < largeNumber; i++)
            //{
            //    counter--;
            //    if (counter == 0)
            //    {
            //        saved = RandomString(12);
            //        ln.Add(saved);
            //    }
            //    else
            //    {
            //        ln.Add(saved);
            //    }
            //    if (counter == 0) counter = 5;

            //}
            //List<string> fn = new List<string>();
            //for (int i = 0; i < largeNumber; i++)
            //{
            //    fn.Add(RandomString(7));
            //}

            //for (int i = 0; i < largeNumber; i++)
            //{

            //    _people.Add(new Employed() { TLF = Convert.ToUInt32(10000000 + i * 111), FirstName = fn[i], LastName = ln[i], Age = 40, Company = "Google", Salary = 10000 });

            //}
            //_people = _people.OrderBy(p => p.LastName).ThenBy(p => p.FirstName).ToList();


            _people = new List<IPerson>();

            _people.AddSorted(new Employed() { TLF = 11111111, FirstName = "Poul", LastName = "Irish", Age = 40, Company = "Google", Salary = 10000 });
            _people.AddSorted(new Employed() { TLF = 22222222, FirstName = "Poul", LastName = "Anderson", Age = 40, Company = "Google", Salary = 10000 });
            _people.AddSorted(new Employed() { TLF = 33333333, FirstName = "Poul", LastName = "Adams", Age = 40, Company = "Google", Salary = 10000 });
            _people.AddSorted(new Employed() { TLF = 44444444, FirstName = "Bill", LastName = "Gates", Age = 70, Company = "Microsoft", Salary = 5000000 });
            _people.AddSorted(new Employed() { TLF = 55555555, FirstName = "Jeremy", LastName = "McPeak", Age = 40, Company = "Envato", Salary = 3500 });
            _people.AddSorted(new Employed() { TLF = 66666666, FirstName = "Douglas", LastName = "Crockford", Age = 70, Company = "Yahoo", Salary = 35000 });
            _people.AddSorted(new Student() { TLF = 77777777, FirstName = "Thomas", LastName = "Anderson", Age = 20, Major = "Computer Science 101" });
            _people.AddSorted(new Student() { TLF = 88888888, FirstName = "John", LastName = "Doe", Age = 30, Major = "Computer Science 201" });
            _people.AddSorted(new Student() { TLF = 99999999, FirstName = "Jane", LastName = "Doe", Age = 25, Major = "Programming" });

            // TODO : implementer ObservableCollection

        }

        public bool UpdatePerson(dynamic clone, string propertyName, string value) // IPerson parameter er value kopi fra Datagridview
        {
            IPerson _person = _people.FirstOrDefault(p => p.TLF == clone.TLF); // Find matching person in db                                                                                   
            PropertyInfo propInfo = clone.GetType().GetProperty(propertyName);

            if (propInfo == null || propertyName == "TLF" && TlfExists(Convert.ToUInt32(value))) return false;

            propInfo.SetValue(clone, Convert.ChangeType(value, propInfo.PropertyType), null);
            //if (TlfExists(clone.TLF)) return false;
            if (_person is Employed)
            {
                //Objektet skal slettes først. 
                //Ellers vil den ikke indsætte, da sortedSet ikke tillader ens objekter baseret på compare
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
            return _people.Select(lambda).Where(p => p != null);

        }
        public IEnumerable<Merged> MergeTypes() // TODO : langsommere - cache ? 
        {
 
            return _people.Select(p  =>
            {
                if (p is Student)
                {
                    Student s = p as Student;
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
           
            _people.AddSorted(new Student() { TLF = tlf, FirstName = firstname, LastName = lastname, Age = age, Major = major });
            Console.WriteLine("from student create model");
            return true;
            
        }
        public bool CreateEmployed(uint tlf, string firstname, string lastname, uint age, string company, uint salary)
        {
            if (TlfExists(tlf)) return false;
            _people.AddSorted(new Employed() { TLF = tlf, FirstName = firstname, LastName = lastname, Age = age, Company = company, Salary = salary });
            return true;
        }
        private bool TlfExists(uint tlf) => _people.FirstOrDefault(t => t.TLF == tlf) != null;
    }
}
