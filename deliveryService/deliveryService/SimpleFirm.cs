using System;

public class SimpleFirm : Client
{
    public SimpleFirm(string addres, string receiverName, int price, Box box)
        : base(addres, receiverName, price, box)
    {
        Addres = addres;
        ReceiverName = receiverName;
        Price = price;
        Box = box;
    }
}
