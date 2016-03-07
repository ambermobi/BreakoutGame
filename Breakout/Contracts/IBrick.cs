﻿namespace Breakout.Contracts
{
    public interface IBrick
    {
        int PositionX { get; set; }

        int PositionY { get; set; }

        char getSymbol();

        void setInvisible();

        bool getVisibility();
    }
}
