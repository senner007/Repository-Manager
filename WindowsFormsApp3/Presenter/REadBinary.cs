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
            val = val.ToLower(culture);
            int valLength = val.Length;
            
            var listCount = list.Count();
       
            int index = BinaryCompareStrings(list, 0, listCount);

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

            int BinaryCompareStrings<T>(List<T> a,int left, int right) where T : IPerson
            {
                if (left == right)
                {
                    return left >= 0 && left < a.Count && a[left].LastName.ToLower(culture).StartsWith(val) ? left : -1;
                }
                int mid = (right + left) / 2;

                int mylength = valLength > a[mid].LastName.Length ? a[mid].LastName.Length : valLength;

                return (string.Compare(val, a[mid].LastName.ToLower(culture).Substring(0, mylength)) == 1) ? BinaryCompareStrings(a, mid + 1, right) : BinaryCompareStrings(a, left, mid);
            }
        }
    }
}
