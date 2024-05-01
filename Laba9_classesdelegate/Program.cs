class Progmram
{
    static void Main()
    {
        Garage garage = new Garage();
        garage.AddCar(new Car("Tesla"));
        garage.AddCar(new Car("Ford"));

        Washer washer = new Washer();

        garage.WashDelegate(washer.Wash);
    }
}