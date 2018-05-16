using System;
using System.Collections.Generic;
using System.Collections.Specialized;
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
        public static OrderedDictionary GetBigList(uint size, int forevery) // TODO : tilføj parametre/options
        {
            uint largeNumber = size;
            List<IPerson> _people = new List<IPerson>();
            List<string> ln = new List<string>();
            string saved = RandomString(12);
            int counter = forevery;
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
                if (counter == 0) counter = forevery;

            }
            List<string> fn = new List<string>();
            for (int i = 0; i < largeNumber; i++)
            {
                fn.Add(RandomString(7));
            }
            var _temp = new OrderedDictionary();
            for (int i = 0; i < largeNumber; i++)
            {

                _people.Add(new Employed() { TLF = (10000000 + i * 111).ToString(), FirstName = fn[i], LastName = ln[i], Age = 40, Company = "Google", Salary = 10000 });

            }
            _people = _people.OrderBy(p => p.LastName).ThenBy(p => p.FirstName).ToList();

            _people.ForEach(o => { _temp.Add(o.TLF, o); });
            return _temp;
        }
       
    }
}
