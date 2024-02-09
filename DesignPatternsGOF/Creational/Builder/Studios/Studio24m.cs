﻿namespace DesignPatternsGOF.Creational.Builder.Studios
{
    public class Studio24m : Studio
    {
        public override void SetFloor(string floor)
        {
            Floor = floor;
        }

        public override void SetFinancing(string financing)
        {
            Financing = financing;
        }

        public override void SetValue(decimal value)
        {
            Value = value;
        }
    }
}
