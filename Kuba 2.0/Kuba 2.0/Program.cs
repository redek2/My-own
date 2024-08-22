public class MyProgram
{
    public static void Main(string[] args)
    {

        Console.WriteLine("Siema pedały\n");
        string poprawione = "";
        int x = 0;

        while (x == 0)
        {
            string znaki = Console.ReadLine();
            Console.WriteLine();

            foreach (char a in znaki)
            {
                if (char.IsLetter(a))
                {

                }
                else if (char.IsDigit(a))
                {
                    poprawione += a;
                }
                else if (char.IsPunctuation(a))
                {

                }
            }

            if (znaki == "amen")
            {
                x = 1;
            }
            else
            {
                poprawione = poprawione + "_4";
                Console.WriteLine(poprawione + "\n");
                znaki = string.Empty;
                poprawione = string.Empty;
            }
        } 
    }
}