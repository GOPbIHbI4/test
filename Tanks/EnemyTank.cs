using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tanks
{
    public class EnemyTank : Tank //враг
    {
        EnemyStrategy strategy; //определяет, что делать
        private delegate Action action(Direction direction); //либо двигаться вперед, либо повернуть, либо выстрелить

        public void executeAction(Direction direction)//исполняет действие action
        {
            throw new NotImplementedException();
        }
    }
}
