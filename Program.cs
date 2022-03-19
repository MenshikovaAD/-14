using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_14
{
    
     abstract class Animal
    {
       public abstract string Name{ get; set; }
         
        public  Animal (string name)
        {
            Name=name;
        }
        public abstract void Say();

        public void ShowInfo()
        {
            Console.WriteLine(Name);
            Say();
        }
       
    }
    class Cat:Animal
    {
        public string say;
        public string name;
        public override string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }
        public Cat(string name, string say)
            :base(name)
        {
            this.say = say;
            
        }
        public override void Say()
        {
            Console.WriteLine(say);
            
        }
        public string Print()
        {
            return $" Животное - {name}, говорит - {say}";
        }
    }
    class Dog : Animal
    {
        public string say;
        public string name;
        public override string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public Dog(string name, string say)
            : base(name)
        {
            this.say = say;

        }
        public override void Say()
        {
            Console.WriteLine(say);
            

        }
        public  string Print()
        {
            return $" Животное - {name}, говорит - {say}";
        }
    }
   
}

