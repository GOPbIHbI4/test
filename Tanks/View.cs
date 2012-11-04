using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace Tanks
{
    public partial class MainGameForm : Form
    {
        private Game game;
        private Thread gameThread;
        //---------нажатия юзера---------------------------------------
        private Direction userKeyDown = Direction.no;
        private bool userFired; //?!
        //-------------------------------------------------------------
        public MainGameForm()
        {
            InitializeComponent();
            gameThread = new Thread(new ThreadStart(runGame));
            gameThread.Start();
        }

        public void runGame()
        {
            game = new Game();
            while (true)
            {
                //логика
                game.getOurTank.move(userKeyDown);
                //тут двигаем все остальное - но его пока нету
                //вызвать ОнПайнт
                Invalidate();
                Thread.Sleep(30);
            }
        }
        
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.FillRectangle(new SolidBrush(Color.Black), 0, 0, this.Width, this.Height);
            //перерисовка всего
            foreach (ApplicationObject appObj in game)
            {
                appObj.paint(g);
            }
            g.Dispose();
        }

        //---------------нажатия юзера----------------------------------------
        private void MainGameForm_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                case Keys.Up:
                    if (userKeyDown == Direction.no)
                    {
                        userKeyDown = Direction.up;
                    }
                    break;

                case Keys.Down:
                    if (userKeyDown == Direction.no)
                    {
                        userKeyDown = Direction.down;
                    }
                    break;

                case Keys.Left:
                    if (userKeyDown == Direction.no)
                    {
                        userKeyDown = Direction.left;
                    }
                    break;

                case Keys.Right:
                    if (userKeyDown == Direction.no)
                    {
                        userKeyDown = Direction.right;
                    }
                    break;
            }
        }

        private void MainGameForm_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                case Keys.Up:
                    if (userKeyDown == Direction.up)
                    {
                        userKeyDown = Direction.no;
                    }
                    break;

                case Keys.Down:
                    if (userKeyDown == Direction.down)
                    {
                        userKeyDown = Direction.no;
                    }
                    break;

                case Keys.Left:
                    if (userKeyDown == Direction.left)
                    {
                        userKeyDown = Direction.no;
                    }
                    break;

                case Keys.Right:
                    if (userKeyDown == Direction.right)
                    {
                        userKeyDown = Direction.no;
                    }
                    break;
            }
        }
    }
}
