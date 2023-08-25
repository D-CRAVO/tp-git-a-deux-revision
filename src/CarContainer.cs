public class CarContainer
{
    private List<Car>? myCarList;

    public CarContainer()
    {
        myCarList = new List<Car>();
    }

    public List<Car> AddCar(Car _car){
        Car? car = myCarList.FirstOrDefault(c => c.Brand == _car.Brand && c.Model == _car.Model);
        if(car is Car)
        {
            Console.WriteLine("Cette voiture existe déjà.");
        }
        else
        {
            myCarList.Add(_car);
            Console.WriteLine("Enregistrement effectué");
        }
        return myCarList;
    }

    public override string ToString()
    {
        string myCarListString = "Votre liste de voiture : " + Environment.NewLine;
        foreach(Car car in myCarList)
        {
            myCarListString += car.ToString() + Environment.NewLine;
        }
        return myCarListString;
    }
}