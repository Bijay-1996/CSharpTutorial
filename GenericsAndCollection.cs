using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    //Generic allows us to make classes and methods- type independent or type safe
    internal class GenericsAndCollection
    {
        public void Start()
        {
            bool check=AreEqual<int>(0, 0);
            //bool _check=AreEqual<string>("Hello", "Hello");
            bool classreive = GenericClass<int>.AreEquals(1, 1);
        }
        //Generic method
        public static bool AreEqual<T>(T value1, T value2)
        {
            return value1.Equals(value2);
        }
    }
    //Generic class
   public class GenericClass<T>
    {
        public static bool AreEquals(T value1, T value2)
        {
            return value2.Equals(value1);
        }
    }
    //# 3 catagery of collection i.e System.Collections.Generic, System.Collections.Concurrent (It good for threading), System.Collections
    //Type of collection: ArrayList, HashTable, Queue, Stack , Dictionary, List ,etc
    //Array Is Strongly type but ArrayList is not strongly type
    //In ArrayList only items to be store but in hashtable item value add with keys
    //List is the generic version of ArrayList and Dictionary is the generic version of HashTable
    public class collectionType
    {
        ArrayList _arraylist=new ArrayList();//Collection
        List<int> list = new List<int>();//Generic collection
        Hashtable ht = new Hashtable();//Generic
        Dictionary<int,string> dict = new Dictionary<int,string>();//Generic collection
        public void UseOfIEnum()
        {
            //IEnumerable interface is used when we want to iterate among our collection classes using a FOREACH loop.
            List<Employees> list = new List<Employees>()
            {
                new Employees(){id=1,Name="Bijay"},
            };
            foreach (Employees employee in list)
            {
                Console.WriteLine(employee.Name);
                Console.WriteLine(employee.id);
            }
            //IEnumerator example
            IEnumerator<Employees> enumerator = list.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }
            //IEnumerable internaly uses ienumerator via forach loop and IEnumerabel simplifies the use of IEnumerator
            //IEnumerable is used with in-memory collection
            //IQueryable is better in getting result from database
            List<string> list2 = new List<string>();
            list2.Add("Happy");
            list2.Add("Happy");
            IEnumerable<string> Ienum = list2;//IEnumerable under System.collection liberary
            foreach (string s in Ienum)
            {
                Console.WriteLine($"{s}");
            }
            //IQueryable
            IQueryable<string> iquery = (IQueryable<string>)list2;//IQueryable Under System.LINQ liberary
            foreach (string s in iquery)
            {
                Console.WriteLine(s);
            }
            


        }
        
    }
    public class Employees
    {
        public int id { get;set;}
        public string Name { get;set;}
    }

}
