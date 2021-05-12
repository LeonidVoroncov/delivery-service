using System;

public class GoldSecret : Client
{
    public bool Filler { get; set; }

    public GoldSecret(string addres, string receiverName, int price, Box box, bool filler)
        : base(addres, receiverName, price, box)
    {
        Addres = addres;
        ReceiverName = receiverName;
        Price = price;
        Box = box;
        Filler = filler;
    }
}