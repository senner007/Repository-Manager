using Manager.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
          // Stopwatch stopwatch = Stopwatch.StartNew();
            val = val.ToLower(culture);
            int valLength = val.Length;
            
            var listCount = list.Count();
            // database simulering hvor der søges på laveste og højeste forekomst, der opfylder søgningskriteriet
            int index = BinaryLowest(0, listCount);
            if (index == -1) return new List<T>();
            int indexHigh = BinaryHighest(index, listCount);
            if (indexHigh == -1) return new List<T>();

            Console.WriteLine(index);
            Console.WriteLine(indexHigh);

            // GetRange(O(n)) er åbenbart hurtigere end et while loop
            // parametre er index , count
            List<T> newlist = list.GetRange(index, indexHigh - index + 1);


            //stopwatch.Stop();
            //onsole.WriteLine(stopwatch.Elapsed);

            return newlist;

           // return newlist;

            int BinaryLowest(int left, int right)
            {
                if (left == right)
                {
                    return left >= 0 && left < listCount && list[left].LastName.ToLower(culture).StartsWith(val) ? left : -1;
                }
                int mid = (right + left) / 2;

                int mylength = valLength > list[mid].LastName.Length ? list[mid].LastName.Length : valLength;

                return (string.Compare(val, list[mid].LastName.ToLower(culture).Substring(0, mylength)) == 1) ? BinaryLowest(mid + 1, right) : BinaryLowest(left, mid);
            }
            int BinaryHighest(int left, int right)
            {
                if (left == right)
                {
                    return left - 1 >= 0 && left - 1 < listCount && list[left - 1].LastName.ToLower(culture).StartsWith(val) ? left - 1 : -1;
                }
                int mid = (right + left) / 2;
                int mylength = valLength > list[mid].LastName.Length ? list[mid].LastName.Length : valLength;
                return (string.Compare(val, list[mid].LastName.ToLower(culture).Substring(0, mylength)) == -1) ? BinaryHighest(left, mid) : BinaryHighest(mid + 1, right);
            }
        }
    }
}
