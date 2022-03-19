using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_14
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            Cat сat = new Cat("Кошка", "Мяу");
            Console.WriteLine(сat.Print());
            Dog dog = new Dog("Собака", "Гав");
            Console.WriteLine(dog.Print());
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
