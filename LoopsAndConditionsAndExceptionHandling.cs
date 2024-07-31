using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class LoopsAndConditionsAndExceptionHandling
    {
        public void Looping()
        {
            //While Loop : It execute untill the condition is satisfied
            int i = 5;
            while (i < 5)
            {
                Console.WriteLine(i);
                i++;
            }
            //Do while : Whether condition true and false, this statement will run al least first time.
            int j = 5;
            do
            {
                Console.WriteLine(j);
                j++;
            }
            while (j < 10);
            //For Loop :It will execute untill the condition is satishfied
            for(int k=0; k<5; k++)
            {
                Console.WriteLine(k);
            }
            //ForEach Loop :It is better when we iterate something
            int[] arr=new int[] {1,2,3,4,5,6,7};
            foreach(int item in arr)
            {
                Console.WriteLine(item);
            }
        }
        public void ContinueAndBreak()
        {
            //Continue :Continue statement end the loop iteration and transfer the control to the beginning of the loop
            for (int i=0; i<5; i++)
            {
                if(i == 3)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
            //Break : Break statement end the loop iteration and exit the loop
            for(int l=0; l<5; l++)
            {
                if (l == 3)
                {
                    break;
                }
                Console.WriteLine(l);
            }
        }
        public void AlternateOfNestedIFElseStatement()
        {
            //Switch
            string lavel = "SE";
            int salary = 0;
            switch(lavel)
            {
                case "SE":
                    salary = 7000;
                    break;
                case "SD":
                    salary = 5000;
                    break;
                case "WD":
                    salary = 6000;
                    break;

            }
            Console.WriteLine(salary);
            //Ternary Operator ?
            salary = lavel == "SE" ? 7000 : lavel == "WD" ? 10000 : 150000;
            Console.WriteLine(salary);
        }
        public void ExecptionHandling()
        {
            //It used to manage errors
            try
            {
                int i = 0;
                int j = 0;
                int k = i / j;
                //Try block is a block of code inside which any error can occure.
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                //Catch block it passed to cath block to handle it
            }
            finally
            {
                Console.WriteLine("Finally");
                //Finally block mostly used to dispose the unwanted objects when they are no more required.
                //This is good for performance, otherwise you have to wait for garbage collection to dispose them
                //Finally block is used to execute a given set of statements , whether an exception occure or not
            }
            //Without catch block
            try
            {

            }
            finally
            {

            }
            //Finally is used exception handling.
            //Finalize is a mwethod which is automatically called by the garbage collection to dispose no longer needed objects.

        }
        // //Throw ex and throw
        public void DivideZero()
        {
            try
            {
                Divedent();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }
        public void Divedent()
        {
            try
            {
                int i = 0;
                int j = 0;
                int k = i / j;

            }
            catch(Exception ex)
            {
                //throw ex;//Throw ex will change the stack trace, where as throw will preserve the whole stack trace
                throw;//Lock the right point
            }
        }

    }
}
