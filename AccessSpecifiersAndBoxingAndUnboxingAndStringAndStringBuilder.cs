using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    //Internal modifier is used to tell that acess is limited to the current assembly(assembly means project).
    //Internal is the default modifier in class
   class AccessSpecifiersAndBoxingAndUnboxingAndStringAndStringBuilder
    {
        public static void BosingAndUnBoxing()
        {
            int num = 100;
            object obj = num;//Boxing: Converting value to reference type
            int unboxing = (int)obj;//Unboxing: Converting back from reference type to value type
            ArrayList arrayList = new ArrayList();
            arrayList.Add(obj);//Boxing
            int k = (int)arrayList[0];//Unboxing
            Console.WriteLine("Boxing and Unboxing");
        }
        public void StringOperation()
        {
            //Concatenate
            string str1 = "Hello";
            string str2 = "World";
            string combine = str1 + str2;
            //Replace
            string replace = combine.Replace("World", "Earth");
            //Trim
            string trim = replace.Trim();//Remove white spaces from string
            //Contains
            bool result = trim.Contains("Hello");
            Console.WriteLine(trim);
            //String Builder
            string _builder = "Builing";
            _builder = _builder + "Happy";
            Console.WriteLine(_builder);//String is Immutable in c# : It means if you defined one string then you couldn't modify it. Every time you will assign same value to it, It will create a new string
            StringBuilder sb = new StringBuilder();
            sb.Append(str1);
            sb.Append(str2);//It manipulatation will be done on string, then it will not create a new instance every time
            //String Interpolation
            Console.WriteLine($"My new String {_builder}");//String Interpolation is a technique that enables you to insert express values into strings

        
        }
        
    }
}
