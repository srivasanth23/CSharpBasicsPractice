using System;
using System.Collections;
using System.Collections.Generic;

namespace CSharpBasicsPractice
{
    public class CollectionsExamples
    {
        // 1️⃣ Non-Generic Collections & Interfaces
        public static void NonGenericCollections()
        {
            Console.WriteLine("===== NON-GENERIC COLLECTIONS =====\n");

            // ICollection Interface example (ArrayList implements it)
            ArrayList arrayList = new ArrayList();
            arrayList.Add(1);
            arrayList.Add("Hello");
            arrayList.Add(3.14);
            Console.WriteLine("ArrayList (ICollection) Elements:");
            foreach (var item in arrayList) Console.WriteLine(item);
            Console.WriteLine("Count: " + arrayList.Count);

            // IList Interface example (ArrayList implements it)
            IList list = new ArrayList();
            list.Add("A");
            list.Insert(1, "B");
            list.Add("C");
            Console.WriteLine("\nIList Example:");
            foreach (var item in list) Console.WriteLine(item);

            // IDictionary Interface example (Hashtable implements it)
            IDictionary dict = new Hashtable();
            dict.Add(1, "One");
            dict[2] = "Two";
            Console.WriteLine("\nIDictionary Example:");
            foreach (DictionaryEntry entry in dict)
                Console.WriteLine($"{entry.Key} - {entry.Value}");

            // IEnumerable Example (ArrayList)
            IEnumerable enumerable = arrayList;
            Console.WriteLine("\nIEnumerable Example:");
            foreach (var item in enumerable) Console.WriteLine(item);
        }

        // 2️⃣ Generic Collections & Interfaces
        public static void GenericCollections()
        {
            Console.WriteLine("\n===== GENERIC COLLECTIONS =====\n");

            // ICollection<T> example
            ICollection<int> numbers = new List<int> { 10, 20, 30 };
            numbers.Add(40);
            Console.WriteLine("ICollection<T> Elements: " + string.Join(", ", numbers));

            // IList<T> example
            IList<string> strList = new List<string>();
            strList.Add("One");
            strList.Insert(1, "Two");
            Console.WriteLine("\nIList<T> Example:");
            foreach (var s in strList) Console.WriteLine(s);

            // IDictionary<TKey, TValue> example
            IDictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(1, "Apple");
            dict[2] = "Banana";
            Console.WriteLine("\nIDictionary<TKey, TValue> Example:");
            foreach (var kv in dict) Console.WriteLine($"{kv.Key} - {kv.Value}");

            // IEnumerable<T> example
            IEnumerable<int> enumerable = numbers;
            Console.WriteLine("\nIEnumerable<T> Example:");
            foreach (var num in enumerable) Console.WriteLine(num);
        }

        // 3️⃣ Specific Generic Collections Examples
        public static void AllGenericCollections()
        {
            // List<T>
            List<int> list = new List<int> { 1, 2, 3 };
            list.Add(4);
            list.Sort();
            Console.WriteLine("\nList<T>: " + string.Join(", ", list));

            // Dictionary<TKey, TValue>
            Dictionary<int, string> dict = new Dictionary<int, string>
            {
                { 1, "One" },
                { 2, "Two" }
            };
            Console.WriteLine("\nDictionary<TKey, TValue>:");
            foreach (var kv in dict) Console.WriteLine($"{kv.Key} - {kv.Value}");

            // Queue<T>
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("First");
            queue.Enqueue("Second");
            Console.WriteLine("\nQueue<T>: " + string.Join(", ", queue));

            // Stack<T>
            Stack<string> stack = new Stack<string>();
            stack.Push("One");
            stack.Push("Two");
            Console.WriteLine("\nStack<T>: " + string.Join(", ", stack));

            // HashSet<T>
            HashSet<int> set = new HashSet<int> { 1, 2, 3, 2 };
            Console.WriteLine("\nHashSet<T>: " + string.Join(", ", set));

            // SortedDictionary<TKey, TValue>
            SortedDictionary<int, string> sortedDict = new SortedDictionary<int, string>
            {
                { 3, "Three" },
                { 1, "One" },
                { 2, "Two" }
            };
            Console.WriteLine("\nSortedDictionary<TKey, TValue>:");
            foreach (var kv in sortedDict) Console.WriteLine($"{kv.Key} - {kv.Value}");
        }
    }
}
