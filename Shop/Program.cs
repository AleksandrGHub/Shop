namespace Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantityGoldsInWallet;
            int quantityCrystalsInWallet = 0;
            int quantityCrystalsInStorehouse = 1000;
            int quantityGoldsInStorehouse = 0;
            int purchasedCrystals;
            int exchangeRate = 3;
            int costcrystals;

            Console.Write("Введите начальное количесвто золота: ");
            quantityGoldsInWallet = Convert.ToInt32(Console.ReadLine());

            Console.Write("Какое количество кристаллов хотите купить: ");
            purchasedCrystals = Convert.ToInt32(Console.ReadLine());

            costcrystals = purchasedCrystals * exchangeRate;
            quantityGoldsInWallet -= costcrystals;
            quantityCrystalsInWallet += purchasedCrystals;
            quantityCrystalsInStorehouse -= purchasedCrystals;
            quantityGoldsInStorehouse += costcrystals;

            Console.WriteLine($"\nКоличество золота в кошельке: {quantityGoldsInWallet}");
            Console.WriteLine($"Количество кристалов в кошельке: {quantityCrystalsInWallet}\n");
            Console.WriteLine($"Количество золота в магазине: {quantityGoldsInStorehouse}");
            Console.WriteLine($"Количество кристалов в магазине: {quantityCrystalsInStorehouse}");
        }
    }
}