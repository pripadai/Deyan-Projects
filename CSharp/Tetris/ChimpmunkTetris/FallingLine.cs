﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChimpmunkTetris
{
    class FallingLine : FallingObject
    {
        public FallingLine(Point2D center, Rotation rotation, char symbol, ConsoleColor color, int length)
        {
            this.Center = center;
            this.Rotation = rotation;
            this.relativeBody = new List<Pixel>();

            //Here should come the body definitions in relative to center coordinates for creating new shape!
            relativeBody.Add(new Pixel(0, 0, symbol, color));
            for (int i = 1; i < length; i++)
            {
                if (i % 2 == 0) relativeBody.Add(new Pixel((i+1)/2, 0, symbol, color));
                else relativeBody.Add(new Pixel(-(i + 1) / 2, 0, symbol, color));
            }
            

            this.Body = new List<Pixel>();
            for(int i = 0; i < relativeBody.Count; i++) Body.Add(new Pixel(0,0,'@', ConsoleColor.Gray));
            this.ReCalculateBody();
        }
    }
}
