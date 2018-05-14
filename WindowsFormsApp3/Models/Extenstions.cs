using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager.Models
{
    public static class Extentions
    {
        // extenstion metode der indsætter objekted på den rigtige plads i stedet for at sortere hele listen
        //(O(n)) 
        public static void AddSortedDict<T>(this OrderedDictionary dict, uint tlf, T item) where T : IPerson
        {
            Comparer<IPerson> comparer = Comparer<IPerson>.Default;
            IEnumerable<IPerson> coll = dict.Values.OfType<IPerson>();

            int i = 0;

            while (i < dict.Count && comparer.Compare(coll.ToList()[i], item) < 0)
                i++;

            dict.Insert(i, tlf, item);
        }

    }
    
}
