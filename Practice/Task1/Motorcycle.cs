using System.Security.Cryptography.X509Certificates;

public class Motorcycle : Vehicle
{
    // Тип кузова
    public string BodyType { get; set; }

    // Наличие люльки
    public bool SideCar { get; set; }

    // Переписанный конструктор
    public Motorcycle(string brand, DateTime lastDate, string model, string bodyType, bool sideCar)
    : base(brand, lastDate, model)
    {
        this.BodyType = bodyType;
        this.SideCar = sideCar;
    }

    // Перезаписанная функция для вывода атрибутов
    public override void ShowInfo()
    {
        base.ShowInfo();
        Console.WriteLine($"Тип кузова{BodyType}, Наличие люльки {SideCar}");
    }
}