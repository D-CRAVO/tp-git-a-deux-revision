using System.ComponentModel;

string? BrandUser;
string? ModelUser;
CarContainer carContainer = new CarContainer();

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