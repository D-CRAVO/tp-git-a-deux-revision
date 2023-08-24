public class CarContainer
{
    private List<Car>? myCarList;

    public CarContainer()
    {
        myCarList = new List<Car>();
    }

    public List<Car> AddCar(Car car){
        myCarList.Add(car);
        return myCarList;
    }

    public override string ToString()
    {
        string myCarListString = "Votre liste de voiture contient" + Environment.NewLine;
        foreach(Car car in myCarList)
        {
            myCarListString += car.ToString() + Environment.NewLine;
        }
        return myCarListString;
    }
}