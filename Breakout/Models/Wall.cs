﻿namespace Breakout.Models
{
    using System;
    using Contracts;

    internal class Wall : IWall
    {
        public Wall(int height, int width, IFillingPattern pattern)
        {
            this.Height = height;
            this.Width = width;
            this.FilledWall = new IBrick[height, width];
            this.FillingPattern = pattern;
        }

        public int Height { get; }

        public int Width { get; }

        public IBrick[,] FilledWall { get; }

        public IFillingPattern FillingPattern { get; }

        public void DrawWall()
        {
            FillingPattern.FillWall(this);
        }

        public void UpdateWall()
        {
            Console.SetCursorPosition(0, 1);

            for (int i = 0; i < this.FilledWall.GetLength(0); i++)
            {
                for (int j = 0; j < this.FilledWall.GetLength(1); j++)
                {
                    Console.Write(this.FilledWall[i,j].getSymbol());
                }
            } 
        }
    }
}
