﻿using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciate Carlot at the beginning of the program
            //and as you create a car add the car to the list.
            var lot = new CarLot();


            //DONE - Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            //Using Dot Notation
            var jaredsCar = new Car();
            jaredsCar.Make = "Ford";
            jaredsCar.Model = "Focus";
            jaredsCar.Year = 2013;
            jaredsCar.EngineNoise = "vroom";
            jaredsCar.HonkNoise = "beep";
            jaredsCar.IsDrivable = true;

            lot.Cars.Add(jaredsCar);

            //Object Initializer Syntax
            var stevesCar = new Car()
            {
                Year = 2019,
                Make = "Tesla",
                Model = "Cyber Truck",
                EngineNoise = "...",
                HonkNoise = "brmmp",
                IsDrivable = false
            };

            lot.Cars.Add(stevesCar);
            //Using the constructor to allow parameter values to be placed inside properties
            var brettsCar = new Car(2013, "Honda", "Civic", "vrrrooom", "vruuuga", true);

            lot.Cars.Add(brettsCar);


            //Call methods
            jaredsCar.MakeEngineNoise();
            stevesCar.MakeEngineNoise();
            brettsCar.MakeEngineNoise();


            //*************BONUS*************//

            // DONE - Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //DONE - Create a CarLot class
            //DONE - It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console

            foreach (var car in lot.Cars)
            {
                Console.WriteLine($"Year: {car.Year} Make: {car.Make} Model: {car.Model}");
            }
        }
    }
}
