using System;

class Program
{
    static void Main()
    {
        Person a = new Person("Pesho", 20);
        Person b = new Person("Gosho", 18);
        Person c = new Person("Stamat", 43);
        a.output();
        b.output();
        c.output();
        
    }

    class Person
    {
        public string name;
        public int age;

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public void output(){
            Console.WriteLine($"Name: {name}, Age: {age}");
        }
    }
}