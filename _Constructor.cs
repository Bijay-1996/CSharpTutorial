using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp1
{
    //A Constructor is a specialized method in the class which gets executed when class object in created
    //Constructor name will same as of class name
    //It used to set default values for the class
    //Types: Default constructor, parameterized constructor, Copy Constructor, Static constructor, Private Constructor
    class _Constructor
    {

        //Default_Constructor default_Constructor=new Default_Constructor();
        //Parameter_Constructor parameter_Constructor = new Parameter_Constructor(300);
        public void InStart()
        {
            //Static_Constructor.PrintSc();
            //Copy_Constructor copy_Constructor = new Copy_Constructor("Happy");
            //Copy_Constructor copy_Constructor1 = new Copy_Constructor(copy_Constructor);
            //Console.Write(copy_Constructor1.name);
            //Constructor_OverLoading constructor_OverLoading = new Constructor_OverLoading();
            //Constructor_OverLoading constructor_OverLoading1 = new Constructor_OverLoading(10);
            //Constructor_OverLoading constructor_OverLoading2 = new Constructor_OverLoading("Bijay",10);
        }


    }
    //Default constructor is a constructor that is automatically created by the compiler, if no other constructor are defined in the class.
    public class Default_Constructor
    {
        public Default_Constructor()
        {
            Console.WriteLine("Default Constructor");
        }
    }
    //A constructor with at least one parameter is a parameterized constructor.
    public class Parameter_Constructor
    {
        public Parameter_Constructor(int x)
        {
            Console.WriteLine("Parameter Constructor");
        }
    }
    //Static constructor is used to be called before any static member of class called
    //No need to create object of the class to call the function
    //No acess modifier and parameter
    public class Static_Constructor
    {
        static Static_Constructor()
        {
            Console.WriteLine("Static Constructor");
        }
       public static void PrintSc()
        {
            Console.WriteLine("Static method");
        }

    }
    //Copy Constuctor which creates an object by copying variables from another object is called a copy constructure.
    public class Copy_Constructor
    {
        public string name;
        //Parameterized constructor
        public Copy_Constructor(string name)
        {
            this.name = name;
        }
        //Copy Constructor
        public Copy_Constructor(Copy_Constructor copy)
        {
            name = copy.name;
        }
    }
    //When a constructor is created with a private specifier, It is not possible for other classes to derive from class, neither is it possible to create an instance of this class.
    //Practically use in singletone patten
    public class Private_Constructor
    {
        private Private_Constructor()
        {
            Console.WriteLine("Priavte");
        }
    }
    //Constructor overloading is a technique to define multiple constructor within a class with different sets of parameters
    public class Constructor_OverLoading
    {
        public Constructor_OverLoading()
        {

        }
        public Constructor_OverLoading(int x)
        {
            Console.WriteLine(x);
        }
        public Constructor_OverLoading(string Name,int id)
        {
            Console.WriteLine(Name + " " + id);
        }
    }
    //Destructor in c# are methods inside the class used to destroy instances of that when they are no longer needed
    //Destructor is called implicitly by the .NET framework's Garbage collector
    public class Destructor
    {
        public Destructor()
        {

        }
        ~Destructor()
        {

        }
    }
}
