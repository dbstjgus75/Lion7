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

    class Animal
    {
        //필드
        protected string name; // 동물 닉네임
        protected int age; // 동물 나이
        protected string type; // 동물 종류
        protected string habitat; // 서식지
        protected double weight; // 동물 몸무게
        protected double height; // 동물 키
        protected string sound; // 동물 울음소리

        // 생성자
        public Animal(string name)
        {
            this.name = name;
            type = "알 수 없음";
            habitat = "알 수 없음";
            weight = 0.0;
            height = 0;
            sound = "소리 없음";
        }

        // 메서드
        public virtual void MakeSound()
        {
            Console.WriteLine($"{name}이(가) {sound} 소리를 냅니다.");
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine($"이름: {name}");
            Console.WriteLine($"나이: {age}살");
            Console.WriteLine($"종류: {type}");
            Console.WriteLine($"서식지: {habitat}");
            Console.WriteLine($"몸무게: {weight}kg");
            Console.WriteLine($"키: {height}m");
        }

    }

    class Lion : Animal
    {
        public Lion(string name) : base(name)
        {
            type = "사자";
            habitat = "사바나";
            sound = "어흥";
            age = 5;
            weight = 190.5;
            height = 1.2;
        }
        public override void MakeSound()
        {
            Console.WriteLine($"{name}이(가) {sound} 소리를 냅니다. (사자의 포효!)");
        }
    }

    class  Wolf: Animal
    {
        public Wolf(string name) : base(name)
        {
            type = "늑대";
            habitat = "초원";
            sound = "멍멍";
            age = 9;
            weight = 30.5;
            height = 0.5;
        }
        public override void MakeSound()
        {
            Console.WriteLine($"{name}이(가) {sound} 소리를 냅니다. (늑대의 포효!)");
        }
    }

    class Bear : Animal
    {
        public Bear(string name) : base(name)
        {
            type = "곰";
            habitat = "숲";
            sound = "크르릉";
            age = 2;
            weight = 230.5;
            height = 2.0;
        }
        public override void MakeSound()
        {
            Console.WriteLine($"{name}이(가) {sound} 소리를 냅니다. (곰의 포효!)");
        }
    }


    //문제 2: 상점 시스템

    //다양한 상품 타입을 다형성으로 관리하고,
    //타입별로 다른 할인율을 적용하세요.

    internal class Program
    {

        public static void AnimalTypeInfo()
        {
            Console.WriteLine("=== 동물 정보 보기 선택 ===");
            Console.WriteLine("1. 사자");
            Console.WriteLine("2. 늑대");
            Console.WriteLine("3. 곰");
            Console.Write("동물 타입을 선택하세요(나가기 : 0): ");

        }


        static void Main(string[] args)
        {

            Animal animal = new Animal("동물");

            Animal lion = new Lion("라이언");
            Animal wolf = new Wolf("울프");
            Animal bear = new Bear("베어");

            while (true)
            {
                Console.Clear();

                Console.WriteLine("동물원에 오신것을 환영합니다!!!");
                Console.WriteLine("1. 동물 정보 보기");
                Console.WriteLine("2. 동물 소리 듣기");
                Console.WriteLine("3. 종료");
                Console.Write("번호를 입력 하세요 : ");

                int input = int.Parse(Console.ReadLine()); // 입력한 값

                int animalType = -1; // 입력한 타입

                Console.Clear();

                if (input == 1)
                {
                    while (true)
                    {
                        AnimalTypeInfo();
                        animalType = int.Parse(Console.ReadLine());

                        if (animalType == 0)
                            break;

                        switch (animalType)
                        {
                            case 1:
                                lion.ShowInfo();
                                break;
                            case 2:
                                wolf.ShowInfo();
                                break;
                            case 3:
                                bear.ShowInfo();
                                break;
                        }

                    }
                }
                else if (input == 2)
                {
                    while (true)
                    {
                        AnimalTypeInfo();
                        animalType = int.Parse(Console.ReadLine());

                        if (animalType == 0)
                            break;

                        switch (animalType)
                        {
                            case 1:
                                lion.MakeSound();
                                break;
                            case 2:
                                wolf.MakeSound();
                                break;
                            case 3:
                                bear.MakeSound();
                                break;
                        }

                    }
                }
                else
                {
                    break;
                }




            }

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
