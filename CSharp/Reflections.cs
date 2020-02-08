using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace reflections
{
    class Program
    {
        static void Main(string[] args)
        {
            //reflection in .NET is all about knowing the various types, their methods, functions, return types,
            //as well as parameters information contained in that application during  run time

            //all the reflection related classes are available in the namespace System.Reflection

            Assembly assembly = Assembly.Load("Employeecomponent");

            Type[] types = assembly.GetTypes();

            foreach (Type type in types)
            {
                Console.WriteLine("Base Type: {0}", type.BaseType);
                Console.WriteLine("Name:{0}", type.Name);

                MethodInfo[] methods = type.GetMethods();



                foreach (MethodInfo method in methods)
                {
                    Console.WriteLine("Method name:{0}", method.Name);
                    Console.WriteLine("Return type:{0}", method.ReturnType);



                    ParameterInfo[] parameters = method.GetParameters();

                    foreach (ParameterInfo param in parameters)
                    {
                        Console.WriteLine("Parameter name:{0}", param.Name);
                        Console.WriteLine("Parameter type:{0}", param.ParameterType);

                        Console.WriteLine(".......................................");

                    }


                    Console.WriteLine(".......................................");
                }

                Console.WriteLine(".......................................");
            }
           
        }
    }
        
}
