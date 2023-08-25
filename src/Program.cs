using System.ComponentModel;

string? BrandUser;
string? ModelUser;
CarContainer carContainer = new CarContainer();

Car car1 = new Car("Seat", "Leon");
carContainer.AddCar(car1);
Car car2 = new Car("Seat", "Cordoba");
carContainer.AddCar(car2);
Car car3 = new Car("Renault", "Kangoo");
carContainer.AddCar(car3);

do 
{
    Console.WriteLine("Veuillez saisir la Marque et le Modèle de la voiture.");
    Console.Write("Marque : "); 
    BrandUser = Console.ReadLine();
    if(BrandUser != "q")
    {
        Console.Write("Modèle : ");
        ModelUser = Console.ReadLine();
        Console.WriteLine($"La voiture a pour Marque {BrandUser} et pour modèle {ModelUser}");
        Car myCar = new Car(BrandUser, ModelUser);
        Console.WriteLine(myCar.ToString());
        carContainer.AddCar(myCar);
    }
} while (BrandUser != "q");

Console.WriteLine(carContainer.ToString());