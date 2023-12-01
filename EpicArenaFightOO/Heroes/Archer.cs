using EpicArenaBattleOO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicArenaFightOO.Heroes
{
    internal class Archer : Hero
    {
        public Archer(int Id) : base(Id)
        {
            MaxHp = 100;
            Hp = 100;
            Type = "Archer";
        }
        public override void Fight(Hero enemy)
        {
            if (enemy is Knight)
            {
                int i = General.GenerateRandom(10);
                enemy.IsAlive = i <= 6;
                General.LogEvents("The random value is " + i.ToString() + "(1-6 Knight survives, 7-10 knight dies)");
            }
            if (enemy is Footman) { enemy.IsAlive = false; }
            if (enemy is Archer) { enemy.IsAlive = false; }

            DemageDealt(this);
            DemageDealt(enemy);

        }
    }
}
