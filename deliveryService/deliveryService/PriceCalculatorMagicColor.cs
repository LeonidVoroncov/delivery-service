using System;

public class PriceCalculatorMagicColor : IConcreteCalculator
{
    public bool IsSuitable(Client client)
        => client is MagicColor;

    public int CalculatePrice(Client client)
    {
        MagicColor magicColor = (MagicColor)client;

        return magicColor.Price + magicColor.Box.PriceBox + magicColor.Tape.PriceTape;
    }
}
