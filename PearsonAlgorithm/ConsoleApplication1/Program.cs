using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlrthmsLib;
namespace Main
{
    class Program
    {
        #region Field declaration
        private static HashSet<Type> NumericType = new HashSet<Type> {
            typeof(byte),
            typeof(sbyte),
            typeof(short),
            typeof(ushort),
            typeof(int),
            typeof(uint),
            typeof(float),
            typeof(double),
            typeof(decimal),
            typeof(long),
            typeof(ulong)
        };
        #endregion

        private static Type IsNumericType(object o)
        {
            if (NumericType.Contains(o.GetType()) || NumericType.Contains(Nullable.GetUnderlyingType(o.GetType())))
            {
                
            }
            return null;
        }
        public static Array GetRanDomValue(Type type,int size)
        {
            if (size <= 1) { return null; }
            if (!IsNumericType(type)) { return null; }
            Array dumpArr = Array.CreateInstance(type,size);
            int i, length = dumpArr.GetLength(0);
            Random r = new Random();
            switch (){
                case: { }
                    break;

            }
            for (i = 0; i < length; i++)
            {
                //dumpArr.SetValue()
            }
            return dumpArr;
        }
        private static void ShowResult()
        {
            Array input = GetRanDomValue(typeof(int),20);
            Array.Sort(input);
            if (input == null) { Console.WriteLine("Empty"); }
            int length = input.GetLength(0) , i, randomKey = Random();
            for (i = 0; i < length; i++)
            {
                if (i % 5 == 0) { Console.WriteLine("\n"); }
                PsTSearching.BinarySearch();
            }
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            ShowResult();
        }
    }
}
