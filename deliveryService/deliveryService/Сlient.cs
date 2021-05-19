using System;

public abstract class Client
{
    public string Addres { get; set; }

    public string ReceiverName { get; set; }

    public int Price { get; set; }

    public Box Box { get; set; }

    public Client(string addres, string receiverName, int price, Box box)
    {
        Addres = addres;
        ReceiverName = receiverName;
        Price = price;
        Box = box;
    }
}