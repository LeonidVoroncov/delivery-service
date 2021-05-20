using System;

public class PriceCalculatorSimpleFirm : IConcreteCalculator
{
    public bool IsSuitable(Client client)
        => client is SimpleFirm;

    public int CalculatePrice(Client client)
    {
        SimpleFirm simpleFirm = (SimpleFirm)client;

        return simpleFirm.Price + simpleFirm.Box.PriceBox;
    }
}
