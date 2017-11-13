using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractAndInterface
{
    abstract class Person : Human, IAction1,IAction2
    {
        // abstract method co the khai bao duoc field
        // day la su khac biet giua interface va abstract class
        public Person()
        {

        }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public int Grade;

        public string Name { get; set; }
        public int Age { get; set; }

        public void method1()
        {
            Console.WriteLine("This is method1 of IAction1 interface");
        }

        public void method2()
        {
            Console.WriteLine("This is method2 of IAction2 interface");
        }

        public override void Eat()
        {
            Console.WriteLine("This is Eat() of Human abstract class");
        }

        public abstract void Run(); // abstract method
        //
        public void Speak() { // normal method
            // body method
        }
    }

    
}
