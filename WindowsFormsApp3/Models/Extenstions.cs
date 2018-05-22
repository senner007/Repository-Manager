using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager.Models
{
    public static class Extentions
    {
        // extenstion metode der indsætter objekted på den rigtige plads i stedet for at sortere hele listen
        //(O(n)) 
        public static void AddSortedDict(this OrderedDictionary dict, string tlf, IPerson item)
        {
            Comparer<IPerson> comparer = Comparer<IPerson>.Default;
            var list = PersonRepository.GetPeople;

            int i = 0; 
            while (i < dict.Count && comparer.Compare(list[i], item) < 0)
                    i++;
      
            dict.Insert(i, tlf, item);
            PersonRepository.GetPeople = new PersonRepository().GetDict.Values.OfType<IPerson>().ToList();
        }

    }
    
}
