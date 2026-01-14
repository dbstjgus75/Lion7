using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 상속
{
    ////부모클래스 : 기본 캐릭터
    //class Character
    //{
    //    //public, private, protected // 상속이 되어있는 지식이 사용가능하게 열어주는 접근제어자
    //    protected string name;
    //    protected int level;
    //    protected int hp;
    //    protected int maxHP;
    //    protected int attack;
    //    protected int defense;

    //    public Character(string characterName)
    //    {
    //        name = characterName;
    //        level = 1;
    //        maxHP = 100;
    //        hp = maxHP;
    //        attack = 30;
    //        defense = 20;

    //        Console.WriteLine($"캐릭터 {name} 생성!");
    //    }

    //    public virtual void ShowInfo()
    //    {
    //        Console.WriteLine($"이름 : {name}");
    //        Console.WriteLine($"레벨 : {level}");
    //        Console.WriteLine($"체력 : {hp} / {maxHP}");
    //        Console.WriteLine($"공격력 : {attack}");
    //        Console.WriteLine($"방어력 : {defense}");
    //    }
    //}

    ////자식클래스 : 전사
    //class Warrior : Character
    //{
    //    protected int rage; //전사만의 고유 속성

    //    public Warrior(string name) : base(name) //base로 부모 생성자 호출떄 매개변수 전달
    //    {
    //        //name = "전사"; //base.name과 같다 . 부모꺼 명시적으로 호출
    //        attack = 60;
    //        defense = 40;
    //        maxHP = 150;
    //        hp = maxHP;
    //        rage = 0;
            
    //        Console.WriteLine($"직업 : 전사");
    //    }

    //    public override void ShowInfo()
    //    {
    //        base.ShowInfo();
    //        Console.WriteLine($"분노 : {rage}");
    //    }
    //}

    //전사의 아들
    //class WarriorChild : Warrior
    //{
    //    public WarriorChild()
    //    {
    //        name = "전사의 아들";
    //        attack = 50;
    //        defense = 30;
    //        maxHP = 120;
    //        hp = maxHP;
    //        rage = 10;
    //    }

    //    public void ShowWarriorChildInfo()
    //    {
    //        base.ShowWarriorInfo();
    //        Console.WriteLine("나 전사 자식");
    //    }
    //}

    //public class Character
    //{
    //    public virtual void Render()
    //    {
    //        Console.WriteLine("캐릭터");
    //    }
    //}

    //public class Warrior :Character
    //{
    //    public override void Render()
    //    {
    //        Console.WriteLine("워리어");
    //    }
    //}


    //public class Mage :Character
    //{
    //    public override void Render()
    //    {
    //        Console.WriteLine("마법사");
    //    }
    //}
    //    문제 1: 동물원 시스템

    //Animal 부모 클래스와 다양한 동물 자식 클래스를 만들고,
    //다형성으로 관리하세요.


    //문제 2: 상점 시스템

    //다양한 상품 타입을 다형성으로 관리하고,
    //타입별로 다른 할인율을 적용하세요.

    internal class Program
    {
        static void Main(string[] args)
        {
            //Character character = new Character();
            //character.Render(); // 캐릭터

            //Character character1 = new Warrior(); //업캐스팅 부모 <- 자식메모리 참조
            //character.Render(); //워리어

            //Character character2 = new Mage();
            //character.Render();

            //Warrior warrior = new Warrior();
            //warrior.Render();


            //Warrior warrior = (Warrior)character; // 다운캐스팅

            //character.Render();
            //warrior.Render();
            
            //Character character = new Warrior(); // 업캐스팅

            //if (character is Warrior)
            //{
            //    Warrior warrior = (Warrior)character; // 다운캐스팅
            //    warrior.Render();
            //}

            //Character character = new Warrior("김철수");
            //character.ShowInfo();
            //Console.WriteLine();
            //Warrior warrior = new Warrior("홍길동");
            //warrior.ShowInfo();
            //Character character = new Character();
            //character.ShowInfo();
            //Console.WriteLine();
            //Warrior warrior = new Warrior();
            //warrior.ShowWarriorInfo();
            //Console.WriteLine();
            //WarriorChild warriorChild = new WarriorChild();
            //Console.WriteLine();
            //warriorChild.ShowWarriorChildInfo();

            //상속관계
            // 자식호출 -> 부 -> 생성자
            // 자 -> 생성자
            // 자 -> 소멸자
            // 부 -> 소멸자
        }
    }
}
