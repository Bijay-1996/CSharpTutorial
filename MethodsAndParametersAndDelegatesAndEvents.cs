using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    //Method is a block that contains a series of statements
    internal class MethodsAndParametersAndDelegatesAndEvents
    {
        public void Started()
        {
            int c;
            int x = 6;
            int y = 5;
            //Pass By value
            PassByValue(x, y);
            Console.WriteLine(x + " " + y);
            //Output: 6 : 5
            //Passing by reference
            PassByReference(ref x, ref y);
            Console.WriteLine(x + " " + y);
            //Output: 600 :700
            //Out and ref
            int k = Update(out c, ref y);
            Console.WriteLine("Out Ref:", k);
            //Params keyword
            int sum= Addition(100,200,11,10);
            //Optional parameter
            AddOptional(10, 12);
            AddOptional(10, 12,18);
            //Named parameter
            NamedParameter(y: 40, x: 300);
            //Extension method
            string str = "HelloEarth";
            string left= str.RightExtension(5);

           


        }
        public void PassByValue(int x,int y)
        {
            x = 100;
            y=200;
            
        }
        void PassByReference(ref int x,ref int y)
        {
            x = 600;
            y = 700;
        }
        //Use of ref and out
        //No Need to initialize out parameter before passing it.
        //ref Must intialize ref parameter else error
        //Out parameter must be initialized before returning and ref is optional
        public int Update(out int x,ref int y)
        {
            x = 200;
            return x + y;
        }
        //params keywords
        //It is used when programmer don't have any prior knowledge about the number of parameter to be used.
        //Params keywords is used as a parameter which can take the variable number of parameters
        public int Addition(params int[] values)
        {
            int total = 0;
            foreach (int value in values)
            {
                total += value;
            }
            return total;
        }
        //Optioanl parameter allow some arguments which are not mandatory to pass and their default value is set
        public static void AddOptional(int x,int y,int k=10)
        {
            Console.WriteLine(x + y + k);
        }
        //Named parameter
        //Named parameter are used to specify an argument based on the name of the argument and not the position
        public void NamedParameter(int x, int y)
        {
            Console.WriteLine("X: " + x);
            Console.WriteLine("Y: " + y);
        }

    }
    //Extension
    //Extension method allows you to add new methods in the existing class without modifying the source code of the original class
    //Extension method must be static because this will be directly callled from the class name not by the object creation
    //this keyword is use from binding this class in main method
    static class StringExtensions
    {
        public static string RightExtension(this String s, int count)
        {
            return s.Substring(s.Length - count, count);
        }
    }
    //A delegate is a variable that holds the reference to a method or pointer to the method
    //When we need to pass a method as parameter
    delegate void Calculator(int x, int y);
    static class DelClass
    {
        public static void Add(int x,int y)
        {
            Console.WriteLine(y + x);
        }
        public static void Sub(int x,int Y)
        {
            Console.WriteLine(Y + x);
        }
        public static void Starter()
        {
            //Delegate Initilize
            Calculator cal = new Calculator(Add);
            //A multicast delegate in c# is a delegate that holds the references of more than one function.
            cal += Sub;

            //Call Delegate
            cal(10, 15);
            //Anonymous delegates
            //Delegates pointing methods without name are called anonymous delegates
            Calculator anycal = delegate (int a, int b)
            {
                Console.WriteLine(a + b);
            };
            //The Event is a notification mechanism that depends on delegates
            //An event is dependent on a delegate and can't be created without delegates
            //Event is like a wrapper over the delegate to improve its security
        }
    }
    
}
