public class Car : Vehicle
{
    // Количество дверей
    public int AmountOfDoor { get; set; }
    // Тип трансмиссии
    public string TransmissionType { get; set; }

    // Конструктор для записи
    public Car(string brand, DateTime lastDate, string model, int amountOfDoor, string transmissionType)
    : base(brand, lastDate, model)
    {
        this.AmountOfDoor = amountOfDoor;
        this.TransmissionType = transmissionType;
    }

    public override void ShowInfo()
    {
        base.ShowInfo();
        Console.WriteLine($"Количество дверей: {AmountOfDoor}, тип коробки {TransmissionType}");
    }
}