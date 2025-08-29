using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Globalization;
using System.IO;
using System.Numerics;
using System.Runtime.Intrinsics.X86;
using System.Xml;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Q01
            //1.Given an array of integers, count the frequency of each element using a hash table.

            //Hashtable ht = new Hashtable();

            //int[] arr = { 1, 2, 3, 4, 5, 1, 2, 3, 1, 2, 1 };

            //foreach (int num in arr)
            //{
            //    if (ht.ContainsKey(num))
            //        ht[num] = (int)ht[num] + 1;

            //    else     
            //        ht[num] = 1;

            //}

            //foreach (DictionaryEntry entry in ht)
            //{
            //    Console.WriteLine($"Element: {entry.Key}, Frequency: {entry.Value}");


            #endregion


            #region Q02
            //2.You have a hashtable where its values are integers, find the key associated with the highest value.

            //Hashtable ht = new Hashtable
            //{
            //    { "a", 10 },
            //    { "b", 20 },
            //    { "c", 30 },
            //    { "d", 40 }
            //};
            //string keyWithMaxValue = null;
            //int maxValue = int.MinValue;
            //foreach (DictionaryEntry entry in ht)
            //{
            //    if ((int)entry.Value > maxValue)
            //    {
            //        maxValue = (int)entry.Value;
            //        keyWithMaxValue = (string)entry.Key;
            //    }
            //}
            //Console.WriteLine($"Key with highest value: {keyWithMaxValue}, Value: {maxValue}");

            #endregion


        }
    }

}