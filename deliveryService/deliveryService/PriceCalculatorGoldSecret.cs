using System;

public class PriceCalculatorGoldSecret : IConcreteCalculator
{
    public bool IsSuitable(Client client)
        => client is GoldSecret;

    public int CalculatePrice(Client client)
    {
        GoldSecret goldSecret = (GoldSecret)client;

        if (goldSecret.Filler == true)
        {
            return goldSecret.Price + goldSecret.Box.PriceBox + 45;
        }
        return goldSecret.Price + goldSecret.Box.PriceBox;
    }       
}