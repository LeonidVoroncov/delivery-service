using System;

public interface IConcreteCalculator
{
    bool IsSuitable(Client client);

    int CalculatePrice(Client client);
}