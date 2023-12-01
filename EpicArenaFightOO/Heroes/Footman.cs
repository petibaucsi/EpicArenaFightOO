using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicArenaFightOO.Heroes
{
    internal class Footman : Hero
    {
        public Footman(int Id) : base(Id)
        {
            MaxHp = 120;
            Hp = 120;
            Type = "Footman";
        }
        public override void Fight(Hero enemy)
        {
            if (enemy is Knight) { }
            if (enemy is Footman) { enemy.IsAlive = false; }
            if (enemy is Archer) { enemy.IsAlive = false; }

            DemageDealt(this);
            DemageDealt(enemy);
        }
    }
}
