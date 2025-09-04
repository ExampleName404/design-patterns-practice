internal class TaskOneLauncher
{
    public static void Main(string[] args)
    {
        Car MySummerCar = new Car("Dodge", 2024, DateTime.Now, "Challenger SRT Demon",2,"АКПП");
        Console.WriteLine($"{MySummerCar.Brand}, {MySummerCar.Model}, имба от {MySummerCar.Year}, когда был запрос {MySummerCar.LastDate}, количество дверей: {MySummerCar.AmountOfDoor}, Тип коробки: {MySummerCar.TransmissionType}");
        MySummerCar.StartEngine();
    }
}