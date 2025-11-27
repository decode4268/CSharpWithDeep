using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace CSharpWithDeep.CollectionInCsharp
{
    public class NonGenericCollection
    {
        //1.ArrayList
        /* 
         a.ArrayList belong to System.Collection
         b.It stores elements as obj type, not a specific type.
         c.Because of this, It supports mixed data types in the same list.
         d. It is Dynamic in size unlike Array.
         e. Since ArrayList store elements as object, value type(int, char, string, bool... etc) are boxed when stored. 
            When retrieving them, unboxing happens. 
            This makes arraylist slower compared to generic collection or Array.
         f. No Compile time type checking, Errors may occur at runtime. 
         */
        public void ArrayListCollection()
        {
            ArrayList list = new ArrayList();
            list.Add(1); // to add the new element in arraylist
            list.Add("DeepRaj");
            //list.AddRange(new int[] { 1, 2, 3, 4, 5 });// Add multiple item at once.
            //list.Insert(0, true);
            //list.InsertRange(1, new string[] { "B", "C" });  // InsertRange multiple item at a specific position.
            //list.Insert(1, false);

            //list.Remove(false); // Remove the first occurence of an item.
            //list.RemoveAt(2);
            //list.RemoveRange(1, 2); // Remove multiple item starting from an index
            //list.Clear(); // Remove all elements from the list
            // Contains => Check whether an item exists in the arraylist.
            Console.WriteLine(list.Contains("DeepRaj"));
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            //Console.WriteLine(list.Count - 1);
        }
        public void HashTableCollection()
        {
            Hashtable ht = new Hashtable();
            ht.Add("Id", 1);
            ht.Add("Name", "Deepraj");
            ht.Add("Salary", 50000);

            //Console.WriteLine(ht["Name"]);
            //ht.Remove("Id");

            //Console.WriteLine(ht.ContainsKey("Name"));     //    true
            //Console.WriteLine(ht.ContainsValue("Salary"));   //     false
            //ht.Clear();

            //foreach (DictionaryEntry item in ht)
            //{
            //    Console.WriteLine(item.Key + " = " + item.Value);
            //}

        }
        public void StackCollection()
        {
            Stack stack = new Stack();

            stack.Push(10);
            stack.Push(20);
            stack.Push("Deepraj");

            Console.WriteLine(stack.Peek());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
        }
        public void QueueCollection()
        {
            Queue q = new Queue();
            q.Enqueue(1);
            q.Enqueue(2);
            q.Enqueue(3);
            q.Enqueue(4);
            //q.Enqueue("Rajput");
            //q.Enqueue(false);

            Console.WriteLine(q.Dequeue());      // remove all item apart from first item and return first item.
            Console.WriteLine(q.Peek());         // it will not remove item and also return first item.
            Console.WriteLine(q.Contains(5));

            //foreach (var item in q)
            //{
            //    Console.WriteLine("Item of q is : "+ item);
            //}
        }
        public void SortedListCollection()
        {
            SortedList sortedList = new SortedList();

            sortedList.Add(3, "Rahul");
            sortedList.Add(2, "Govind");
            sortedList.Add(1, "Deepraj");

            //sortedList.Remove(3);
            Console.WriteLine(sortedList.ContainsKey(3));
            Console.WriteLine(sortedList.ContainsValue(1));
            //ContainsKey(key) - check exist by key.
            //      - ContainsValue(value) - check exist by value.
            //      - GetKey(index) - Get key based on the index.
            //      - GetByIndex(index) - Get value by position
            //      - Count - total items.
            //      - clear()
            //sortedList.Clear();

            //foreach (DictionaryEntry item in sortedList)
            //{
            //    Console.WriteLine(item.Key + " = " + item.Value);     // 1 = Deepraj
            //}

        }
    }

    public class GenericCollection
    {
        //List<T>, Dictionary<Tkey, TValue>, Stack<T>, Queue<T>, SortedList<T>, HashSet<T>

        // List with object type 
        class Student
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }
        public void ListGenericCollection()
        {
            // List with int data type
            List<int> numbers = new List<int>();

            numbers.Add(10);
            numbers.Add(20);
            numbers.Add(30);
            //Console.WriteLine(numbers[0]);
            //foreach (var item in numbers)
            //{
            //    Console.WriteLine(item);
            //}

            /// List with string data type
            var names = new List<string>();

            names.Add("Rohit");
            names.Add("Rahul");
            names.Add("Admit");
            names.Add("Deep");


            names.Insert(1, "Deepraj");
            names.Sort();
            names.Reverse();
            //foreach (var item in names)
            //{
            //    Console.WriteLine(item);
            //}


            // List with object type 
            List<Student> students = new List<Student>();
            students.Add(new Student { Id = 1, Name = "Deepraj" });
            students.Add(new Student { Id = 2, Name = "Rohit" });
            students.Add(new Student { Id = 3, Name = "Govind" });
            students.Add(new Student { Id = 4, Name = "Amit" });
            students.Add(new Student { Id = 5, Name = "Bhanu" });

            students.Sort((stu1, stu2) => stu1.Name.CompareTo(stu2.Name));
            //foreach (var student in students)
            //{
            //    Console.WriteLine($"{student.Id} - {student.Name}");
            //}

            List<int> num = new List<int> { 5, 12, 7, 15, 2, 20 };

            int firstLargenum = num.Find(n => n > 10);
            var allLarge = num.FindAll(n => n > 10);
            //Console.WriteLine("The firstLarge no is : " + firstLargenum);
            foreach (var item in allLarge)
            {
                Console.WriteLine(item);
            }
        }

        class Employee
        {
            public string Name { get; set; }
            public string Salary { get; set; }
        }

        public void DictionaryCollection()
        {

            Dictionary<int, Employee> empDict = new Dictionary<int, Employee>();

            empDict.Add(1, new Employee { Name = "Deepraj", Salary = "4500" });
            empDict.Add(2, new Employee { Name = "Govind", Salary = "5000" });

            foreach (var item in empDict)
            {
                Console.WriteLine($"{item.Key} = {item.Value.Name} ({item.Value.Salary}) ");
            }


            //Dictionary<int, String> dict = new Dictionary<int, string>();
            //dict.Add(1, "Rahul");
            //dict.Add(2, "Rajnish");
            //dict.Add(3, "Deepraj");
            //dict.Add(4, "Govind");

            //Console.WriteLine(dict[3]);

            //dict.Remove(3);
            //foreach (var item in dict)
            //{
            //    Console.WriteLine(item.Key + " = " + item.Value);
            //}

            //if (dict.ContainsKey(3))
            //{
            //    Console.WriteLine("Key 3 found");
            //}

            //string name = string.Empty;
            //if (dict.TryGetValue(3, out name))
            //{
            //    Console.WriteLine("Value = "+ name);
            //}

            //dict[3] = "Deepraj Rajput";
            //Console.WriteLine(dict[3]);

        }

        public void SortedSetCollection()
        {
            //SortedSet<int> numbers = new SortedSet<int>();

            //numbers.Add(30);
            //numbers.Add(20);
            //numbers.Add(10);
            //numbers.Add(5);
            //numbers.Add(5);   // Duplicate, ignored

            //foreach (var item in numbers)
            //{
            //    Console.WriteLine(item);
            //}

            // Union Example 
            SortedSet<int> set1 = new SortedSet<int> { 1, 3, 5 };
            SortedSet<int> set2 = new SortedSet<int> { 2, 3, 5, 4 };

            set2.UnionWith(set1);
            Console.WriteLine(set2.Min);
            Console.WriteLine(set2.Max);


            //foreach (var item in set2)
            //{
            //    Console.WriteLine(item);
            //}
        }

        public void StackCollection()
        {
            // Stack example using Generic class (Employee)
            //Stack<Employee> stack = new Stack<Employee>();
            //stack.Push(new Employee { Name = "Deepraj", Salary = "50K" });
            //Employee emp = stack.Pop();
            //var data = stack.FirstOrDefault();
            //if (data != null)
            //{
            //    Console.WriteLine(data.Name + " " + data.Salary);
            //}
            //else
            //{
            //    Console.WriteLine("No data available in stack collection");
            //}
            //Console.WriteLine(stack.First());
            //foreach(var item in stack)
            //{
            //    Console.WriteLine(item.Name + " " + item.Salary);
            //}


            // Stack using string 

            Stack<string> stack = new Stack<string>();
            stack.Push("A");
            stack.Push("B");
            stack.Push("C");
            stack.Push("D");

            //Console.WriteLine(stack.Contains("F")); //

            List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7 };

            Stack<int> stackList = new Stack<int>(list);  // Behaviour in LIFO 

            foreach (var item in stackList)
            {
                Console.WriteLine(item);
            }
        }
        public void QueueCollection()
        {
            Queue<int> numbers = new Queue<int>();
            numbers.Enqueue(10);
            numbers.Enqueue(20);
            numbers.Enqueue(30);
            numbers.Enqueue(40);

            numbers.Dequeue(); // 10

            Console.WriteLine(numbers.Peek());

            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
        }
        public void HashSetCollection()
        {
            //HashSet<int> set = new HashSet<int>();
            //set.Add(10);
            //set.Add(20);
            //set.Add(30);
            //set.Add(40);
            //set.Add(20);

            //foreach (var item in set)
            //{
            //    Console.WriteLine(item);
            //}

            // HashSet for Removing Duplicates. 
            //int[] arry = { 1, 2, 3, 3, 4, 4, 5 };

            //HashSet<int> unique = new HashSet<int>(arry);

            //foreach (var item in unique)
            //{
            //    Console.WriteLine(item);
            //}

            // Set Operations 
            HashSet<int> set1 = new HashSet<int> { 1, 2, 3 };
            HashSet<int> set2 = new HashSet<int> { 3, 4, 5 };

            set1.ExceptWith(set2);
            set1.UnionWith(set2);
            Console.WriteLine(set1.ToArray());
        }
    }

    public class CollectionInCsharpOneLecture
    {
        // Collection in C# 
        // What is Collection ?
        // Collection are classes that store and manage groups of realted object.
        // - Store multiple values
        // - Add / Remove / Update Item
        // - Perform searching and Sorting type of work.
        // In C# Collection exist in the System.Collections

        /* Why do not use Arrays instead Collections 
         - Array     : Fixed size  , Type-specific, Limited feature , Not to much built in method avaiable.
         - Collection: Dynamic size, Can store any type of value, Support sorting, searching, Lots of library of method.

        Types of Collections : 

        1- Non-Generic Collection (System.Collections)
        => ArrayList, Stack, Queue, SortedList, HashTable

        2- Generic Collection (System.Collections.Generic)
        => List<T>, Dictionary<Tkey, TValue>, Stack<T>, Queue<T>, SortedList<T>, HashSet<T>

         *  */

        static void Main()
        {
            NonGenericCollection obj = new NonGenericCollection();
            //obj.ArrayListCollection();   // ArrayList

            //obj.HashTableCollection();

            //obj.StackCollection();
            //obj.QueueCollection();
            //obj.SortedListCollection();

            GenericCollection generic = new GenericCollection();
            //generic.ListGenericCollection();
            //generic.DictionaryCollection();
            //generic.SortedSetCollection();
            //generic.StackCollection();
            //generic.QueueCollection();
            generic.HashSetCollection();
            Console.ReadKey();
        }
    }
}
