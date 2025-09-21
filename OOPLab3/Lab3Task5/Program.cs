using System;
using System.Collections.Generic;
using System.Globalization;


class Program{
    static void Main(){
        List<Car> cars = new List<Car>();
        Console.WriteLine("Enter number of cars: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter model, fuel amount and fuel consumption: ");
        for (int i = 0; i < n; i++){
            string[] input = Console.ReadLine().Split(' ');
            string model = input[0];
            float amount = float.Parse(input[1]);
            float consumption = float.Parse(input[2]);
            
            Car car = new Car(model, amount, consumption);
            cars.Add(car);
        }

        while (true){
            Console.WriteLine("Enter commands: ");
            string command = Console.ReadLine();
            if (command == "End"){
                for (int i = 0; i < cars.Count; i++)
                    cars[i].output();
                break;
            }
                
            
            string[] act = command.Split(' ');
            string action = act[0];

            if (action == "Drive"){
                string model = act[1];
                float km =  float.Parse(act[2]);

                for (int i = 0; i < n; i++){
                    if (cars[i].model == model)
                        cars[i].Drive(km);
                }
            }
        }
    }    
}

class Car{
    public string model;
    public float fuelAmount;
    public float fuelConsumption;
    public float driven;

    public Car(string model, float fuelAmount, float fuelConsumption){
        this.model = model;
        this.fuelAmount = fuelAmount;
        this.fuelConsumption = fuelConsumption;
        this.driven = 0;
    }

    public void Drive(float km){
        float fueltodrive = km * fuelConsumption;

        if (fueltodrive <= fuelAmount){
            Console.WriteLine($"{model} drove {km} km");
            fuelAmount -= fueltodrive;
            driven += km;
        }
        else{
            Console.WriteLine("Not enough fuel");
        }
    }

    public void output(){
        Console.WriteLine($"{model} {fuelAmount:F2} {driven}");

    }
}