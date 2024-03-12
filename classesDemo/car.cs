class Car {
    private string manufacture;
    private string model;
    private int mileage;
    private int valuation;

    public Car (string myManufacture, string myModel, int myMileage, int myValuation)
    {
        manufacture = myManufacture;
        model = myModel;
        mileage = myMileage;
        valuation = myValuation;
    }
    public void SetMileage (int value)
    {
        
            if (value >= 0)
            { 
            this.mileage = value;
            }
    }         
    

    public void Drive (int value)
    {
       var updatedmileage = value + this.mileage;
       mileage = updatedmileage;
      //2nd way SetMileage (updatedmileage)
    }

    public int Getvaluation (int age)
    {
      var carvalue = age * this.mileage;
      valuation = carvalue;
      return valuation;

    }
}
    // Add a new method called get valuation. Value can be calculated by multiplying age by mileage.    
