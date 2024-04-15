using Class06.Exercises.Entites;
using Class06.Exercises.Helpers;
using System.Security.Cryptography;





//1) Filter all cars that have origin from Europe.
Console.WriteLine("1) All cars that have origin from Europe.");
List<Car> originEurope = CarsData.Cars.Where(c => c.Origin == "Europe").ToList();
originEurope.PrintEntities();
Console.ReadLine();


//2) Find all unique cylinder values for cars.
Console.WriteLine("2) All unique cylinder values for cars.");
/*List<Car> uniqueCylinderValues = CarsData.Cars.DistinctBy(c => c.Cylinders).ToList();
uniqueCylinderValues.PrintEntities();*/
var uniqueCylinderValues = CarsData.Cars.DistinctBy(c => c.Cylinders).Select(a => $"Car model: {a.Model} - {a.Cylinders} cylinders").ToList();
uniqueCylinderValues.PrintSimple();
Console.ReadLine();


//3) Select all car model names with their model names converted to uppercase.
Console.WriteLine("3) All car model names with their model names converted to uppercase.");
var modelNamesUpper = CarsData.Cars.Select(c => $"{c.Model.ToUpper()}").ToList();
modelNamesUpper.PrintSimple();
Console.ReadLine();


//4) Check if there are any cars with horsepower greater than 300.
Console.WriteLine("4) Checking if there are any cars with horsepower greater than 300..");
bool isCarsWithHorsepowerUp300 = CarsData.Cars.Any(c => c.HorsePower > 300);
var carsWithHorsepowerUp300 = isCarsWithHorsepowerUp300 ? "There is car/s with horsepower greater than 300." : "There is not such a cars.";
Console.WriteLine(carsWithHorsepowerUp300);
Console.ReadLine();


//5) Find the car with the highest horsepower.
Console.WriteLine("5) The car with the highest horsepower.");
Car carHighestHorsepower = CarsData.Cars.OrderByDescending(c => c.HorsePower).FirstOrDefault();
Console.WriteLine(carHighestHorsepower.GetInfo());
Console.ReadLine();


//6) Filter all "Chevrolet" cars and order them by weight in descending order.
Console.WriteLine("6)  All \"Chevrolet\" cars and order them by weight in descending order.");
List<Car> chevroletDescendingWeight = CarsData.Cars.Where(c => c.Model.StartsWith("Chevrolet", StringComparison.OrdinalIgnoreCase)).OrderByDescending(c => c.Weight).ToList();
chevroletDescendingWeight.PrintEntities();
Console.ReadLine();


//7) Find the car with the longest model name.
Console.WriteLine("7) The car with the longest model name.");
Car longestModelName = CarsData.Cars.OrderByDescending(c => c.Model.Length).FirstOrDefault();
Console.WriteLine(longestModelName.GetInfo());
Console.ReadLine();


//8) Group cars by their origin and then order the groups by the number of cars in each group, in ascending order.
Console.WriteLine("8) Grouping cars by their origin and then order the groups by the number of cars in each group, in ascending order..");
List<Car> cars = CarsData.Cars;
   var groupOriginNumberAscending = cars.GroupBy(c => c.Origin).OrderBy(g => g.Count());
List<Car> groupOriginNumberAscending1 = groupOriginNumberAscending.SelectMany(group => group.ToList()).ToList();
groupOriginNumberAscending1.PrintEntities();
Console.ReadLine();


//9) Find the first 5 cars with the highest horsepower. (hint: read about LINQ methods Skip() and Take())
Console.WriteLine("9) The first 5 cars with the highest horsepower.");
List<Car> first5HighestHorsepower = CarsData.Cars.OrderByDescending(c => c.HorsePower).Take(5).ToList();
first5HighestHorsepower.PrintEntities();
Console.ReadLine();


//10) Find the car with the highest acceleration time.
Console.WriteLine("10) The car with the highest acceleration time.");
Car highestAccelerationTime = CarsData.Cars.OrderByDescending(c => c.AccelerationTime).FirstOrDefault();
Console.WriteLine(highestAccelerationTime.GetInfo());
Console.ReadLine();


