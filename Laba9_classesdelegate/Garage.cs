public class Garage
{
    List<Car> cars = new List<Car>();

    public delegate void Washer(Car car);

    public void AddCar(Car car)
    {
        cars.Add(car);
    }

    public void WashDelegate(Washer wash)
    {
        foreach (Car car in cars)
        {
            wash(car);
        }
    }
}