using System;

namespace deliveryService
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new Client[]
            {
                new GoldSecret("Адрес1", "Имя1", 120, new DenseBox(), true),
                new Client("Адрес2", "Имя2", 120, new RegularBox()),
                new MagicColor("Адрес3", "Имя3", 120, new ColorBox.RedBox(), new ColorTape.BlueTape()),
            };

            var calc = new PriceCalculator();

            foreach(var clients in client)
            {
                Console.WriteLine(clients.Id);

                if (clients is MagicColor)
                {
                    Console.WriteLine(calc.CalculatorMagicColor((MagicColor)clients));
                }
                else if (clients is GoldSecret)
                {
                    Console.WriteLine(calc.CalculatorGoldSecret((GoldSecret)clients));
                }
                else
                {
                    Console.WriteLine(calc.Calculator(clients));
                }
            }

            Console.ReadKey();
        }
    }
}
