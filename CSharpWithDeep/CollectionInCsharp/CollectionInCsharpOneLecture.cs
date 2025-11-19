using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
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
            //list.InsertRange(1, new string[] { "B", "C" });  // InsertRange multiple itemat a specific position.
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
            obj.ArrayListCollection();

            Console.ReadKey();
        }

    }
}
