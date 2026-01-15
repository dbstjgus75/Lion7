using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 인터페이스
{
    //인터페이스
    interface IAttackable
    {
        void Attack(string target);
        int GetAttackPower();
    }

    //인터페이스 Defendable 구현 방어기능
    interface IDefendable
    {
        void Defend();
        int GetDefensePower();
    }


    class knight : IAttackable, IDefendable // 알트 + 엔터
    {
        public string name;
        public int attackPower;
        public int defensePower;

        public knight()
        {
            this.name = "검사";
            this.attackPower = 10;
            this.defensePower = 8;
        }

        public void Attack(string target)
        {
            Console.WriteLine($"검으로 공격 {target}을 공격했습니다.");
        }

        public void Defend()
        {
            Console.WriteLine("기사가 방어모드중입니다.");
        }

        public int GetAttackPower()
        {
            return attackPower;
        }

        public int GetDefensePower()
        {
            return defensePower;
        }
    }

    class Mage : IAttackable
    {
        public string name;
        public int MagicPower;

        public Mage()
        {
            this.name = "마법사";
            this.MagicPower = 12;
        }

        public void Attack(string target)
        {
            Console.WriteLine($"마법으로 공격 {target}을 공격했습니다.");
        }

        public int GetAttackPower()
        {
            return MagicPower;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //knight k = new knight();
            //k.Attack("오크");
            //Console.WriteLine("공격력 : " + k.GetAttackPower());
            //k.Defend();
            //Console.WriteLine("방어력 : " + k.GetDefensePower());
            //Console.WriteLine();

            //Mage m = new Mage();
            //m.Attack("고블린");
            //Console.WriteLine("공격력 : " + m.GetAttackPower());

            //인터페이스 배열
            IAttackable[] attacker = new IAttackable[2];
            attacker[0] = new knight();
            attacker[1] = new Mage();


            IDefendable defender = new knight();

            foreach(IAttackable att in attacker)
            {
                att.Attack("고블린");
            }

            defender.Defend();
        }
    }
}
