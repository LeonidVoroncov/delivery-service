using System;

namespace deliveryService
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new Client[]
            {
                new MagicColor("Адрес3", "Имя3", 120, new RedBox(), new RedTape()),
                new GoldSecret("Адрес1", "Имя1", 120, new DenseBox(), true),
                new SimpleFirm("Адрес2", "Имя2", 120, new RegularBox()),                
            };

            var priceCalculator = new PriceCalculator(new IConcreteCalculator[]
            {
                new PriceCalculatorMagicColor(),
            });

            foreach (var clients in client)
            {

                Console.WriteLine(priceCalculator.CalculatePrice(clients));



                //if (clients is MagicColor)
                //{
                //   Console.WriteLine(calc.Calculator(clients));

                //}

                //else if (clients is GoldSecret)
                //{
                //    Console.WriteLine(calc.CalculatorGoldSecret((GoldSecret)clients));
                //}

                //else
                //{
                //    Console.WriteLine(calc.Calculator(clients));
                //}
            }

            Console.ReadKey();
        }
    }
}
