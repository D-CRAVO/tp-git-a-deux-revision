public class CarContainer
{
    private List<Car>? myCarList;

    public CarContainer()
    {
        myCarList = new List<Car>();
    }

    public override string ToString()
    {
        string myCarListString = "";
        foreach(Car car in myCarList)
        {
            myCarListString += car.ToString() + Environment.NewLine;
        }
        return myCarListString;
    }
}