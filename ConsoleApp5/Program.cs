using System;

class Program
{
    static void Main()
    {
        Console.Write("How many motors are carrying the packages? ");
        int motors = int.Parse(Console.ReadLine());
        
        Console.Write("How many kg of packages do we expect? ");
        double weight = double.Parse(Console.ReadLine());
        
        double maxLoadPerMotor = 5.6;
        
        double loadPerMotor = weight / motors;
        
        if (loadPerMotor <= maxLoadPerMotor)
        {
            Console.WriteLine("Yes! The conveyor belt can carry the packages.");
        }
        else
        {
            Console.WriteLine("No. The conveyor belt cannot carry the packages.");
        }
    }
}