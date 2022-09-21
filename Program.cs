//Ввод в коде
Driver tom = new Driver("Tomas", 15);
Engine e47 = new Engine(150, "Audi");
Car car = new Car("T33", "S", 3.4, e47, tom);
car.Start();
car.Stop();
car.TurnLeft();
car.TurnRight();
Console.WriteLine(car);
//Ввод с консоли
List<Car> cars = new List<Car>(); 
Console.WriteLine("Нажмите Enter что бы продолжить");
ConsoleKeyInfo consoleKey = Console.ReadKey();
int i = 0;
while( consoleKey.Key == ConsoleKey.Enter )
{
    cars.Add(new Car("","",0,e47,tom));
    Console.WriteLine("Марка");
    cars[i]._mark = Console.ReadLine();
    Console.WriteLine("Тип");
    cars[i]._type = Console.ReadLine();
    Console.WriteLine("Вес");
    cars[i]._weight = Convert.ToInt32(Console.ReadLine());
    i++;
    Console.WriteLine("Завести новую машину(Enter - Да");
    consoleKey = Console.ReadKey();
}
foreach(Car car1 in cars)
{
    Console.WriteLine(car1);
    Console.WriteLine(tom);
    Console.WriteLine(e47);
}

Console.ReadKey(true);