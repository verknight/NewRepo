using System;
using System.Collections.Generic;
namespace ExChap1
{
    public class Ex1_1_29
    {
        public static int rank(int key, Array input)//smaller than key
        {
            if (key < 0 || input.Length == 0) { return -1; }
            List<AlgNumber> compactArrList = Ex1_1_28.GetCompactListOfArray(input);
            int length = input.Length, res = 0, compactLength = compactArrList.Count;
            
            if (!compactArrList.Exists(item => item.SeedVal == key)) { return -1; }
            foreach (var item in compactArrList)
            {
                if (item.SeedVal < key)
                {
                    res += item.RepVal;
                    continue;
                }
                break;
            }
            return res;
        }
        public static int count(int key, Array input)//equal to key
        {
            if (key < 0 || input.Length == 0) { return -1; }
            int length = input.Length, res = 0;
            List<AlgNumber> compactArrList = Ex1_1_28.GetCompactListOfArray(input);
            if (!compactArrList.Exists(item => item.SeedVal == key)) { return -1; }
            res = compactArrList.Find(x => x.SeedVal == key).RepVal;
            return res;
        }
    }
}
