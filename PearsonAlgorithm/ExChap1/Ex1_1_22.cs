using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExChap1
{
    public class Ex1_1_22
    {

        private static int RecursiveBinarySearch(Array a ,int key, int hi, int lo, int indent) {
            Console.Write("Indent {0} - Lo:{1} - Hi:{2}\n", repeat(indent,'C'),lo,hi);
            if (lo > hi) { return -1; }
            int mid = lo + (hi - lo) / 2;
            if (Convert.ToInt32(a.GetValue(mid)) > key) {
                return RecursiveBinarySearch(a, key, mid - 1, lo, indent + 1);
            } else if (Convert.ToInt32(a.GetValue(mid)) < key) {
                return RecursiveBinarySearch(a, key, hi, mid + 1, indent + 1);
            }
            else { return mid; }
        }

        public static int RecursiveBinarySearch(Array a, int key)
        {
            return RecursiveBinarySearch(a, key, a.GetLength(0) - 1, 0, 0);
        }

        public static string repeat(int n, char c)
        {
            int i;
            string s = "";
            for (i = 0; i < n; i++) {
                s += c;
            }
            return s;
        }
    }
}
