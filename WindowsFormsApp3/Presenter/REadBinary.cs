using Manager.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager.Presenter
{
    public static class ReadBinary
    {
     
        private static CultureInfo culture = CultureInfo.CurrentCulture; // TODO : performance ?
        public static IEnumerable<T> ListBinary<T>(List<T> list, string val) where T : IPerson
        {
            val = val.ToLower(culture); // TODO : bestem i stedet at navne skal starte med et stort bogstav og de mange tolower ?
            int valLength = val.Length;
            
            var listCount = list.Count();
       
            int index = BinaryCompareStrings(0, listCount);

            List<T> newList = new List<T>();
            bool condition = true;
            if (index == -1) return newList;
            while (condition && index < listCount)
            {
                T item = list[index];
                int length = valLength > item.LastName.Length ? item.LastName.Length : valLength;
        
                if (item.LastName.Substring(0, length).ToLower(culture) == val) // TODO : korrekt?
                {
                    newList.Add(item);
                    index++;
                }
                else
                {
                    condition = false;
                }
            }
            return newList;

            int BinaryCompareStrings(int left, int right)
            {
                if (left == right)
                {
                    return left >= 0 && left < listCount && list[left].LastName.ToLower(culture).StartsWith(val) ? left : -1;
                }
                int mid = (right + left) / 2;

                int mylength = valLength > list[mid].LastName.Length ? list[mid].LastName.Length : valLength;

                return (string.Compare(val, list[mid].LastName.ToLower(culture).Substring(0, mylength)) == 1) ? BinaryCompareStrings(mid + 1, right) : BinaryCompareStrings(left, mid);
            }
        }
    }
}
