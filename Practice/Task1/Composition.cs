public class Garage
{
    public List<Vehicle> Vehicles { get; } = new List<Vehicle>();

    public void AddVehicle(Vehicle vehicle) => Vehicles.Add(vehicle);
    public void RemoveVehicle(Vehicle vehicle) => Vehicles.Remove(vehicle);
}

public class Fleet
{
    public List<Garage> Garages { get; } = new List<Garage>();

    public void AddGarage(Garage garage) => Garages.Add(garage);
    public void RemoveGarage(Garage garage) => Garages.Remove(garage);

    public Vehicle? FindVehicle(string brand)
    {
        foreach (var garage in Garages)
        {
            foreach (var vehicle in garage.Vehicles)
            {
                if (vehicle.Brand == brand)
                {
                    return vehicle;
                }
            }
        }
        return null;
    }

    public void ShowAllVehicle()
    {
        foreach (var garage in Garages)
        {
            foreach (var vehicle in garage.Vehicles)
            {
                Console.WriteLine($"ТС которые нахоядтся в гараже: Бренд {vehicle.Brand} Модель {vehicle.Model} \n");
            }
        }
    }
}