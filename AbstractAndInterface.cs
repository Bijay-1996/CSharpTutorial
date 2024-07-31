using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class AbstractAndInterface
    {
    }
    public abstract class Employee
    {
        public abstract void Project();
        public void Role()
        {
            Console.WriteLine("Abstract Don't support multiple inheritance and Abstract class can have constructor");
        }
    }
    public abstract class Person
    {
        static Person()
        {
            Console.WriteLine("Constructor of Abstract");
        }
        //public abstract void AgeCalculator();
        //public void Employee()
        //{
        //    Console.WriteLine("Persion");
        //}
    }
    //public sealed abstract class SealedPersion
    //{

    //}
    interface IEmployee
    {
        public void Projects();
        public void Manager();
    }
    interface IPersion
    {
        public void Age();
        public void Employee();
    }
    public class AbstractDerive : Person
    {
       
    }
    public class DeriveEmployee : Employee
    {
        public override void Project()
        {

        }

    }
    public class MulInterface : IEmployee, IPersion
    {
        public void Projects()
        {
            Console.WriteLine("Projects");
        }
        public void Manager()
        {
            Console.WriteLine("Manager");
        }

        public void Age()
        {
            Console.WriteLine("Age");
        }

        public void Employee()
        {
            Console.WriteLine("Employee");
        }
        public void Inside()
        {
            Console.WriteLine("In c# multiple inheritance support");
        }
    }
}
