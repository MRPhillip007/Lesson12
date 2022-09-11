using ConsoleApp1;

class Program 
{
    static void Main()
    {
        Bmw bmwx7 = new Bmw("BmvX7", 12, "Pink", "Blue");
        Console.WriteLine("Модель: " + bmwx7.Model);
        Console.WriteLine("Объем двигателя: " + bmwx7.EngineVolume);
        Console.WriteLine("Цвет дисков: " + bmwx7.WheelColor);
        Console.WriteLine("Цвет машины: " + bmwx7.VehicleColor);
        bmwx7.StartEngine();
        bmwx7.Drive();

        AutoService autoService = new AutoService();
        autoService.Repair(bmwx7);
    }
}
//checked
