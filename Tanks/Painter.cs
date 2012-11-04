using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Tanks
{
    public static class Painter //класс, содержащий способы отрисовки всех объектов 
    {
        private static Graphics graphics;
        public static void paint(ApplicationObject appObj,Graphics g) //решает, какой из следующих методов вызвать для отрисовки объекта
        {
            Painter.graphics = g;
            if (appObj is OurTank)
            {
                paint((OurTank) appObj);
                return;
            }
        }
        public static void paint(OurTank tank)// рисует танк
        {      
            if (tank.getDirection == Direction.up)
            {
                graphics.DrawImage(OUR_TANK_UP[tank.getWheelState], tank.getLocation);
            }
            if (tank.getDirection == Direction.down)
            {
                graphics.DrawImage(OUR_TANK_DOWN[tank.getWheelState], tank.getLocation);
            }
            if (tank.getDirection == Direction.left)
            {
                graphics.DrawImage(OUR_TANK_LEFT[tank.getWheelState], tank.getLocation);
            }
            if (tank.getDirection == Direction.right)
            {
                graphics.DrawImage(OUR_TANK_RIGHT[tank.getWheelState], tank.getLocation);
            }
        }
        public static void paint(Bullet bullet) //рисует снаряд
        {
            throw new NotImplementedException();
        }
        public static void paint(Wall wall) //рисует стену
        {
            throw new NotImplementedException();
        }

        //-------------Картинки-----------------------------------
        public static Image[] OUR_TANK_UP = new Bitmap[]
        {
            Properties.Resources.OurTank_Up_0,
            Properties.Resources.OurTank_Up_1,
            Properties.Resources.OurTank_Up_2,
            Properties.Resources.OurTank_Up_3,
            Properties.Resources.OurTank_Up_4,
            Properties.Resources.OurTank_Up_5,
            Properties.Resources.OurTank_Up_6,
            Properties.Resources.OurTank_Up_7
        };
        public static Image[] OUR_TANK_DOWN = new Bitmap[]
        {
            Properties.Resources.OurTank_Down_0,
            Properties.Resources.OurTank_Down_1,
            Properties.Resources.OurTank_Down_2,
            Properties.Resources.OurTank_Down_3,
            Properties.Resources.OurTank_Down_4,
            Properties.Resources.OurTank_Down_5,
            Properties.Resources.OurTank_Down_6,
            Properties.Resources.OurTank_Down_7
        };
        public static Image[] OUR_TANK_LEFT = new Bitmap[]
        {
            Properties.Resources.OurTank_Left_0,
            Properties.Resources.OurTank_Left_1,
            Properties.Resources.OurTank_Left_2,
            Properties.Resources.OurTank_Left_3,
            Properties.Resources.OurTank_Left_4,
            Properties.Resources.OurTank_Left_5,
            Properties.Resources.OurTank_Left_6,
            Properties.Resources.OurTank_Left_7
        };
        public static Image[] OUR_TANK_RIGHT = new Bitmap[]
        {
            Properties.Resources.OurTank_Right_0,
            Properties.Resources.OurTank_Right_1,
            Properties.Resources.OurTank_Right_2,
            Properties.Resources.OurTank_Right_3,
            Properties.Resources.OurTank_Right_4,
            Properties.Resources.OurTank_Right_5,
            Properties.Resources.OurTank_Right_6,
            Properties.Resources.OurTank_Right_7
        };
    }
}
