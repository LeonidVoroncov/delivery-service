using System;

public class PriceCalculator
{
    private IConcreteCalculator[] _concreteCalculators;

    public PriceCalculator(IConcreteCalculator[] concreteCalculators)
    {
        _concreteCalculators = concreteCalculators;
    }

    public int CalculatePrice(Client client)
    {
        foreach (var concreteCalculator in _concreteCalculators)
        {
            if (concreteCalculator.IsSuitable(client))
            {
                return concreteCalculator.CalculatePrice(client);
            }
        }

        throw new ArgumentException("Неизвестная организация");
    }
}