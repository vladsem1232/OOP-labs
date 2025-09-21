using System;
using System.Collections.Generic;
class Program{
    static void Main(){
        Family family = new Family();
        Console.WriteLine("Enter number of family members: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++){
            Console.WriteLine("Enter name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter age:");
            int age = int.Parse(Console.ReadLine());
            
            Person person = new Person(name, age);
            family.AddMember(person);
        }
        family.GetOldestMember();
    }
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
            
        }
        public void output(){
            Console.WriteLine($"Name: {name}, Age: {age}");
        }
    }

class Family{
    private List<Person> members;
    public Family(){
        members = new List<Person>();        
    }
    public void AddMember(Person a){
        members.Add(a);
    }
    public void GetOldestMember(){
        Person old = members[0];
        for (int i = 0; i < members.Count; i++){
            if (old.age < members[i].age)
                old = members[i];
        }
        Console.WriteLine($"Oldest member: {old.name}, {old.age}");
    }
}
