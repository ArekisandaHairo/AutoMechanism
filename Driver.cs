public class Driver
{
    private string _name;
    private int _driveExp;
    public Driver(string name, int driveExp)
    {
        _driveExp = driveExp;
        _name = name;
    }

    public override string ToString()
    {
        return _name +" "+ _driveExp;
    }

    
}