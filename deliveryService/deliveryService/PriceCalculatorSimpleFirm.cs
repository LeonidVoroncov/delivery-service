using System;

public class PriceCalculatorSimpleFirm : IConcreteCalculator
{
    public bool IsSuitable(Client client)
        => client is SimpleFirm;

    public int CalculatePrice(Client client)
        => client.Price + client.Box.PriceBox;
}
