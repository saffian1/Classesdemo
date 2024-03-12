namespace CargoShip;

 internal class Program
 {
     static void Main(string[] args)
     {
        Car car1 = new Car("audi", "s3", 1000, 17000);
        Car car2 = new Car("bmw", "m3", 15000, 25000);
        Car car3 = new Car("mercedes", "e63s", 9000, 45000);
        var carsForShip = new List<Car>();
        carsForShip.Add(car1);
        Ship ship1 = new Ship ("Titanic", "Newfoundland", 3547, carsForShip);

        foreach (Car car in carsForShip)
        {
          Console.WriteLine(car);
        }
       
        //1. Create a empty list called carsForShip
        //2. Add car1 to your list
        //3. Fix your new Ship (12) so rather than passing a single car, you pass in your list.
        //3a. Add more cars to the list/ship.
        //4. Console log out all the car models on your ship.
       
        //create a for loop that would iterate to fetch and return all the models within the cars list
        //List that can store car objects, list name is "Allcars"
        //List<Cars> Allcars = new List<Cars>();
        //car objects
        //adding car objects to the list
        //Allcars.Add(new Car());
       // AddCar();
     }
 };