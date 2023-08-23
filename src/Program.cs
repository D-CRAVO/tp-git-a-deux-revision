using System.ComponentModel;

string? BrandUser;
string? ModelUser;

Console.WriteLine("Veuillez saisir la Marque et le Modèle de la voiture.");
Console.Write("Marque : "); 
BrandUser = Console.ReadLine();
Console.Write("Modèle : ");
ModelUser = Console.ReadLine();
Console.WriteLine($"La voiture a pour Marque {BrandUser} et pour modèle {ModelUser}");

Car myCar = new Car(BrandUser, ModelUser);
Console.WriteLine(myCar.ToString());

CarContainer carContainer = new CarContainer();
carContainer.AddCar(myCar);
Console.WriteLine(carContainer.ToString());