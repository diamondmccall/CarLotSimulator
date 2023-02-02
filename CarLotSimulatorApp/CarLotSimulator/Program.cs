using System;
using System.Collections.Generic;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            var Lot = new CarLot();

            var Ford = new Car();
            Ford.Year = 2009;
            Ford.Make = "Ford";
            Ford.Model = "Focus";
            Ford.HonkNoise = "Beep";
            Ford.EngineNoise = "Vroom";
            Ford.IsDriveable = "Yes";

            Lot.Cars.Add(Ford);

            var Infiniti = new Car()
            {
                Year = 2011,
                Make = "Infiniti",
                Model = "GS37",
                HonkNoise = "Loud",
                EngineNoise = "Quiet",
                IsDriveable = "Yes",

            };
            Lot.Cars.Add(Infiniti);

            var DreamCar = new Car(2022, "Chevrolet", "Corvette","Quiet","None","Yes");

            Lot.Cars.Add(DreamCar);

            foreach (var car in Lot.Cars)
            {
                Console.WriteLine($" Year {car.Year}, Make {car.Make}, Model {car.Model}");

            }













            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
    }
}
