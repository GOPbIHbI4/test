using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Tanks
{
    public enum Direction {no, up, down, left, right } //направления
    public abstract class ApplicationObject //видимый объект
    {
        protected int x;
        protected int y;
        protected int width;
        protected int height;
        protected int speed;
        protected Direction direction;

        public Direction getDirection
        {
            get { return direction; }
        }

        public Point getLocation
        {
            get { return new Point(this.x, this.y); }
        }

        public void paint(Graphics g) //посещение класса Painter и отрисовка себя
        {
            Painter.paint(this, g);
        }
        public bool intersects(ApplicationObject appObj) //проверка пересечения с другим объектом в процессе движения
        {
            throw new NotImplementedException();
        }
    }
}
