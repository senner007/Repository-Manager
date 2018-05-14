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
        //(O(n)) TODO: kan forbedres med binær ?
        public static void AddSorted<T>(this IList<T> list, T item)
        {
            Comparer<T> comparer = Comparer<T>.Default;
            int i = 0;
            while (i < list.Count && comparer.Compare(list[i], item) < 0)
                i++;

            list.Insert(i, item);
        }
        public static void AddSortedDict<T>(this OrderedDictionary dict, uint tlf, T item) where T : IPerson
        {
            Comparer<IPerson> comparer = Comparer<IPerson>.Default;
            IEnumerable<IPerson> coll = dict.Values.OfType<IPerson>();

            Console.WriteLine();
            int i = 0;
            Console.WriteLine(dict.Count);
            while (i < dict.Count && comparer.Compare(coll.ToList()[i], item) < 0)
            {
                i++;
                Console.WriteLine(i);
            }

            dict.Insert(i, tlf, item);
        }

    }
    
}
