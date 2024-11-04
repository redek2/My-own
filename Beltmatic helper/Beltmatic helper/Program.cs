public class BeltmaticHelper
{
    public static void Main()
    {
        double amount, production;

        Console.WriteLine("In this helper you can check how much time you have to wait until upgrade is done");
        Console.WriteLine("\nInsert how many numbers you need");
        amount = double.Parse(Console.ReadLine());
        Console.WriteLine("\nInsert how much production per second you have");
        production = double.Parse(Console.ReadLine());
        string time = Time(amount, production);
        Console.WriteLine(time);
    }

    public static string Time(double a, double p)
    {
        double sec = a / p;
        double min = a / p / 60;
        double h = a / p / 3600;

        sec = Math.Round(sec, 2);
        min = Math.Round(min, 2);
        h = Math.Round(h, 2);

        string ssec = sec.ToString();
        string smin = min.ToString();
        string sh = h.ToString();

        return $"\nSeconds left: {ssec}\nMinutes left: {smin}\nHours left: {sh}";
    }
}