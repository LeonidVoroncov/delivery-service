using System;

public class PriceCalculatorGoldSecret : IConcreteCalculator
{
    public bool IsSuitable(Client client)
        => client is GoldSecret;

    public int CalculatePrice(Client client)
    {
        if (client.Filler == true)
        {
            return client.Price + client.Box.PriceBox + 45;
        }
        return client.Price + client.Box.PriceBox;
    }       
}