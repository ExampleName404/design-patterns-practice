public class TaskOneLauncher
{
    public void Start()
    {
        Car MySummerCar = new Car("Dodge", DateTime.Now, "Challenger SRT Demon", 2, "АКПП");
        MySummerCar.ShowInfo();
        MySummerCar.StartEngine();

        Motorcycle MyMotorCycle = new Motorcycle("Dodge", DateTime.Now, "Tomahawk", "Prototype", false);
        MyMotorCycle.ShowInfo();
        MyMotorCycle.StartEngine();
    }
}