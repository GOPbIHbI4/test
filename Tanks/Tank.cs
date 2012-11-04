using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tanks
{
    public abstract class Tank : ApplicationObject,IMoveable //абстрактный класс-танк
    {
        protected int wheelState;

        public int getWheelState
        {
            get { return wheelState; }
        }

        public void fire(Direction direction) //стрелять
        {
            throw new NotImplementedException();
        }

        public void move(Direction direction) //далее - реализация IMoveable 
        {
            if (direction == Direction.no)
            {
                return;
            }
            if (this.direction == direction)
            {
                if (direction == Direction.down)
                {
                    this.y++;
                    this.wheelState = (this.wheelState + 1) % 8;
                    return;
                }
                if (direction == Direction.up)
                {
                    this.y--;
                    this.wheelState = (this.wheelState + 1) % 8;
                    return;
                }
                if (direction == Direction.left)
                {
                    this.x--;
                    this.wheelState = (this.wheelState + 1) % 8;
                    return;
                }
                if (direction == Direction.right)
                {
                    this.x++;
                    this.wheelState = (this.wheelState + 1) % 8;
                    return;
                }
            }
            else
            {
                this.direction = direction;
            }
        }

        public void rollBack(Direction direction)
        {
            throw new NotImplementedException();
        }
    }
}
