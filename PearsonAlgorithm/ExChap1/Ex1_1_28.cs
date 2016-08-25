using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExChap1
{
    public class AlgNumber
    {
        private int seedVal;
        private int firstAppearIndex;
        private int repVal;
        private bool isRep;

        public int SeedVal
        {
            get { return seedVal; }
            set { seedVal = value; }
        }
        public int FirstAppearIndex
        {
            get { return firstAppearIndex; }
            set { firstAppearIndex = value; }
        }
        public int RepVal
        {
            get { return repVal; }
            set { repVal = value; }
        }
        public bool IsRep
        {
            get { return isRep; }
            set { if (repVal > 0) { isRep = true; } else { isRep = false; } }
        }

        public override string ToString() {
            return string.Format("Value: {0} 1stAppearIndex: {1} Reps: {2} IsRep: {3}",SeedVal,FirstAppearIndex,RepVal,IsRep);
        }
    }

    public class Ex1_1_28
    {   
        public static List<AlgNumber> GetCompactListOfArray(Array input)
        {
            if (input.Length == 0) { return null; }
            List<AlgNumber> res = new List<AlgNumber>();
            Array tmpArr = input;
            AlgNumber seed;
            int length = input.Length, i, tmpVal = Convert.ToInt32(tmpArr.GetValue(0)), counter = 0;
            for (i = 0; i < length; i++)
            {
                if ( tmpVal == Convert.ToInt32(tmpArr.GetValue(i))) {
                    counter += 1;
                    if (i != (length - 1)) { continue; }else { i += 1; }
                }
                seed = new AlgNumber {
                    SeedVal = Convert.ToInt32(tmpArr.GetValue(i - 1)),
                    FirstAppearIndex = i - counter,
                    RepVal = counter
                };
                res.Add(seed);
                if (i == length)
                {
                    break;
                }
                tmpVal = Convert.ToInt32(tmpArr.GetValue(i));
                counter = 0; 
                i -= 1;
            }
            return res;
        }
        private Dictionary<int,Array> GetDistance(Array input, int val)
        {
            if (input.Length == 0) { }
            int distance = 0, length = input.Length, i;
            Dictionary<int, Array> res = new Dictionary<int, Array>();
            for (i = 0; i < length; i++)
            {
                if (Convert.ToInt32(input.GetValue(i)) == val)
                {
                    distance += 1;
                }
            }
            return res;
        }
    }
}
