namespace egz2kons
{
    internal class Program
    {
        public static int NumberOfDices = 0;
        public static int RollsSum = 0;
        public static string Repeat = "";
        static void Main(string[] args)
        {
            RollDice();
        }
        public static void RollDice()
        {
            Random random = new Random();
            Console.WriteLine("Ile kostek chcesz rzucić? (3-10)");
            NumberOfDices = int.Parse(Console.ReadLine());

            if (NumberOfDices >= 3 && NumberOfDices <= 10)
            {
                for (int i = 1; i <= NumberOfDices; i++)
                {
                    int number = random.Next(1, 7);
                    RollsSum += number;
                    Console.WriteLine("Kostka " + i + ": " + number);
                }
                Console.WriteLine("Liczba uzyskanych punktów: " + RollsSum);
                Console.WriteLine("Jeszcze raz? (t/n)");
                Repeat = Console.ReadLine();

                if (Repeat == "t")
                {
                    RollDice();
                }
            }
            else
            {
                RollDice();
            }
        }

    }
}
