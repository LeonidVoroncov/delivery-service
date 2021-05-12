using System;

public class MagicColor : Client
{
    public Tape Tape { get; set; }

    public MagicColor(string addres, string receiverName, int price, Box box, Tape tape)
        : base(addres, receiverName, price, box)
    {
        Addres = addres;
        ReceiverName = receiverName;
        Price = price;
        Box = box;
        Tape = tape;
    }
}
