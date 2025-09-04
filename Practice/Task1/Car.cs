public class Car : Vehicle
{
    // Количество дверей
    public int AmountOfDoor { get; set; }
    // Тип трансмиссии
    public string TransmissionType { get; set; }

    public Car(string brand, int year, DateTime lastDate, string model, int amountOfDoor, string transmissionType)
    : base(brand, year, lastDate, model)
    {
        this.AmountOfDoor = amountOfDoor;
        this.TransmissionType = transmissionType;
    }
}