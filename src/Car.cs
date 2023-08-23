public class Car{
    public string? Brand {get; set;}
    public string? Model {get; set;}

    public Car(string? _brand, string? _model){
        this.Brand = _brand;
        this.Model = _model;
    }

    public override string ToString(){
        return $"The car have for brand {Brand} and his model is {Model}";
    }
}