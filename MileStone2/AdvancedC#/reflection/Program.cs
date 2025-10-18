// See https://aka.ms/new-console-template for more information
using System;
using System.Reflection;

class Program
{
    static void Main(string[] args)
    {
        // Load the current assembly
        Assembly assembly = Assembly.GetExecutingAssembly();

        // 1. Assembly Information
        Console.WriteLine("*** Assembly Name: " + assembly.FullName);

        // 2. Module Information
        foreach (Module module in assembly.GetModules())
        {
            Console.WriteLine("*** Module Name: " + module.Name);

            // 3. Class Information
            foreach (Type type in module.GetTypes())
            {
                Console.WriteLine("****** Class Name: " + type.Name);

                // 4. Constructors Information
                foreach (ConstructorInfo ctor in type.GetConstructors())
                {
                    var parameters = ctor.GetParameters();
                    Console.Write("******** Constructor: " + ctor.Name + "(");
                    for (int i = 0; i < parameters.Length; i++)
                    {
                        Console.Write(parameters[i].ParameterType.Name + " " + parameters[i].Name);
                        if (i < parameters.Length - 1) Console.Write(", ");
                    }
                    Console.WriteLine(")");
                }

                // 5. Properties Information
                foreach (PropertyInfo prop in type.GetProperties())
                {
                    Console.WriteLine("******** Property: " + prop.PropertyType.Name + " " + prop.Name);
                }

                // 6. Methods Information
                foreach (MethodInfo method in type.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly))
                {
                    Console.Write("******** Method: " + method.Name + "(");
                    var parameters = method.GetParameters();
                    for (int i = 0; i < parameters.Length; i++)
                    {
                        Console.Write(parameters[i].ParameterType.Name + " " + parameters[i].Name);
                        if (i < parameters.Length - 1) Console.Write(", ");
                    }
                    Console.WriteLine(")");
                }
            }
        }
    }
}
