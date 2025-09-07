

using System.Diagnostics;
using System;

internal class Program
{
    public static void Main(string[] args)
    {
        // var init
        string ?CurrentTaskNumber;
        var launcher = new TaskOneLauncher();

        Console.WriteLine("Номер задания от 0 до ");
        CurrentTaskNumber = Console.ReadLine();

        switch (Convert.ToInt32(CurrentTaskNumber))
        {
            case 1:
                {
                    Console.WriteLine("Correct ");
                    break;
                }
            default:
                Console.WriteLine("Incorrect number");
                break;
        }
        
    }
}