//11) Select only the model and horsepower of cars with horsepower greater than 200. 
Console.WriteLine("11) Selecting only the model and horsepower of cars with horsepower greater than 200..");
var modelHorsepowerwithHPgreaterThan200 = CarsData.Cars.Where(c => c.HorsePower > 200).Select(c => $"Car model: {c.Model} - HorsePower: {c.HorsePower}").ToList();
modelHorsepowerwithHPgreaterThan200.PrintSimple();
Console.ReadLine();


//12) Select all unique origins of cars, ordered alphabetically (ascending).
Console.WriteLine("12) Selecting all unique origins of cars, ordered alphabetically (ascending)..");
var iniqueOriginsAscendingAlpha = CarsData.Cars.DistinctBy(c => c.Origin).OrderBy(c => c.Origin).Select(c => c.Origin).ToList();
iniqueOriginsAscendingAlpha.PrintSimple();
Console.ReadLine();


//13) Selecting all cars with more than 4 cylinders, and order them by origin and then by horsepower. 
Console.WriteLine("13) Selecting all cars with more than 4 cylinders, and order them by origin and then by horsepower.. ");
List<Car> moreThan4CylindersOriginHorsepower = CarsData.Cars.Where(c => c.Cylinders > 4).OrderBy(c => c.Origin).ThenBy(c => c.HorsePower).ToList();
moreThan4CylindersOriginHorsepower.PrintEntities();
Console.ReadLine();


//14) Filter all cars that have more than 6 Cylinders not including 6 after that Filter all cars that have exactly 4 Cylinders and have HorsePower more then 110.0. Join them in one result.
Console.WriteLine("14) Filtering all cars that have more than 6 Cylinders not including 6 after that Filtering all cars that have exactly 4 Cylinders and have HorsePower more then 110.0, in one result.");
List<Car> moreThan6 = CarsData.Cars.Where(c => c.Cylinders > 6).ToList();
List<Car> cylinders4HorsepowerMore110 = CarsData.Cars.Where(c => c.Cylinders == 4 && c.HorsePower > 110.0).Concat(moreThan6).ToList();
cylinders4HorsepowerMore110.PrintEntities();
Console.ReadLine();


//15) Filter all cars that have more then 200 HorsePower and Find out how much is the lowest, highest and average Miles per galon for these cars.
Console.WriteLine("15) Filtering all cars that have more then 200 HorsePower and Find out how much is the lowest, highest and average Miles per galon for these cars.");
List<Car> moreThan200Horsepower = CarsData.Cars.Where(c => c.HorsePower > 200).ToList();
Console.WriteLine($"Lowest Miles per galon is:{moreThan200Horsepower.Min(c => c.MilesPerGalon)}");
Console.WriteLine($"Highest Miles per galon is:{moreThan200Horsepower.Max(c => c.MilesPerGalon)}");
Console.WriteLine($"Average Miles per galon is:{moreThan200Horsepower.Average(c => c.MilesPerGalon)}");
Console.ReadLine();


//16) Be creative and write requirement of your own choice :) (only one catch, must use at least 3 LINQ methods) 
Console.WriteLine("16) Select last 10 cars with origin from Europe, order by model length descending.");
List<Car> example = CarsData.Cars.Where(c => c.Origin == "Europe").TakeLast(10).OrderByDescending(c => c.Model.Length).ToList();
example.PrintEntities();
Console.ReadLine();


//17) Be creative and write requirement of your own choice :) (only one catch, must use at least 3 LINQ methods)
Console.WriteLine("17) Select cars without cars with 0 milesPerGalon excep, then odrer them acording horsepower ascending, but without 7 with lowest horsepower.");
List<Car> example2 = CarsData.Cars.Except(CarsData.Cars.Where(c => c.MilesPerGalon == 0)).OrderBy(c => c.HorsePower).Skip(7).ToList();
example2.PrintEntities();
Console.ReadLine();
