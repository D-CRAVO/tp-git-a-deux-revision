public class Car{
    public string? Brand {get; set;}
    public string? Model {get; set;}

    public Car(string? _brand, string? _model){
        this.Brand = _brand;
        this.Model = _model;
    }

    public override string ToString(){
        return $"La voiture a pour marque {Brand} et pour modèle {Model}";
    }
}