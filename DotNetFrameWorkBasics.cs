using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    //CLR (Common Language Runtime): CLR manages the execution of programs for example operations like memory management security checks etc. CLR provide execution of managed code only (Code written in any .Net supported language such as C# , VB or F#)
    //CTS (Common Type System): CTS is set of rules that define how types are declared, used and managed in the .NET Framework. Type like int, string, double.
    //CLS (Common Language Specification): CLS is a subset of CTS. It defines a set of rules that every language must follow which runs under.Net framework. The benifit is if you create same program logic in different language of .Net, then the compiler will generate same dll.
    //FLC (Framework Class library): FCL is the collection of class, namespaces, interfaces and value types that are used for .Net application.
    internal class DotNetFrameWorkBasics
    {
    }
    class _Assembly
    {
        //Assembly is unit of deployment like EXE or a DLL
        //When you create a code and build the solution, then the .NET framework convert your code into intermediate language and that is placed inside the assembly (dll) ,which you can find inside bin folder.
        //3 types of assembly: Private assemble, Public assemble or shared memory and Satellite assembly.
        //Private assembly: A private assembly can be used by single application only. It is not accessible outside. So all the projects you create will by default create private assembly only.
        //Public assembly or shared memory: These are usually libraries of code, which multiple applications can use. It is registered in the global assembly cache (GAC).
        //Satellite assembly ; A satellite assembly is defined as an assembly with resources only, no executable code .
    }
    class _GAC
    {
        //GAC ( Global assembly cache)
        //GAC is the place where public assemblies are stored.
        //Private assembly can be converted into public assembly by adding then in GAC using gacutil tool.
    }
    class _Reflection
    {
        //Reflection is the ability of a code to access the metadata of the assembly during runtime.
        //Metadata is information about data.
        public static void InfoData()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            AssemblyName assemblyName=assembly.GetName();
            Version version=assemblyName.Version;
            string versionString = version.ToString();
            //Method Details
            Type type = assembly.GetType();
            MethodInfo method = type.GetMethod("MethodName");
        }
    }
}
