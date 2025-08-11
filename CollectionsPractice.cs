using System;
using System.Collections.Generic;
using System.Collections;

namespace CSharpBasicsPractice
{
    public class CollectionsPractice
    {
        //Non-Generic Collection Examples
        public static void NonGenricCollections()
        {
            Console.WriteLine("==== Non-Generic Collections ====");

            // ArrayList
            ArrayList arrayList = new ArrayList();
            arrayList.Add(1);
            arrayList.Add("Hello");
            arrayList.Add(3.14);
            Console.WriteLine("ArrayList Elements: ");
            foreach (var item in arrayList) Console.WriteLine(item);
            arrayList.Remove("Hello");
            Console.WriteLine("After Remove: " + string.Join(", ", arrayList.ToArray()));

            // Hashtable
            Hashtable hashtable = new Hashtable();
            hashtable.Add(1, "One");
            hashtable.Add(2, "Two");
            Console.WriteLine("\n Hashtable Elements : ");
            foreach (DictionaryEntry entry in hashtable)
                Console.WriteLine($"{entry.Key}: {entry.Value}");
            hashtable.Remove(1);

            // Queue
            Queue queue = new Queue();
            queue.Enqueue("First");
            queue.Enqueue("Second");
            Console.WriteLine("\n Queue Elements : ");
            foreach (var q in queue) Console.WriteLine(q);
            Console.WriteLine("Dequeud : " + queue.Dequeue());

            // Stack
            Stack stack = new Stack();
            stack.Push("One");
            stack.Push("Two");
            Console.WriteLine("\n Stcak Elements : ");
            foreach (var s in stack) Console.WriteLine(s);
            Console.WriteLine("Popped : " + stack.Pop());

            // 5. SortedList
            SortedList sortedList = new SortedList();
            sortedList.Add(3, "Three");
            sortedList.Add(1, "One");
            sortedList.Add(2, "Two");
            Console.WriteLine("\nSortedList Elements:");
            foreach (DictionaryEntry entry in sortedList)
                Console.WriteLine($"{entry.Key} - {entry.Value}");
        }

        public static void GenericCollections()
        {
            Console.WriteLine("\n===== GENERIC COLLECTIONS =====\n");

            // 1. List<T>
            List<int> numbers = new List<int> { 10, 20, 30 };
            numbers.Add(40);
            numbers.Insert(1, 15);
            Console.WriteLine("List Elements: " + string.Join(", ", numbers));
            numbers.Remove(20);
            Console.WriteLine("After Remove: " + string.Join(", ", numbers));
            Console.WriteLine("Contains 30? " + numbers.Contains(30));

            // 2. Dictionary<TKey, TValue>
            Dictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(1, "One");
            dict[2] = "Two";
            Console.WriteLine("\nDictionary Elements:");
            foreach (var kv in dict) Console.WriteLine($"{kv.Key} - {kv.Value}");
            dict.Remove(1);

            // 3. Queue<T>
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("First");
            queue.Enqueue("Second");
            Console.WriteLine("\nGeneric Queue Elements:");
            foreach (var q in queue) Console.WriteLine(q);
            Console.WriteLine("Dequeued: " + queue.Dequeue());

            // 4. Stack<T>
            Stack<string> stack = new Stack<string>();
            stack.Push("One");
            stack.Push("Two");
            Console.WriteLine("\nGeneric Stack Elements:");
            foreach (var s in stack) Console.WriteLine(s);
            Console.WriteLine("Popped: " + stack.Pop());

            // 5. HashSet<T>
            HashSet<int> set = new HashSet<int> { 1, 2, 3 };
            set.Add(4);
            set.Add(2); // Won't add duplicate
            Console.WriteLine("\nHashSet Elements: " + string.Join(", ", set));
            Console.WriteLine("Contains 3? " + set.Contains(3));

            // 6. SortedDictionary<TKey, TValue>
            SortedDictionary<int, string> sortedDict = new SortedDictionary<int, string>();
            sortedDict.Add(3, "Three");
            sortedDict.Add(1, "One");
            sortedDict.Add(2, "Two");
            Console.WriteLine("\nSortedDictionary Elements:");
            foreach (var kv in sortedDict) Console.WriteLine($"{kv.Key} - {kv.Value}");
        }
    }
}
