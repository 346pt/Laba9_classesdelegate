public class Car
{
    public string Name { get; set; }
    public bool Clean { get; set; } = false;

    public Car(string name)
    {
        Name = name;
    }
}
