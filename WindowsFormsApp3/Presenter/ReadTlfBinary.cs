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


        //-------------------------------------------------------------------------------------------//
        public static List<T> GetListWithBinaryLetters<T>(List<T> list, string val) where T : IPerson
        {
          //  Console.WriteLine(list[0]);
            var listCount = list.Count();
       
            int index = BinSearchLetters(list, val, 0, listCount);
            List<T> newList = new List<T>();
            bool condition = true;

  
            while (condition && index != -1 && index < listCount)
            {
              //  Console.WriteLine(list[index].LastName);
             //   Console.WriteLine(val.Length);
                int length = val.Length;
                if (val.Length > list[index].LastName.Length)
                {
                    length = list[index].LastName.Length;
                }

                if (list[index].LastName.Substring(0, length) == val)
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
        private static int BinSearchLetters<T>(List<T> a, string mystring, int left, int right) where T : IPerson
        {
            if (left == right)
            {
                // Console.WriteLine(a[left].LastName.StartsWith(mystring));
             //   Console.WriteLine(a[left].LastName);
                return left >= 0 && left < a.Count && a[left].LastName.StartsWith(mystring) ? left : -1;
            }
            int mid = (right + left) / 2;

            int length = mystring.Length;
            if (mystring.Length > a[mid].LastName.Length)
            {
                length = a[mid].LastName.Length;

                
            }
            return (string.Compare(mystring, a[mid].LastName.Substring(0, length)) == 1) ? BinSearchLetters(a, mystring, mid + 1, right) : BinSearchLetters(a, mystring, left, mid);
        }

    }
}
