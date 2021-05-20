using System;
using System.Collections.Generic;

namespace deliveryService
{
    class Program
    {
        static void Main(string[] args)
        {            
            var clients = new Client[]
            {              
                new GoldSecret("Адрес1", "Имя1", 120, new DenseBox(), true),
                new SimpleFirm("Адрес2", "Имя2", 120, new RegularBox()),
                new MagicColor("Адрес3", "Имя3", 120, new RedBox(), new RedTape()),
                new SimpleFirm("Адрес4", "Имя4", 120, new RegularBox()),
                new GoldSecret("Адрес5", "Имя5", 120, new DenseBox(), false),
            };

            var priceCalculator = new PriceCalculator(new IConcreteCalculator[]
            {
                new PriceCalculatorMagicColor(),
                new PriceCalculatorGoldSecret(),
                new PriceCalculatorSimpleFirm()
            });

            foreach (var client in clients)
            {
                Console.WriteLine(priceCalculator.CalculatePrice(client));
            }

            Console.ReadKey();
        }
    }
}