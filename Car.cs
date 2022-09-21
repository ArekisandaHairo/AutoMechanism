public class Car
{
    public string _mark;
    public string _type;
    public double _weight;
    private Engine engine;
    private Driver driver;
    public Car(string mark, string type, double weight, Engine engine, Driver driver)
    {
        _mark = mark;
        _type = type;
        _weight = weight;
        this.engine = engine;
        this.driver = driver;
    }
    public void Start()
    {
        Console.WriteLine("Поехали!");
    }
    public void Stop()
    {
        Console.WriteLine("Остановка!");
    }
    public void TurnRight()
    {
        Console.WriteLine("ВПРАВО!");
    }
    public void TurnLeft()
    {
        Console.WriteLine("ВЛЕВО!");
    }
    public override string ToString()
    {
        return _mark +" "+ _type +" "+ _weight;
    }
}