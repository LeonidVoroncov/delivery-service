using System;

public abstract class ColorTape : Tape
{
    public override int PriceTape => 15;

    public abstract string HueTape { get; }

    public class RedTape : ColorTape
    {
        public override string HueTape => "Red";
    }

    public class YellowTape : ColorTape
    {
        public override string HueTape => "Yellow";
    }

    public class BlueTape : ColorTape
    {
        public override string HueTape => "Blue";
    }
}

