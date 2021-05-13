using System;

public class PriceCalculator
{
    public int CalculatorMagicColor(MagicColor client)
    {
        return client.Price + client.Box.PriceBox + client.Tape.PriceTape;
    }

    public int CalculatorGoldSecret(GoldSecret client)
    {
        if (client.Filler == true)
        {
            return client.Price + client.Box.PriceBox + 45;
        }
        return client.Price + client.Box.PriceBox;
    }

    public int Calculator(Client client)
    {
        return client.Price + client.Box.PriceBox;
    }
}
