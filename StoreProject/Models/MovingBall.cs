using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Web;

namespace StoreProject.Models
{
    public class MovingBall
    {
        public double GetCurrentSpeed(double distance, double time)
        {
            if(time == 0)
                throw new DivideByZeroException();
            return distance/time;
        }
    }
}