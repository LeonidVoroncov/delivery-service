using System;

public class PriceCalculatorMagicColor : IConcreteCalculator
{
    public bool IsSuitable(Client client) 
        => client is MagicColor;

    public int CalculatePrice(Client client) 
        => client.Price + client.Box.PriceBox + client.Tape.PriceTape;
}
