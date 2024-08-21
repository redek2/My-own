public class MyProgram
{
    public static void Main(string[] args)
    { 

        Console.WriteLine("Siema pedały\n");
        string znaki = Console.ReadLine();
        Console.WriteLine();
        string poprawione = "";

        foreach(char a in znaki)
        {
            if(char.IsLetter(a))
            {
                
            }
            else if(char.IsDigit(a))
            {
                poprawione += a;
            }
            else if(char.IsPunctuation(a))
            {
                
            }
        }

        poprawione = poprawione + "_4";

        Console.WriteLine(poprawione);
    }
}