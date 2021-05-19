using System;

public abstract class ColorBox : Box
{
    public override int PriceBox => 40;

    public abstract string HueBox { get; }
}
