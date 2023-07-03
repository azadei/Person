using System;
using System.Security.Cryptography;
using System.Threading.Channels;

namespace ConsolePerson
{

    public class Person


{
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public decimal Weight { get; set; }
        public int Height { get; set; }

        public Person(string name, string surname, int age, decimal weight, int height)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
            this.Weight = weight;
            this.Height = height;
        }
        public override string ToString()
        {
            return Name + " " + Surname + " " + Age + " " + Weight + " " + Height;
        }



        public class Program
    {
        static void Main(string[] args)
        {

                Console.WriteLine("Name");
                string name = Console.ReadLine();
                Console.WriteLine("Surname");
                string surname = Console.ReadLine();
                Console.WriteLine("Age");
                int age = int.Parse(Console.ReadLine());
                Console.WriteLine("Weight");
                decimal weight = int.Parse(Console.ReadLine());
                Console.WriteLine("Height");
                int height = int.Parse(Console.ReadLine());

                Person per = new Person(name, surname, age, weight, height);

                Console.WriteLine(per);


            }
            
        }      
}


}
