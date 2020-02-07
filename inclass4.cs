using System;
using System.IO;
using System.Text;
namespace ConsoleApp10
{
    class Car
    {
        string color = "red";
        int maxSpeed = 200;
        public string model;
        string col;
        int year;
        public void fullThrottle()   // method
        {
            Console.WriteLine("The car is going as fast as it can!");
        }
        public Car()
        {
            model = "Mustang";
        }
        public Car(string modelName)
        {
            model = modelName;
        }
        public Car(string modelName, string modelColor, int modelYear)
        {
            model = modelName;
            color = modelColor;
            year = modelYear;
        }
        class Person
        {
            private string name; // field
            public string Name   // property
            {
                get { return name; }
                set { name = value; }
            }
        }
        class Vehicle  // base class (parent)
        {
            public string brand = "Ford";  // Vehicle field
            public void honk()             // Vehicle method
            {
                Console.WriteLine("Tuut, tuut!");
            }
        }
        class Animal  // Base class (parent)
        {
            public virtual void animalSound()
            {
                Console.WriteLine("The animal makes a sound");
            }
        }
        class Pig : Animal  // Derived class (child)
        {
            public override void animalSound()
            {
                Console.WriteLine("The pig says: wee wee");
            }
        }
        class Dog : Animal  // Derived class (child)
        {
            public override void animalSound()
            {
                Console.WriteLine("The dog says: bow wow");
            }
        }
        abstract class Animal1
        {
            // Abstract method (does not have a body)
            public abstract void animalSound1();
            // Regular method
            public void sleep()
            {
                Console.WriteLine("Zzz");
            }
        }
        interface IAnimal
        {
            void animalSound2(); // interface method (does not have a body)
        }
        class Pig2 : IAnimal
        {
            public void animalSound2()
            {
                // The body of animalSound() is provided here
                Console.WriteLine("The pig says: wee wee");
            }
        }
        class Pig1 : Animal1
        {
            public override void animalSound1()
            {
                // The body of animalSound() is provided here
                Console.WriteLine("The pig says: wee wee");
            }
        }
        enum Level
        {
            Low,
            Medium,
            High
        }
        static void Main(string[] args)
        {
            Car myObj = new Car();
            Car myObj1 = new Car();
            Car myObj2 = new Car();
            Console.WriteLine(myObj.color);
            Console.WriteLine(myObj1.color);
            Console.WriteLine(myObj2.color);
            Console.WriteLine(myObj.maxSpeed);
            Car Ford = new Car();
            Ford.model = "Mustang";
            Ford.col = "red";
            Ford.year = 1969;
            Car Opel = new Car();
            Opel.model = "Astra";
            Opel.col = "white";
            Opel.year = 2005;
            Console.WriteLine(Ford.model);
            Console.WriteLine(Opel.model);
            Car my_1 = new Car();
            my_1.fullThrottle();
            Console.WriteLine(Ford.model);
            Car Ford1 = new Car("Mustang");
            Console.WriteLine(Ford1.model);
            Car Ford2 = new Car("Mustang", "Red", 1969);
            Console.WriteLine(Ford2.color + " " + Ford2.year + " " + Ford2.model);
            //File
            string writeText = "Hello World!";  // Create a text string
            File.WriteAllText("filename.txt", writeText); // Create a file and write the content of writeText to it
            string readText = File.ReadAllText("filename.txt");  // Read the contents of the file
            Console.WriteLine(readText);  // Output the content
            Animal myAnimal = new Animal();  // Create a Animal object
            Animal myPig = new Pig();  // Create a Pig object
            Animal myDog = new Dog();  // Create a Dog object
            myAnimal.animalSound();
            myPig.animalSound();
            myDog.animalSound();
            Pig1 my_Pig = new Pig1(); // Create a Pig object
            my_Pig.animalSound1();  // Call the abstract method
            my_Pig.sleep();
            Pig2 my2Pig = new Pig2();  // Create a Pig object
            my2Pig.animalSound2();
            Level myVar = Level.Medium;
            Console.WriteLine(myVar);
            try
            {
                int[] myNumbers = { 1, 2, 3 };
                Console.WriteLine(myNumbers[10]);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("The 'try catch' is finished.");
            }
        }
    }
}