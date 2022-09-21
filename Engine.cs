public class Engine
{
    public int _power;
    public string _creator;
    public Engine(int power, string creator)
    {
        _creator = creator;
        _power = power;
    }
    public override string ToString()
    {
        return _power +" "+ _creator;
    }
}