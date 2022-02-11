using System;
abstract class TimeConverter
{
    public abstract void Hours();

}
class HoursConverter : TimeConverter
{
    public override void Hours()
    {
        Console.WriteLine("Enter minutes:");
        double minutes = Convert.ToDouble(Console.ReadLine());
        double minutesToHours = minutes * 0.0167;
        Console.WriteLine(minutesToHours + " Hours");
        Console.WriteLine("Enter seconds");
        double seconds = Convert.ToDouble(Console.ReadLine());
        double secondsToHours = seconds * 0.000278;
        Console.WriteLine(secondsToHours + " Hours");
    }
}
class MinutesConverter : HoursConverter
{
    public void Minutes()
    {
        Console.WriteLine("Enter hours");
        double hours = Convert.ToDouble(Console.ReadLine());
        double hoursToMinutes = hours * 60;
        Console.WriteLine(hoursToMinutes + " Minutes");
        Console.WriteLine("Enter seconds");
        double seconds = Convert.ToDouble(Console.ReadLine());
        double secondsToMinutes = seconds * 0.0167;
        Console.WriteLine(secondsToMinutes + " Minutes");
    }
}
class SecondsConverter : MinutesConverter
{
    public void Seconds()
    {
        Console.WriteLine("Enter Minutes:");
        double minutes = Convert.ToDouble(Console.ReadLine());
        double minutesToHours = minutes * 60;
        Console.WriteLine(minutesToHours + " Seconds");
        Console.WriteLine("Enter hours");
        double hours = Convert.ToDouble(Console.ReadLine());
        double hoursToSeconds = hours * 3600;
        Console.WriteLine(hoursToSeconds + " Seconds");
    }
}
class FinalConverter
{
    public static void Main(String[] args)
    {
        SecondsConverter obj = new SecondsConverter();
        int choice, ch;
        do
        {
            Console.WriteLine("Time Converter");
            Console.WriteLine("1.Hours\n2.Minutes\n3.Seconds");
            choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    obj.Hours();
                    break;
                case 2:
                    obj.Minutes();
                    break;

                case 3:
                    obj.Seconds();
                    break;

            }
            Console.WriteLine("Enter 0 to quit and 1 to continue:");
            ch = int.Parse(Console.ReadLine());
        } while (ch == 1);

    }
}


