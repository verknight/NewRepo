using System;
using System.Collections.Generic;
using System.Linq;
using ExChap1;
using AlrthmsLib;

namespace Main
{
    public static class ShuffleExtensions
    {
        public static IEnumerable<tsource> RandomShuffle<tsource>(this IEnumerable<tsource> source)
        {
            var rand = new Random();
            return source.Select(t => new
            {
                Index = rand.Next(),
                Value = t
            })
                .OrderBy(p => p.Index)
                .Select(p => p.Value);
        }
    }

    class Program
    {
        #region Field declaration
        private static HashSet<TypeCode> NumericType = new HashSet<TypeCode> {
            TypeCode.SByte,
            TypeCode.Byte,
            TypeCode.Int16,
            TypeCode.UInt16,
            TypeCode.Int32,
            TypeCode.UInt32,
            TypeCode.Int64,
            TypeCode.UInt64,
            TypeCode.Single,
            TypeCode.Double,
            TypeCode.Decimal
        };
        #endregion

        public static void TestRandomShuffle()
        {
            // create and populate the original list with 1000 elements
            var l = new List<int>(100);
            for (var i = 0; i < 100; i++)
                l.Add(i);

            var shuffled = l.RandomShuffle().ToArray();
            for (var i = 0; i < 100; i++) { 
                if (i % 5 == 0) { Console.Write("\n"); }
                Console.Write(i + ":" + shuffled[i].ToString() + ",");
            }
            Console.ReadLine();
        }

        private static bool IsNumericType(object o)
        {   
            return (NumericType.Contains(Type.GetTypeCode(o as Type)) || NumericType.Contains(Type.GetTypeCode(Nullable.GetUnderlyingType(o as Type))) );
        }
        
        public static Array GetRanDomValue(Type type,int size, int maxvalue = 15)
        {
            if (size <= 1) { return null; }
            if (!IsNumericType(type)) { return null; }
            Array dumpArr = Array.CreateInstance(type,size);
            int i, length = dumpArr.GetLength(0);
            Random r = new Random();
            //TypeCode tCode = Type.GetTypeCode(type);
            for (i = 0; i < length; i++)
            {
                dumpArr.SetValue(r.Next(maxvalue),i);
            }
            return dumpArr;
        }

        private static void ShowResult()
        {
            Array wList = GetRanDomValue(typeof(int),500);
            //Array tList = GetRanDomValue(typeof(int),200);
            Array.Sort(wList);
            if (wList == null) { Console.WriteLine("Empty"); }
            int length = wList.GetLength(0) , i, randomKey = (new Random()).Next(100);
            for (i = 0; i < length; i++)
            {
                if (i % 5 == 0) { Console.Write("\n"); }
                Console.Write(" {0}-{1} ",wList.GetValue(i),i);
            }
            int result = PsTSearching.BinarySearch(randomKey, wList);
            if (result == -1) { Console.WriteLine("Not found"); return; }
            Console.ReadLine();
            Console.WriteLine("Found {0} at {1}", randomKey, result);
            Console.ReadLine();
        }

        private static void Ex1_1_22Res()
        {
            Array WList = GetRanDomValue(typeof(int),200);
            Array.Sort(WList);
            int i,j;
            for (i = 0; i < WList.Length; i++)
            {
                if (i % 5 == 0) { Console.Write("\n"); }
                Console.Write(" {0}-{1} ", WList.GetValue(i), i);
            }
            Console.WriteLine("\n");
            int[] keys = new int[100];
            Random r = new Random();
            for (j = 0; j < keys.Length; j++)
            {
                keys[j] = r.Next(100);
            }
            int result;
            List<int> TList = new List<int>();
            foreach (int val in keys)
            {
                result = ExChap1.Ex1_1_22.RecursiveBinarySearch(WList, val);
                if (result == -1) { TList.Add(val); }
                Console.WriteLine("Ex1_1_22 result, found key {0} at {1}", val, result);
                //Console.ReadLine();
            }
            foreach (var val in TList) {
                Console.WriteLine("{0}".PadRight(2), val);
            }
            Console.ReadLine();
        }

        private static void Ex1_1_28Res()
        {
            Array WList = GetRanDomValue(typeof(int),100);
            Array.Sort(WList);
            List<AlgNumber> res = Ex1_1_28.GetCompactListOfArray(WList);
            int i,j;
            for (j = 0; j < WList.Length; j++)
            {
                if (j % 5 == 0) { Console.Write("\n"); }
                Console.Write("{0} ", WList.GetValue(j));
            }
            Console.ReadLine();
            for (i = 0; i < res.Count; i++)
            {
                //if (i % 5 == 0) { Console.Write("\n"); }
                Console.Write("{0} \n", res[i]);
            }
            Console.ReadLine();
        }

        private static void Ex1_1_29Res()
        {
            Array input = GetRanDomValue(typeof(int),55);
            Array.Sort(input);
            int randomKey = (new Random()).Next(5);
            List<AlgNumber> res = Ex1_1_28.GetCompactListOfArray(input);
            int i, j;
            for (j = 0; j < input.Length; j++)
            {
                if (j % 5 == 0) { Console.Write("\n"); }
                Console.Write("{0} ", input.GetValue(j));
            }
            Console.ReadLine();
            for (i = 0; i < res.Count; i++)
            {
                //if (i % 5 == 0) { Console.Write("\n"); }
                Console.Write("{0} \n", res[i]);
            }
            Console.WriteLine("Random val: {0} Rank: {1} Count: {2}", randomKey, Ex1_1_29.rank(randomKey, input), Ex1_1_29.count(randomKey, input));
            Console.ReadLine();
        }


        static void Main(string[] args)
        {
            //ShowResult();
            //TestRandomShuffle();
            //Ex1_1_22Res();
            //Ex1_1_28Res();
            Ex1_1_29Res();
        }
    }
}
