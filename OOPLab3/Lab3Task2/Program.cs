using System;

class Program {
    static void Main(){
        Person a = new Person();
        Person b = new Person(18);
        Person c = new Person("Stamat", 43);
        a.output();
        b.output();
    }

    class Person{
        public string name;
        public int age;
        public Person(){
            this.name = "No name";
            this.age = 1;
        }
        public Person(int age){
            this.name = "No name";
            this.age = age;
        }
        public Person(string name, int age){
            this.name = name;
            this.age = age;
            Console.WriteLine($"Name: {name}, Age: {age}");
        }
        public void output(){
            Console.WriteLine($"Name: {name}, Age: {age}");
        }
    }
    
}