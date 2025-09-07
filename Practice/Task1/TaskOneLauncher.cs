using System.ComponentModel.Design.Serialization;

public class TaskOneLauncher
{
    public void Start()
    {
        // Создаём транспортные средства
        var car1 = new Car("Toyota", DateTime.Now, "Camry", 4, "АКПП");
        var car2 = new Car("Dodge", DateTime.Now, "Challenger", 2, "МКПП");
        var moto1 = new Motorcycle("Dodge", DateTime.Now, "Tomahawk", "Prototype", false);

        // Создаём гаражи
        var garage1 = new Garage();
        var garage2 = new Garage();

        // Добавляем транспортные средства в гаражи
        garage1.AddVehicle(car1);
        garage1.AddVehicle(moto1);
        garage2.AddVehicle(car2);

        // Создаём автопарк
        var fleet = new Fleet();
        fleet.AddGarage(garage1);
        fleet.AddGarage(garage2);

        // Проверяем удаление транспорта и гаража
        garage1.RemoveVehicle(moto1); // удаляем мотоцикл из первого гаража
        fleet.RemoveGarage(garage2);  // удаляем второй гараж из автопарка

        fleet.ShowAllVehicle();
    }
}