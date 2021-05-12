using System;

public abstract class ColorBox : Box
{
    public override int PriceBox => 40;

    public abstract string HueBox { get; }

    public class RedBox : ColorBox
    {
        public override string HueBox => "Red";
    }

    public class YellowBox : ColorBox
    {
        public override string HueBox => "Yellow";
    }

    public class BlueBox : ColorBox
    {
        public override string HueBox => "Blue";
    }
}
