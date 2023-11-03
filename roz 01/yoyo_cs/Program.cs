using System;
using System.Linq;
using System.Reflection;

namespace yoyo_cs
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //Console.WriteLine(string.Join(",", args));
            Assembly? zestaw = Assembly.GetEntryAssembly();
            if (zestaw == null) return;

            foreach (AssemblyName nazwa in zestaw.GetReferencedAssemblies())
            {
                var a = Assembly.Load(nazwa);
                int liczbaMetod = 0;

                foreach(var t in a.DefinedTypes)
                {
                    liczbaMetod += t.GetMethods().Count();
                }

                Console.WriteLine(
                    "W zestawie {0} jest {1:N0} typów i {2:N0} metod.",
                    arg0: nazwa.Name,
                    arg1: a.DefinedTypes.Count(),
                    arg2: liczbaMetod
                );
            }

        }
    }
}
