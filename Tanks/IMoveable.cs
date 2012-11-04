using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tanks
{
    interface IMoveable //двигающийся объект
    {
        void move(Direction direction);//пытается подвинуть объект

        void rollBack(Direction direction);//откатывает попытку перемещения, если объект наехал на препятствие 
    }
}
