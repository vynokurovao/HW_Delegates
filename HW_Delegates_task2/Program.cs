using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Delegates_task2
{
    class Program
    {
        private const int GeneratorsQuantity = 100;
        private const int MaxValue = 42;
        private delegate int Generator();
        private delegate int Averager(List<Generator> generators);

        static void Main(string[] args)
        {
            List<Generator> generators = new List<Generator>();
            Random random = new Random();
            
            for (int i = 0; i < GeneratorsQuantity; i++)
            {
                int randomInt = random.Next(MaxValue);
                generators.Add(delegate() { return randomInt; });
            }

            Averager averager = delegate(List<Generator> generatorsList)
            {
                if (generatorsList.Count == 0)
                {
                    return 0;
                }

                int sum = 0;
                foreach (Generator generator in generatorsList)
                {
                    sum += generator();
                }

                return sum / generatorsList.Count;
            };

            Console.WriteLine(averager(generators));
            Console.ReadKey();
        }
    }
}
