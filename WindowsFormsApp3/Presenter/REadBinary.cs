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
            //  Console.WriteLine(list[0]);
            val = val.ToLower(culture);
            
            var listCount = list.Count();
       
            int index = BinaryCompareStrings(list, val, 0, listCount);

            List<T> newList = new List<T>();
            bool condition = true;
            if (index == -1) return newList;
            Console.WriteLine(index);
            while (condition && index < listCount)
            {
              //  Console.WriteLine(list[index].LastName);
             //   Console.WriteLine(val.Length);
                int length = val.Length;
                T item = list[index];
                if (val.Length > item.LastName.Length)
                {
                    length = item.LastName.Length;
                }

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


            int BinaryCompareStrings<T>(List<T> a, string mystring, int left, int right) where T : IPerson
            {
                if (left == right)
                {
                    // Console.WriteLine(a[left].LastName.StartsWith(mystring));
                    //   Console.WriteLine(a[left].LastName);
                    return left >= 0 && left < a.Count && a[left].LastName.ToLower(culture).StartsWith(mystring) ? left : -1;
                }
                int mid = (right + left) / 2;

                int mylength = mystring.Length;
                if (mylength > a[mid].LastName.Length)
                {
                    mylength = a[mid].LastName.Length;

                }
                return (string.Compare(mystring, a[mid].LastName.ToLower(culture).Substring(0, mylength)) == 1) ? BinaryCompareStrings(a, mystring, mid + 1, right) : BinaryCompareStrings(a, mystring, left, mid);
            }
        }
        

    }
}
