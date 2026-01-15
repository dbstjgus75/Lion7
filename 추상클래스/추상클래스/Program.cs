using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace 추상클래스
{
    public abstract class Character
    {
        protected string name;
        protected int hp;
        protected int maxHP;
        protected int speed;

        public Character() { }
        public Character(string name, int health, int speed)
        {
            this.name = name;
            this.maxHP = health;
            this.hp = maxHP;
            this.speed = speed;
        }
        public abstract void ShowInfo();
    }

    public class Warrior : Character
    {
        private int att; // 공격력
        private int def; // 방어력
        public Warrior(string name) : base(name, 200, 5)
        {
            att = 80;
            def = 50;
        }
        public override void ShowInfo()
        {
            //[전사]
            //    홍길동
            //HP: 200/200
            //공격력: 80
            //방어력: 50
            //이동속도: 5

            Console.WriteLine("━━━━━━━━━━━━━━━━━━━━");
            Console.WriteLine("[전사]");
            Console.WriteLine("    " + name);
            Console.WriteLine($"HP: {hp}/{maxHP}");
            Console.WriteLine($"공격력: {att}");
            Console.WriteLine($"방어력: {def}");
            Console.WriteLine($"이동속도: {speed}");
            Console.WriteLine("━━━━━━━━━━━━━━━━━━━━");

        }
    }

    public class Mage : Character
    {
        private int mp; // 마력
        private int mana; // 마나
        public Mage(string name) : base(name, 120, 4)
        {
            mp = 150;
            mana = 100;
        }
        public override void ShowInfo()
        {
            //[마법사]
            //    김마법
            //HP: 120/120
            //마력: 150
            //마나: 100
            //이동속도: 4

            Console.WriteLine("━━━━━━━━━━━━━━━━━━━━");
            Console.WriteLine("[마법사]");
            Console.WriteLine("    " + name);
            Console.WriteLine($"HP: {hp}/{maxHP}");
            Console.WriteLine($"마력: {mp}");
            Console.WriteLine($"마나: {mana}");
            Console.WriteLine($"이동속도: {speed}");
            Console.WriteLine("━━━━━━━━━━━━━━━━━━━━");

        }
    }

    public class Archor : Character
    {
        private int att; // 공격력
        private int arrowCount; // 화살 갯수
        public Archor(string name) : base(name, 150, 6)
        {
            att = 80;
            arrowCount = 50;
        }
        public override void ShowInfo()
        {
            //[궁수]
            //    이궁수
            //HP: 150/150
            //공격력: 100
            //화살: 50
            //이동속도: 6

            Console.WriteLine("━━━━━━━━━━━━━━━━━━━━");
            Console.WriteLine("[궁수]");
            Console.WriteLine("    " + name);
            Console.WriteLine($"HP: {hp}/{maxHP}");
            Console.WriteLine($"공격력: {att}");
            Console.WriteLine($"화살: {arrowCount}");
            Console.WriteLine($"이동속도: {speed}");
            Console.WriteLine("━━━━━━━━━━━━━━━━━━━━");

        }
    }


    //    === 유닛 생성 ===

    //━━━━━━━━━━━━━━━━━━━━
    //[전사]
    //    홍길동
    //HP: 200/200
    //공격력: 80
    //방어력: 50
    //이동속도: 5
    //━━━━━━━━━━━━━━━━━━━━

    //━━━━━━━━━━━━━━━━━━━━
    //[마법사]
    //    김마법
    //HP: 120/120
    //마력: 150
    //마나: 100
    //이동속도: 4
    //━━━━━━━━━━━━━━━━━━━━

    //━━━━━━━━━━━━━━━━━━━━
    //[궁수]
    //    이궁수
    //HP: 150/150
    //공격력: 100
    //화살: 50
    //이동속도: 6
    //━━━━━━━━━━━━━━━━━━━━

    internal class Program
    {
        static void Main(string[] args)
        {
            Character[] characters = new Character[3];

            characters[0] = new Warrior("홍길동");
            characters[1] = new Mage("김마법");
            characters[2] = new Archor("이궁수");

            //수집형알피지 캐릭터 두개 뽑았다.
            //그룹화해서 출력하기 좋음
            //for (int i = 0; i < characters.Length; i++)
            //{
            //    characters[i].Job();
            //}

            Console.WriteLine("=== 유닛 생성 ===");
            foreach (Character character in characters)
            {
                character.ShowInfo();
            }
        }
    }
}
