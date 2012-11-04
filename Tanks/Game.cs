using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tanks
{
    class Game : IEnumerable<ApplicationObject> // игра-контейнер всего 
    {
        private List<Bullet> bullets; //все пульки
        private OurTank ourTank; //свой танк
        private List<EnemyTank> enemyTanks;//враги
        private List<Wall> walls;//стены

        public Game()
        {
            this.ourTank = new OurTank();
            this.bullets = new List<Bullet>();
            this.enemyTanks = new List<EnemyTank>();
            this.walls = new List<Wall>();
        }

        public OurTank getOurTank
        {
            get { return ourTank; }
        }

        public void moveAll()//изменить состояние всех объектов на следующий шаг 
        {
            throw new NotImplementedException();
        }

        //------------Перечислители---------------------------------------
        public IEnumerator<ApplicationObject> GetEnumerator()
        {
            yield return (ApplicationObject) ourTank;
            foreach (ApplicationObject appObj in bullets)
            {
                yield return appObj;
            }
            foreach (ApplicationObject appObj in enemyTanks)
            {
                yield return appObj;
            }
            foreach (ApplicationObject appObj in walls)
            {
                yield return appObj;
            }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
