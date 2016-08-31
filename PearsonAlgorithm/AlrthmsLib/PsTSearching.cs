using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlrthmsLib
{
    public class PsTSearching
    {
        public static int BinarySearch(int key, Array input)
        {
            int lo = 0;
            int hi = input.Length - 1 , mid;
            while (lo <= hi)
            {   // Key is in a[lo..hi] or not present.
                mid = lo + (hi - lo) / 2;
                if (key < (int)input.GetValue(mid)) hi = mid - 1;
                else if (key > (int)input.GetValue(mid)) lo = mid + 1;
                else return mid;
            }
            return -1;
        }
    }
}

