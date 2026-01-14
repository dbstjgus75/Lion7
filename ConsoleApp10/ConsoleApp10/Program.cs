using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Program
    {
        //클래스끼리 통신
        class Player
        {
            private int hp;
            private int att;

            public void Render()
            {
                Console.WriteLine("플레이어 상태");
                Console.WriteLine("체력 : " + hp);
                Console.WriteLine("공격력 : " + att);
            }

            public void SetHp(int hp) { this.hp = hp; }
            public int GetHp() { return hp; }

            public void SetAtt(int att) { this.att = att; }
            public int GetAtt() { return att; }

        }

        class Monster
        {
            private int hp;
            private int att;

            public void SetHp(int hp) { this.hp = hp; }
            public int GetHp() { return hp; }

            public void SetAtt(int att) { this.att = att; }
            public int GetAtt() { return att; }

            public void Render()
            {
                Console.WriteLine("몬스터 상태");
                Console.WriteLine("체력 : " + hp);
                Console.WriteLine("공격력 : " + att);
            }
        }

        static void Main(string[] args)
        {
            // 플레이어 객체
            Player player = new Player();
            player.SetHp(100);
            player.SetAtt(10);
            // 몬스터 객체
            Monster moster = new Monster();
            moster.SetHp(100);
            moster.SetAtt(5);

            // 플레이어가 몬스터 때리기
            moster.SetHp(moster.GetHp() - player.GetAtt());
            player.SetHp(player.GetHp() - moster.GetAtt());

            Console.WriteLine("전투 후");
            player.Render();
            moster.Render();


        }
    }
}
