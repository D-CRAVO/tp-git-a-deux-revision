public class CarContainer
{
    private List<Car>? myCarList;

    public CarContainer()
    {
        myCarList = new List<Car>();
    }

    public void AddCar(Car car)
    {
        myCarList.Add(car);
    }

    public override string ToString()
    {
        string myCarListString = "La liste de voiture :" + Environment.NewLine;
        foreach(Car car in myCarList)
        {
            myCarListString += car.ToString() + Environment.NewLine;
        }
        return myCarListString;
    }
}