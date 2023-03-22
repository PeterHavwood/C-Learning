using System.Collections.Generic;
using System.Runtime.Loader;

namespace ReflectionApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Environment.CurrentDirectory);
            var folder = Path.Combine(Environment.CurrentDirectory, "Outfits");
            var files = Directory.GetFiles(folder);
            var outfitTypes = new List<Type>();

            foreach (var file in files)
            {
                var assembly = AssemblyLoadContext.Default.LoadFromAssemblyPath(file);
                var types = assembly.GetTypes();
                foreach (var type in types)
                {
                    if(type.GetMethod("Geton") != null)
                    {
                        outfitTypes.Add(type);
                    }
                }
            }

            while(true)
            {
                for(int i = 0; i < outfitTypes.Count; i++)
                {
                    Console.WriteLine($"{i+1}. {outfitTypes[i].Name}");
                }

                Console.WriteLine("Chose an outfit:");
                int index = int.Parse(Console.ReadLine()??"0");
                if(index <0 || index >= outfitTypes.Count)
                {
                    Console.WriteLine("Out of range, try again.");
                    continue;
                }

                Console.WriteLine("Chose one color:");
                string color = Console.ReadLine()??"white";

                // type是动态类型，因此没有与静态类型强耦合
                var type = outfitTypes[index-1];
                var getonMethod = type.GetMethod("Geton");
                var o = Activator.CreateInstance(type);
                getonMethod.Invoke(o, new object[] { color??"white" });
            }
        }
    }
}