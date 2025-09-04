using System;
public class Vehicle
{
    public string Brand { get; set; }
    public int Year { get; set; }
    public DateTime LastDate { get; set; }
    public string Model { get; set; }

    public Vehicle(string brand, int year, DateTime lastDate, string model)
    {
        this.Brand = brand;
        this.Year = year;
        this.LastDate = lastDate;
        this.Model = model;   
    }
    
    public void StartEngine()
    {
        Console.WriteLine($"{Brand}, was started");
    }

    public void StopEngine()
    {
        Console.WriteLine($"{Brand}, stoped");
    }
}