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
        public static void AddSortedDict(this OrderedDictionary dict, uint tlf, IPerson item)
        {
            Comparer<IPerson> comparer = Comparer<IPerson>.Default;

            int i = 0; 
            while (i < dict.Count && comparer.Compare(dict.Values.OfType<IPerson>().ToList()[i], item) < 0)
                i++;

            dict.Insert(i, tlf, item);
        }

    }
    
}
