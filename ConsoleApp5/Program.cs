using System;
class Program
{
    static void Main()
    {
        Console.Write("Hvor mange motorer bærer pakkerne? ");
        int antalmotorer = int.Parse(Console.ReadLine());

        Console.Write("Hvor mange kilo pakker forventer vi? ");
        double samletVægt = double.Parse(Console.ReadLine());

        double maksBelastning = 5.6;
        double belastningPrMotor = samletVægt / antalmotorer;

        if (belastningPrMotor <= maksBelastning)
        {
            Console.WriteLine("Ja! Transportbåndet kan bære pakkerne.");
        }
        else
        {
            Console.WriteLine("Nej. Transportbåndet kan ikke bære pakkerne.");
        }
    }
}