using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Manager.Models
{
    public static class BigListTest
    {
        //  testing large numbers
        private static Random random = new Random();
        static  BigListTest()
        {
           
        }
        static string RandomString(int length)
        {

            const string chars = "abcdefghijklmnopqrstuvwxyz";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
        public static List<IPerson> GetBigList() // TODO : tilføj parametre/options
        {
            uint largeNumber = 500000;
            List<IPerson> _people = new List<IPerson>();
            List<string> ln = new List<string>();
            string saved = RandomString(12);
            int counter = 5;
            for (int i = 0; i < largeNumber; i++)
            {
                counter--;
                if (counter == 0)
                {
                    saved = RandomString(12);
                    ln.Add(saved);
                }
                else
                {
                    ln.Add(saved);
                }
                if (counter == 0) counter = 5;

            }
            List<string> fn = new List<string>();
            for (int i = 0; i < largeNumber; i++)
            {
                fn.Add(RandomString(7));
            }

            for (int i = 0; i < largeNumber; i++)
            {

                _people.Add(new Employed() { TLF = Convert.ToUInt32(10000000 + i * 111), FirstName = fn[i], LastName = ln[i], Age = 40, Company = "Google", Salary = 10000 });

            }
            return _people = _people.OrderBy(p => p.LastName).ThenBy(p => p.FirstName).ToList();
        }
       
    }
}
