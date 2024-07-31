using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    //LINQ : Language Integrated Query is unform query syntax in c# to retrive data from different sources.

    //Object collection (LINQ to Objects) ,ADO.Net Dataset(LINQ to DataSet), XML Documents(LINQ to XML), Entity Framework (LINQ to Entity), SQL Database (LINQ to SQL), Other DataSourece (By Implementing IQueryable)
    class LINQ_INCSharp
    {
        public static void LINQSart()
        {
            List<int> list = new List<int> { 1, 3, 4, 5, 6, 7 };
            //Using System.Linq
            IEnumerable<int> filter=from n in list where n > 0 select n;
            //List method and Lambda expression
            //A lambda expression is used to simplify the syntax of anonymous methods.
            List<int> eventnumber = list.FindAll(x => x % 2 == 0);
            //Difference between first vs firstdefault
            //First method will return the first value but it is not able to handle null values.
            int _first = list.First(a => a % 2 == 0);
            //FirstOrDefault will return the first value and it able to handle null values also
            int _firstOrDefault = list.FirstOrDefault(x => x % 2 == 0);
        }
    }
}
