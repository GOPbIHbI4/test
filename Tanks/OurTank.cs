using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tanks
{
    public class OurTank : Tank
    {
        public OurTank()
        {
            this.x = 50;
            this.y = 50;
            this.width = 50;
            this.height = 50;
            this.wheelState = 0;
            this.speed = 5;
            this.direction = Direction.up;
        }
        //можно добавлять всякие приятные статусы типа суперпушки и т.п.
    }
}
