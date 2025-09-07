using System;
public class Vehicle
{
    // Бренд
    public string Brand { get; set; }
    // Год выпуска
    public DateTime LastDate { get; set; }
    // Модель 
    public string Model { get; set; }

    public Vehicle(string brand, DateTime lastDate, string model)
    {
        this.Brand = brand;
        this.LastDate = lastDate;
        this.Model = model;
    }

    // Запуск двигателя
    public void StartEngine()
    {
        Console.WriteLine($"{Brand}, was started");
    }

    // Остановка двигателя

    public void StopEngine()
    {
        Console.WriteLine($"{Brand}, stoped");
    }

    // Перезаписанная функция для вывода атрибутов
    public virtual void ShowInfo()
    {
        Console.WriteLine($"{Brand}, {Model}, имба от {LastDate}");
    }
}