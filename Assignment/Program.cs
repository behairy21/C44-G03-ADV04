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

            #region Q03
            //Hashtable ht = new Hashtable
            //{
            //    { "key1", "apple"},
            //    { "key2", "banana"},
            //    { "key3", "apple"},
            //    { "key4", "orange"},
            //    { "key5", "banana"}
            //};
            //Console.WriteLine("Enter the value to search for:");
            //string? targetVal = Console.ReadLine();

            //foreach (DictionaryEntry item in ht)
            //{
            //    if ((string)item.Value == targetVal)
            //        Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
            //}

            #endregion

            #region Q04
            //4.Given an array of strings, group anagrams together.

            //string[] arr = { "eat", "tea", "tan", "ate", "nat", "bat" };
            //Dictionary<string, List<string>> anagramGroups = new Dictionary<string, List<string>>();
            //foreach(string str in arr)
            //{
            //    char[] charArray = str.ToCharArray();
            //    Array.Sort(charArray);
            //    string sorted = new string(charArray);

            //    if (!anagramGroups.ContainsKey(sorted))
            //    {
            //        anagramGroups[sorted] = new List<string>();
            //    }
            //    anagramGroups[sorted].Add(str);
            //}

            //foreach (KeyValuePair<string, List<string>> item in anagramGroups)
            //{
            //    Console.WriteLine($"{item.Key} =>  {string.Join(", ",item.Value)}");
            //}
            #endregion

            #region Q05
            //5.Given an array of integers, check if the array contains any duplicates.

            //HashSet<int> hs = new HashSet<int>();
            //int[] arr = { 1, 2, 3, 4, 5, 1 };
            //bool hasDuplicates = false;
            //foreach (int num in arr)
            //{
            //    if (!hs.Add(num))
            //    {
            //        hasDuplicates = true;
            //        break;
            //    }
            //}
            //Console.WriteLine(hasDuplicates ? "Duplicates found." : "No duplicates found.");

            #endregion

            #region Q06

            //6.Implement a SortedDictionary that stores student IDs(int) and their names(string).Perform operations like adding, removing, and retrieving student names.
            //SortedDictionary<int, string> students = new SortedDictionary<int, string>();

            //students.Add(101, "Ali");
            //students.Add(105, "Sara");
            //students.Add(102, "Omar");

            //students.Remove(105);

            //Console.WriteLine(students[101]);

            //foreach (KeyValuePair<int, string> kv in students)
            //    Console.WriteLine($"{kv.Key} : {kv.Value}");

            #endregion


            #region Q07
            //7.Create an employee directory where employee IDs(int) are keys and employee names(string) are values. Use a SortedList to manage and retrieve employees in order of their IDs.
            //SortedList<int, string> sortedList = new SortedList<int, string>();

            //sortedList.Add(10, "John Doe");
            //sortedList.Add(9, "Jane Smith");
            //sortedList.Add(8, "Sam Brown");

            //foreach (KeyValuePair<int, string> kv in sortedList)
            //    Console.WriteLine($"ID: {kv.Key}, Name: {kv.Value}");


            #endregion

            #region Q08

            //8.Given an array of integers from 1 to N with some numbers missing, find the missing numbers.
            //int N = 10;
            //int[] arr = { 2, 5, 1, 9, 7, 4 };

            //HashSet<int> set = new HashSet<int>(arr);
            //List<int> missing = new List<int>();

            //for (int i = 1; i <= N; i++)
            //{
            //    if (!set.Contains(i))
            //        missing.Add(i);
            //}

            //Console.WriteLine("Missing: " + string.Join(", ", missing));

            #endregion

            #region Q09
            //9.You  have a list of integers with possible duplicates, create a HashSet that contains only unique values.

            //List<int> numbers = new List<int> { 1, 2, 2, 3, 4, 4, 5 };
            //HashSet<int> unique = new HashSet<int>(numbers);
            //Console.WriteLine(string.Join(", ",unique));

            #endregion

            #region Q10
            //10.You have a hashtable with unique values, create a new hashtable where the keys and values are swapped.

            //Hashtable table = new Hashtable();
            //table.Add(1, "Ali");
            //table.Add(2, "Sara");

            //Hashtable swapped = new Hashtable();
            //foreach (DictionaryEntry entry in table)
            //    swapped[entry.Value] = entry.Key;

            //foreach (DictionaryEntry entry in swapped)
            //    Console.WriteLine($"{entry.Key} : {entry.Value}");


            #endregion

            #region Q11
            //11.Find the union of two sets, returning the unique elements from both sets

            //HashSet<int> set1 = new HashSet<int> { 1, 2, 3, 4, 5 };
            //HashSet<int> set2 = new HashSet<int> { 3, 4, 5, 6, 7 };

            //set1.UnionWith(set2); 
            //Console.WriteLine(string.Join(", ", set1));


            #endregion

            #region Q12

            //12.You have a dictionary with string keys, the user will enter targetChar, count how many keys start with this targetChar.

            //Dictionary<string, int> dict = new Dictionary<string, int>
            //{
            //    { "apple", 1 },
            //    { "animal", 2 },
            //    { "airport", 3 },
            //    { "ball", 4 }
            //};

            //char target = 'a';
            //int count = 0;

            //foreach (var key in dict.Keys)
            //{
            //    if (key.StartsWith(target))
            //        count++;
            //}
            //Console.WriteLine($"Number of keys starting with '{target}': {count}");
            #endregion

            #region Q13
            //13.You have a sorted set, the user will enter an integer target, find all elements that are greater than target and add them in the list.
            //SortedSet<int> ints = new SortedSet<int> { 1, 3, 5, 7, 9 };
            //int target = 4;

            //List<int> greaterThanTarget = new List<int>();
            //foreach (var item in ints)
            //{
            //    if (item > target)
            //        greaterThanTarget.Add(item);
            //}

            //Console.WriteLine("Elements greater than " + target + ": " + string.Join(", ", greaterThanTarget));
            #endregion

            #region Q14
            //14.You have a sorted list with integer values, find all the keys associated with even values

            //SortedList<int ,int> sortedList = new SortedList<int, int>
            //{
            //    { 1, 10 },
            //    { 2, 15 },
            //    { 3, 20 },
            //    { 4, 25 }
            //};
            //List<int> keysWithEvenValues = new List<int>();
            //foreach (var item in sortedList)
            //{
            //    if(item.Key %2 ==0)
            //        keysWithEvenValues.Add(item.Key);
            //}
            //Console.WriteLine("Keys with even values: " + string.Join(", ", keysWithEvenValues));

            #endregion

        }
    }

}