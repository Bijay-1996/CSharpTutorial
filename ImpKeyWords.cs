using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Using : Using Directive

namespace ConsoleApp1
{
    internal class ImpKeyWords
    {
        public int id;
        public string name;
        public ImpKeyWords(int id, string name)
        {
            //this: It use to refer to the current instance of the class
            //It avoids the name confusion between class field and constructor parameter
            this.id = id;
            this.name = name;
        }
        //Using : It use for Directive libarary, Using statement ensure that DISPOSE() method of the class object is called even if an exception occurs
        //Using keyword can be used with any class which is inherited from IDisposable class. for example with StreamReader class

        //Difference is and as operator
        public void strat()
        {
            int i = 0;
            bool b = i is int;//IS keyword used to check the type of the object and it always return boolen type
            object _obj = "Hello";
            string str = _obj as string;//AS operator used to perform conversion between compatible reference type
        }
        //ReadOnly and Constant
        public readonly int num = 100;//ReadOnly value can be changes inside the constructor part and It's Runtime constant
        public const int constnum = 100;//Constant value can't be changed and It's compile time constant
        public ImpKeyWords()
        {
            num = num * 2;//ReadOnly value can be changes inside the constructor part and It's Runtime constant
            //constnum = constnum + 100;//Constant value can't be changed and It's compile time constant
        }
        //Static classes which can't be created and which can not be inherited and static classes are used as containers for static memebrs like methods,constructor andther
        public void VarAndDynamic()
        {
            var a = 10;//the type of the variable is decided by the compiler at compile time.
            //a = "Hello";
            dynamic b = 10;//The type of the varibale decided at run time
            b = "bye";
           string name= _enum.Name.ToString();//Access the enum
        }
        //yield
        //Yield keyword will act as an iterator blocker and generate or return values
        public void UseYield()
        {
            foreach (int number in GenerateNumbers(1, 10))
            {
                Console.WriteLine(number);
            }
        }
        public static IEnumerable<int> GenerateNumbers(int start, int count)
        {
            for (int i = 0; i < count; i++)
            {
                yield return start + i;
                Console.WriteLine("Print");
            }
        }
    }
    //An Enum is a special class that represent a group of constant
    //Enum is sealed type class so it can't be inheritance
    public enum _enum{
        Name,
        Id
    }
}
