using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using EpicArenaBattleOO;

namespace EpicArenaFightOO.Heroes
{
    internal class Hero(int Id)
    {
        public int Id { get; set; } = Id;
        public double Hp { get; set; }
        public double MaxHp { get; set; }
        public string Type { get; set; }

        private bool isAlive;
        public bool IsAlive  
        {
            get { return isAlive; }   
            set 
            {
                isAlive = value;
                if(value == false)
                {
                    Hp = 0;
                }
            }  
        }

        /// <summary>
        /// Does the fight betwwen the two selected heroes
        /// After the figth the alive heroes (if any) take thier half HP damage
        /// </summary>
        /// <param name="enemy"></param>
        public virtual void Fight(Hero enemy)
        {
            IsAlive = true;
        }

        //Heals the Hero 10 HP, but can't go over the initial HP
        public void Rest()
        {
            Hp += 10;
            if (Hp > MaxHp) { Hp = MaxHp; }
        }

        //Does the damage to the hero. If HP is below 1/4 of inital HP, the hero dies
        protected void DemageDealt(Hero hero)
        {
            hero.Hp = hero.Hp / 2;
            if (hero.Hp < hero.MaxHp / 4) { hero.IsAlive = false; }
        }
    }

}
