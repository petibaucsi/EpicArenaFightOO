using EpicArenaBattleOO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicArenaFightOO.Heroes
{
    internal class Knight : Hero
    {
        public Knight(int Id) : base(Id)
        {
            MaxHp = 150;
            Hp = 150;
            Type = "Knight";
        }
        public override void Fight(Hero enemy)
        {
           if (enemy is Knight) { enemy.IsAlive = false; }
           if (enemy is Footman) { IsAlive = false; }
           if (enemy is Archer) { enemy.IsAlive = false; }

           DemageDealt(this);
           DemageDealt(enemy);
        }
    }
}
