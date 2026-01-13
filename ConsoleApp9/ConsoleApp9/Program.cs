using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace ConsoleApp9
{
    internal class Program
    {

        //class Character
        //{
        //    //캐릭터의 데이터를 저장하는 클래스
        //    //public string name; // public 다른곳에서 사용가능하게 한다, private는 같은 클래스 내에서만 사용가능
        //    //public int level;
        //    //public int hp;
        //    //public int maxHP;
        //    //public int mp;
        //    //public int maxMP;

        //    private string name;
        //    private int level;
        //    private int hp;
        //    private int maxHP;
        //    private int mp;
        //    private int maxMP;


        //    //기본 생성자  초기화용도로 많이사용
        //    public Character()
        //    {
        //        name = "홍길동";
        //        level = 1;
        //        hp = 100;
        //        maxHP = 150;
        //        mp = 80;
        //        maxMP = 100;
        //    }

        //    //인자있는 생성자
        //    public Character(string _name, int _leveel, int _hp, int _maxHP, int _mp, int _maxMP)
        //    {
        //        name = _name;
        //        level = _leveel;
        //        hp = _hp;
        //        maxHP = _maxHP;
        //        mp = _mp;
        //        maxMP = _maxMP;
        //    }

        //    //함수를 모아서 사용
        //    public void ShowStats()
        //    {
        //        Console.WriteLine("이름 : " + name);
        //        Console.WriteLine("레벨 : " + level);
        //        Console.WriteLine("Hp : " + hp);
        //        Console.WriteLine("MaxHP : " + maxHP);
        //        Console.WriteLine("MP : " + mp);
        //        Console.WriteLine("MaxMP : " + maxMP);
        //    }

        //}

        //캐릭터 클래스 정의
        //class Character
        //{
        //    // 필드 : 클래스의 데이터
        //    private string name;
        //    private int level;
        //    private int hp;
        //    private int maxHP;
        //    private int mp;
        //    private int maxMP;

        //    public void SetInfo(string _name, int _level, int _hp, int _maxHP, int _mp, int _maxMP)
        //    {
        //        name = _name;
        //        level = _level;
        //        hp = _hp;
        //        maxHP = _maxHP;
        //        mp = _mp;
        //        maxMP = _maxMP;
        //    }

        //    public Character()
        //    {
        //        name = "홍길동";
        //        level = 1;
        //        hp = 100;
        //        maxHP = 150;
        //        mp = 80;
        //        maxMP = 100;
        //    }

        //    public Character(string _name, int _level, int _hp, int _maxHP, int _mp, int _maxMP)
        //    {
        //        name = _name;
        //        level = _level;
        //        hp = _hp;
        //        maxHP = _maxHP;
        //        mp = _mp;
        //        maxMP = _maxMP;
        //    }

        //    public void ShowStats()
        //    {
        //        Console.WriteLine($"━━━━━━━━━━━━━━━━━━━━━━━━━");
        //        Console.WriteLine($"직업 : {name}");
        //        Console.WriteLine($"레벨 : {level}");
        //        Console.WriteLine($"체력/최대체력 : {hp}/{maxHP}");
        //        Console.WriteLine($"{mp}/{maxMP}");
        //        Console.WriteLine($"━━━━━━━━━━━━━━━━━━━━━━━━━");

        //    }

        //    public void TakeDamage(int damage)
        //    {
        //        hp -= damage;
        //        if (hp < 0) hp = 0;

        //        Console.WriteLine($"{name}가 {damage}의 피해를 입었습니다.");
        //        Console.WriteLine($"남은 HP: {hp}/{maxHP}");
        //    }

        //    public void Heal(int amount)
        //    {
        //        hp += amount;
        //        if (hp > maxHP) hp = maxHP;

        //        Console.WriteLine($"{name}가 {amount}만큼 회복했습니다.");
        //        Console.WriteLine($"남은 HP: {hp}/{maxHP}");
        //    }
        //}

        //class Moster
        //{
        //    //필드
        //    public string name;
        //    public int level;
        //    public int hp;
        //    public int attack;
        //    public int defense;
        //    public int expReward;

        //    //기본 생성자
        //    public Moster()
        //    {
        //        name = "슬라임";
        //        level = 1;
        //        hp = 50;
        //        attack = 10;
        //        defense = 5;
        //        expReward = 10;
        //    }

        //    //매개변수가 있는 생성자
        //    public Moster(string monsterName, int monsterLevel)
        //    {
        //        name = monsterName;
        //        level = monsterLevel;
        //        hp = 50 * level;
        //        attack = 10 * level;
        //        defense = 5 * level;
        //        expReward = 10 * level;
        //    }

        //    //정보 출력
        //    public void ShowStats()
        //    {
        //        Console.WriteLine($"{name} (LV.{level})");
        //        Console.WriteLine($"    HP: {hp}");
        //        Console.WriteLine($"    공격력: {attack}");
        //        Console.WriteLine($"    방어력: {defense}");
        //        Console.WriteLine($"    경험치: {expReward}");

        //    }
        //}

        //class Character
        //{
        //    private int Att; // 은닉성

        //    //Get / Set 함수
        //    public void SetAtt(int _Att)
        //    {
        //        Att = _Att;
        //    }

        //    public int GetAtt()
        //    {
        //        return Att;
        //    }
        //}

        //class Character
        //{
        //    //private int att;

        //    //public int Att
        //    //{
        //    //    get { return att; }

        //    //    set
        //    //    {
        //    //        att = value;
        //    //    }
        //    //}


        //    public int Att { get; set; } //자동프로퍼티

        //    //읽기 전용
        //    public int MaxHP { get; private set; }

        //}

        //class Player
        //{
        //    private string name;
        //    private int gold;

        //    //프로퍼티
        //    public string Name { get { return name; } set { name = value; } }
        //    public int Gold
        //    {
        //        get { return gold; }

        //        set
        //        {
        //            if (value < 0)
        //            {
        //                Console.WriteLine("골드가 부족합니다.");
        //            }
        //            else
        //            {
        //                gold = value;
        //            }
        //        }
        //    }
        //}

        //프로퍼티 연습 문제(쉬운 난이도)
        //📝 문제 1: 학생 성적 관리 시스템
        //문제 설명
        //Student 클래스를 만들어 학생의 성적을 관리하세요.

        //요구사항
        //name (이름) - 읽기 전용 프로퍼티
        //score (점수) - 0~100 사이의 값만 허용하는 프로퍼티
        //Grade(등급) - 점수에 따라 자동 계산되는 읽기 전용 프로퍼티
        //90점 이상: "A"
        //80점 이상: "B"
        //70점 이상: "C"
        //60점 이상: "D"
        //60점 미만: "F"

        //class Student
        //{
        //    // TODO: 필드 선언
        //    private string name;
        //    private int score;
        //    private char grade;

        //    // TODO: Name 프로퍼티 (읽기 전용)
        //    public string Name
        //    {
        //        get { return name; }
        //        private set { name = value; }
        //    }
        //    // TODO: Score 프로퍼티 (0~100 검증)
        //    public int Score
        //    {
        //        get { return score; } 
        //        set
        //        {
        //            if (value < 0)
        //            {
        //                Console.WriteLine("0~100 사이의 값만 허용됩니다.");
        //            }
        //            else if (value > 100)
        //            {
        //                Console.WriteLine("0~100 사이의 값만 허용됩니다.");
        //            }
        //            else
        //            {
        //                score = value;
        //            }
        //        }
        //    }
        //    // TODO: Grade 프로퍼티 (자동 계산, 읽기 전용)
        //    public char Grade
        //    {
        //        get
        //        {
        //            if (score >= 90) { grade = 'A'; }
        //            else if (score >= 80) { grade = 'B';}
        //            else if (score >= 70) { grade = 'C';}
        //            else if (score >= 60){ grade = 'D';}
        //            else { grade = 'F';}

        //            return grade;
        //        }
        //        private set { grade = value; }
        //    }
        //    // 생성자
        //    public Student(string studentName)
        //    {
        //        name = studentName;
        //    }

        //    // 정보 출력
        //    public void ShowInfo()
        //    {
        //        Console.WriteLine($"━━━━━━━━━━━━━━━━");
        //        Console.WriteLine($"이름: {Name}");
        //        Console.WriteLine($"점수: {Score}점");
        //        Console.WriteLine($"등급: {Grade}");
        //        Console.WriteLine($"━━━━━━━━━━━━━━━━");
        //    }
        //}

        //class Character
        //{
        //    //static: 모든 캐릭터가 공유
        //    public static int totalCount = 0;

        //    //일반: 각 캐릭터마다 다름
        //    public string name;
        //}

        //class Skill
        //{
        //    //필드 /변수
        //    private string name;
        //    private int att;

        //    public Skill()
        //    {

        //    }

        //    public Skill(string name, int att)
        //    {
        //        this.name = name;
        //        this.att = att;
        //    }

        //    public void SkillStart()
        //    {
        //        Console.WriteLine("스킬이름 : " + name);
        //        Console.WriteLine("스킬이름 : " + att);
        //    }
        //}

        static void Main(string[] args)
        {
            

            //Skill s = new Skill("블리자드", 100000);
            //s.SkillStart();

            //Character c1 = new Character();
            //Character c2 = new Character();

            //c1.name = "전사";
            //c2.name = "마법사";

            //Character.totalCount = 1;

            //Console.WriteLine(c1.name);
            //Console.WriteLine(c2.name);

            //Console.WriteLine("카운트 : " + Character.totalCount);

            //Student student = new Student("홍길동");

            //student.Score = 95;
            //student.ShowInfo();

            //Console.WriteLine();

            //student.Score = 75;
            //student.ShowInfo();

            //Console.WriteLine();

            //// 잘못된 값 입력 시도
            //student.Score = 150;  // 100으로 제한되어야 함
            //student.Score = -10;  // 0으로 제한되어야 함
            //student.ShowInfo();

            //Player player = new Player();
            //player.Name = "홍길동";
            //player.Gold = -1000;

            //Console.WriteLine("이름 : " + player.Name);
            //Console.WriteLine("골드 : " + player.Gold);


            //Character c = new Character();

            //c.Att = 1;

            //Console.WriteLine(c.Att);

            //Character c = new Character();

            //c.SetAtt(20);

            //Console.WriteLine("공격력 : " + c.GetAtt());

            //Character player1 = new Character("전사", 5, 200, 300, 50, 80);

            //player1.name = "전사";
            //player1.level = 5;
            //player1.hp = 200;
            //player1.maxHP = 300;
            //player1.mp = 50;
            //player1.maxMP = 80;

            // 플레이어 정보
            //player1.ShowStats();

            // 데미지 입음
            //player1.TakeDamage(50);
            // 회복
            //player1.Heal(30);

            //Character player2 = new Character("마법사", 6, 250, 300, 50, 80);
            //player2.name = "마법사";
            //player2.level = 6;
            //player2.hp = 250;
            //player2.maxHP = 300;
            //player2.mp = 50;
            //player2.maxMP = 80;

            //player2.SetInfo("마법사", 8, 250, 300, 50, 80);

            //player2.ShowStats();
            // 인자있는 생성자 사용
            //Character player3 = new Character("마법사", 7, 100, 200, 70, 100);

            //player3.ShowStats();

            //기본 생성자 사용해서 객체 생성
            //Moster slime = new Moster();
            //스탯 출력
            //slime.ShowStats();

            // 매개변수가 있는 생성자 사용
            //고블린 5
            //Moster goblin = new Moster("고블린", 5);
            //스텟출력
            //goblin.ShowStats();

            //Console.WriteLine("\n=== 필드 몬스터 ===\n");
            //Moster[] monsters = new Moster[3];

            //monsters[0] = new Moster("늑대", 3);
            //monsters[1] = new Moster("오크", 7);
            //monsters[2] = new Moster("트롤", 10);

            //for(int i = 0; i < monsters.Length; i++)
            //{
            //    monsters[i].ShowStats();
            //    Console.WriteLine();
            //}

        }
    }
}
