using Manager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager.Presenter
{
    public static class ReadTlfBinary
    {
        // 1. find laveste index af Person.tlf der opfylder filtreringskriterie.
        // 2. loop over listen fra dette index og returnerer alle der opfylder samme kriterie.
        // TODO : kan optimeres yderligere ? 
        public static List<T> GetListWithBinary<T>(List<T> list, uint val) where T : IPerson
        {
            var listCount = list.Count();
            int index = BinSearch(list, val, 0, listCount);
            List<T> newList = new List<T>();
            bool condition = true;
            var valToString = val.ToString();
            while (condition && index != -1 && index < listCount)
            {
                if (list[index].TLF.ToString().Substring(0, val.ToString().Length) == valToString)
                {
                    newList.Add(list[index]);
                    index++;
                }
                else
                {
                    condition = false;
                }
            }
            return newList;
  
        }
        private static int BinSearch<T>(List<T> a, uint num, int left, int right) where T : IPerson
        {
            if (left == right)
            {
                return left >= 0 && left < a.Count && a[left].TLF.ToString().Substring(0, num.ToString().Length) == num.ToString() ? left : -1;
            }
            int mid = (right + left) / 2;
            return (num > Convert.ToUInt32(a[mid].TLF.ToString().Substring(0, num.ToString().Length))) ? BinSearch(a, num, mid + 1, right) : BinSearch(a, num, left, mid);
        }

    }
}
