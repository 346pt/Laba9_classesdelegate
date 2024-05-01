public class Washer
{
    public void Wash(Car car)
    {
        car.Clean = true;
        Console.WriteLine($"Автомобиль {car.Name} чистенький");
    }
}