using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleObjectExamp_le
{
    class Program
    {
        static void Main(string[] args)
        {
            Human human123 = new Human("Adam", 32);
            Human human2 = new Human("Josef", 25);
            Human human3 = new Human("Petr", 2);

            GermanHuman gehuman1 = new GermanHuman("George", 19);

            CzechHuman czhuman1 = new CzechHuman("Břetislav", 45);

            List<Human> listOfHumans = new List<Human>();

            listOfHumans.Add(human123);
            listOfHumans.Add(human2);
            listOfHumans.Add(human3);
            listOfHumans.Add(gehuman1);
            listOfHumans.Add(czhuman1);

            foreach (Human h in listOfHumans)
            {
                //h.SayName();
                h.SayGreeting();
            }

            //Array.ForEach(humans, x => x.SayName());

            Human.druh = "Homo homo homo";
            Console.WriteLine(Human.GetDruh());

            Console.ReadKey();
        }
    }

    class Human 
    {
        protected string name;
        private int age;

        public static string druh;

        public Human(string name, int age) 
        {
            this.name = name;
            this.age = age;
        }

        public static string GetDruh() 
        {
            return druh;
        }

        public void SayName() 
        {
            if (this.age > 2)
            {
                Console.WriteLine(this.name);
            }
            else Console.WriteLine("rgrtgtrgtzhs");
        }

        public virtual void SayGreeting() 
        {
            Console.WriteLine("Hi I am " + this.name);
        }
    }

    class GermanHuman : Human 
    {
        public GermanHuman(string name, int age) : base(name, age)     
        {

        }

        public override void SayGreeting() 
        {
            Console.WriteLine("Hallo ich bin " + base.name);
        }
    }

    class CzechHuman : Human
    {
        public CzechHuman(string name, int age) : base(name, age)
        {

        }

        public override void SayGreeting()
        {
            Console.WriteLine("Ahoj já jsem " + base.name);
        }
    }
}
