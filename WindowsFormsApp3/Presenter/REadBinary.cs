using Manager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager.Presenter
{
    public static class ReadBinary
    {
        // 1. find laveste index af Person.tlf der opfylder filtreringskriterie.
        // 2. loop over listen fra dette index og returnerer alle der opfylder samme kriterie.
        // TODO : kan optimeres yderligere ? 
        //public static List<T> GetListWithBinary<T>(List<T> list, uint val) where T : IPerson
        //{
        //    var listCount = list.Count();
        //    int index = BinSearch(list, val, 0, listCount);
        //    List<T> newList = new List<T>();
        //    bool condition = true;

        //    var valToString = val.ToString();
      
        //    while (condition && index != -1 && index < listCount)
        //    {
        //        if (list[index].TLF.ToString().Substring(0, val.ToString().Length) == valToString)
        //        {
        //            newList.Add(list[index]);
        //            index++;
        //        }
        //        else
        //        {
        //            condition = false;
        //        }
        //    }
        //    return newList;
  
        //}
        //private static int BinSearch<T>(List<T> a, uint num, int left, int right) where T : IPerson
        //{
        //    if (left == right)
        //    {
        //        return left >= 0 && left < a.Count && a[left].TLF.ToString().Substring(0, num.ToString().Length) == num.ToString() ? left : -1;
        //    }
        //    int mid = (right + left) / 2;
        //    return (num > Convert.ToUInt32(a[mid].TLF.ToString().Substring(0, num.ToString().Length))) ? BinSearch(a, num, mid + 1, right) : BinSearch(a, num, left, mid);
        //}


        //-------------------------------------------------------------------------------------------//
        //TODO : optimer

        public static IEnumerable<T> ListBinary<T>(List<T> list, string val) where T : IPerson
        {
          //  Console.WriteLine(list[0]);
            var listCount = list.Count();
       
            int index = BinaryCompareStrings(list, val, 0, listCount);

            List<T> newList = new List<T>();
            bool condition = true;
            if (index == -1) return newList;

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

                if (item.LastName.Substring(0, length) == val) // TODO : korrekt?
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

        }
        private static int BinaryCompareStrings<T>(List<T> a, string mystring, int left, int right) where T : IPerson
        {
            if (left == right)
            {
                // Console.WriteLine(a[left].LastName.StartsWith(mystring));
             //   Console.WriteLine(a[left].LastName);
                return left >= 0 && left < a.Count && a[left].LastName.StartsWith(mystring) ? left : -1;
            }
            int mid = (right + left) / 2;

            int mylength = mystring.Length;
            if (mylength > a[mid].LastName.Length)
            {
                mylength = a[mid].LastName.Length;

            }
            return (string.Compare(mystring, a[mid].LastName.Substring(0, mylength)) == 1) ? BinaryCompareStrings(a, mystring, mid + 1, right) : BinaryCompareStrings(a, mystring, left, mid);
        }

    }
}
