class Ship {
    public string name;
    public string location;
    private int capacity;
    private List<Car> cars;
    //List<Car> Allcars = new List<Car>();

    public Ship (string aName, string aLocation, int aCapacity, List<Car> aCars)
    {
        name = aName;
        location = aLocation;
        capacity = aCapacity;
        cars = aCars;
    }

    public void AddCar (string value) 
    {
            
    }

};