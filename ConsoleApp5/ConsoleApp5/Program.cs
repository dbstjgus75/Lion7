using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text; 
using System.Threading.Tasks;
using System.Threading;
namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            //삼항 연산자 : (조건) ? t : f;
            //int a = 10, b = 20;
            //int max = (a > b) ? a : b;
            //Console.WriteLine(max);

            //기본 사용법
            //int score = 85;
            //string result = (score >= 60) ? "합격" : "불합격";

            //Console.WriteLine("=== 시험 결과 ===");
            //Console.WriteLine($"점수: {score}");
            //Console.WriteLine($"결과: {result}");

            //예제 2: 레벨에 따른 등급
            //레벨 45
            // 50보다 크면 고급 50~30 사이이면 중급 그렇지 않으면 초급

            //플레이어등급
            //레벨 : 
            //등급 : 

            //int level = 45;

            //string grade = (level > 50) ? "고급" :
            //               (level >= 30) ? "중급" : "초급";
            //Console.WriteLine("=== 플레이어 등급 ===");
            //Console.WriteLine($"레벨 : {level}");
            //Console.WriteLine($"등급 : {grade}");

            //헬쓰 = 30;
            //맥스헬쓰 = 100;
            //헬스상태 70% 안전 70~30 주의 그보다 낮으면 위험
            //int 헬쓰 = 30;
            //int 맥스헬쓰 = 100;
            //string 헬스상태 = (헬쓰 > 70) ? "안전" :
            //                 (헬쓰 >= 30) ? "주의" : "위험";
            //Console.WriteLine(헬스상태);

            //int health = 30;
            //int maxHealth = 100;
            //string healthState = (health >= maxHealth * 0.7) ? "안전" :
            //                     (health >= maxHealth * 0.3) ? "주의" : "위험";
            //Console.WriteLine("체력 상태");
            //Console.WriteLine($"현재 체력: {health}/{maxHealth}");
            //Console.WriteLine($"상태: {healthState}");

            // 연산자 우선순위
            //int result = 10 + 2 * 5; // 곱셈이 덧셈보다 우선
            //Console.WriteLine(result);

            //int adjustedResult = (10 + 2) * 5;
            //Console.WriteLine(adjustedResult);

            // 예제 2: 데미지 계산
            //int baseDamage = 50;
            //int bonusDamage = 20;
            //double criticalMultiplier = 1.5;

            //// 잘못된 계산
            //double  damage1= baseDamage + bonusDamage * criticalMultiplier;
            //// 올바른 계산
            //double damage2 = (baseDamage + bonusDamage) * criticalMultiplier;

            //Console.WriteLine("\n=== 크리티컬 데미지 계산 ===");
            //Console.WriteLine($"기본 데미지: {baseDamage}");
            //Console.WriteLine($"보너스 데미지: {bonusDamage}");
            //Console.WriteLine($"크리티컬 배율: {criticalMultiplier}");
            //Console.WriteLine($"잘못된 계산: {damage1}");  // 80.0
            //Console.WriteLine($"올바른 계산: {damage2}");  // 105.0

            // 조건문 if문과 else문
            //int score = 85;
            //Console.WriteLine("본인 점수 : " + score);
            //if (score >= 90)
            //{
            //    Console.WriteLine("A 학점");
            //}
            //else
            //{
            //    Console.WriteLine("90점 미만");
            //}

            // else if문
            //int score = 75;
            //if (score >= 90)
            //{
            //    Console.WriteLine("A 학점");
            //}
            //else if (score >= 80)
            //{
            //    Console.WriteLine("B 학점");
            //}
            //else if (score >= 70)
            //{
            //    Console.WriteLine("C 학점");
            //}
            //else
            //{
            //    Console.WriteLine("D 학점");
            //}

            //int a = 10;

            //if(a == 10)
            //{
            //    Console.WriteLine("A가 " + a + "입니다.");
            //    Console.WriteLine("영역안이야");
            //}
            //Console.WriteLine("영역밖이야");

            //int a = 78;

            //if (a >= 90)
            //{
            //    Console.WriteLine("A등급");
            //}
            //else if (a > 80 && a <= 89)
            //{
            //    Console.WriteLine("B등급");
            //}
            //else if (a > 70 && a <= 79)
            //{
            //    Console.WriteLine("C등급");
            //}
            //else
            //{
            //    Console.WriteLine("D등급");
            //}

            //현재 체력: 30 / 100
            //⚠️ 경고: 체력이 위험합니다!
            //회복 아이템을 사용하세요!
            //💊 체력이 50 % 이하입니다.

            //⚔️ 적이 사거리 안에 있습니다!
            //공격 가능!


            //int health = 30;
            //int maxHealth = 100;
            //int enemyDistance = 5;
            //int attackRange = 3;

            //Console.WriteLine($"현재 체력: {health}/{maxHealth}");

            //// 체력 상태 여부
            //if(health <= maxHealth * 0.3)
            //{
            //    Console.WriteLine($"⚠️ 경고: 체력({health})이 위험합니다.");
            //    Console.WriteLine("회복 아이템을 사용하세요!");
            //}
            //else if(health <= maxHealth * 0.5 && health > 0)
            //{
            //    Console.WriteLine("💊 체력이 50 % 이하입니다.");
            //}
            //else
            //{
            //    Console.WriteLine("게임 오버!");
            //    Console.WriteLine("부활 지점에서 다시 시작합니다.");
            //}

            //Console.WriteLine($"\n플레이어 공격 사거리/적 거리: {attackRange}/{enemyDistance}");
            //// 공격 사거리 여부
            //if (enemyDistance <= attackRange)
            //{
            //    Console.WriteLine("⚔️ 적이 사거리 안에 있습니다!");
            //    Console.WriteLine("공격 가능!");
            //}
            //else
            //{
            //    Console.WriteLine("⚔️ 적이 사거리 안에 없습니다!");
            //    Console.WriteLine("공격 불가능!");
            //}

            //// 아이템 구매 시스템
            //int playerGold = 220;
            //int itemPrice = 250;
            //string itemName = "강철 검";

            //Console.WriteLine("=== 상점 ===");
            //Console.WriteLine($"아이템 : {itemName}");
            //Console.WriteLine($"가격 : {itemPrice}골드");
            //Console.WriteLine($"소지금 : {playerGold}골드");

            //if (playerGold >= itemPrice)
            //{
            //    //구매 가능
            //    playerGold -= itemPrice;
            //    Console.WriteLine("\n구매 성공!");
            //    Console.WriteLine($"{itemName}을 획득했습니다.");
            //    Console.WriteLine($"남은 골드: {playerGold}");
            //}
            //else
            //{
            //    //구매불가
            //    int needGold = itemPrice - playerGold;
            //    Console.WriteLine("\n골드가 부족합니다!");
            //    Console.WriteLine($"필요한 골드: {needGold}골드 더 필요");
            //}

            //Console.WriteLine("\n=== 던전 입장 ===");
            //int playerLevel = 48;
            //int requiredLevel = 50;

            //if(playerLevel >= requiredLevel)
            //{
            //    Console.WriteLine("던전에 입장합니다.");
            //    Console.WriteLine("전투 준비!");
            //}
            //else
            //{
            //    Console.WriteLine("던전에 입장 불가능");
            //    Console.WriteLine($"필요 레벨 : {requiredLevel}");
            //    Console.WriteLine($"현재 레벨 : {playerLevel}");
            //    Console.WriteLine($"레벨업이 필요합니다: {requiredLevel - playerLevel}레벨");

            //}

            //점수에 따른 등급 판정
            //int score = 0;
            //string rank;

            //Console.WriteLine("=== 게임 랭크 시스템 ===");
            //Console.Write("스코어를 입력하세요 : ");
            //score = int.Parse(Console.ReadLine());
            //Console.WriteLine($"점수 : {score}");

            //if(score >= 10000)
            //{
            //    rank = "SSS";
            //    Console.WriteLine($"등급 : {rank} (레전드)");
            //    Console.WriteLine("보상: 전설 아이템 + 골드 10000");
            //}
            //else if (score >= 8000)
            //{
            //    rank = "SS";
            //    Console.WriteLine($"등급 : {rank} (마스터)");
            //    Console.WriteLine("보상: 영웅 아이템 + 골드 5000");
            //}
            //else if (score >= 6000)
            //{
            //    rank = "S";
            //    Console.WriteLine($"등급 : {rank} (다이아)");
            //    Console.WriteLine("보상: 희귀 아이템 + 골드 3000");
            //}
            //else if (score >= 4000)
            //{
            //    rank = "A";
            //    Console.WriteLine($"등급 : {rank} (플레티넘)");
            //    Console.WriteLine("보상: 고급 아이템 + 골드 1500");
            //}
            //else
            //{
            //    rank = "B";
            //    Console.WriteLine($"등급 : {rank} (골드)");
            //    Console.WriteLine("보상: 일반 아이템 + 골드 500");
            //}

            // 캐릭터 상태 판정
            //Console.WriteLine("\n == 캐릭터 상태 ===");
            //int health = 0;
            //Console.Write("체력값을 입력하세요 : ");
            //health = int.Parse(Console.ReadLine());

            //if (health >= 80)
            //{
            //    Console.WriteLine("💚 상태: 매우 좋음");
            //}
            //else if (health >= 60)
            //{
            //    Console.WriteLine("🟢 상태: 좋음");
            //}
            //else if (health >= 40)
            //{
            //    Console.WriteLine("🟡 상태: 보통");
            //}
            //else if (health >= 20)
            //{
            //    Console.WriteLine("🟠 상태: 위험");
            //}
            //else
            //{
            //    Console.WriteLine("🔴 상태: 매우 위험!");
            //}

            //int day = 3;

            //switch (day)
            //{
            //    case 1:
            //        Console.WriteLine("월요일");
            //        break;
            //    case 2:
            //        Console.WriteLine("화요일");
            //        break;
            //    case 3:
            //        Console.WriteLine("수요일");
            //        break;
            //    default:
            //        Console.WriteLine("유효하지 않은 요일");
            //        break;
            //}

            // 캐릭터선택화면을 switch만드시오

            //int jobChice = 1;
            //Console.WriteLine("=== 캐릭터 선책창 ===");
            //Console.WriteLine("캐릭터 선택");
            //Console.WriteLine("1.전사 2.마법사 3.궁수 4.도적");
            //Console.Write("번호를 선택하세요 : ");
            //jobChice = int.Parse(Console.ReadLine());

            //// 캐릭터 능력 창
            //string 직업 = "";
            //string 특성 = "";
            //string 무기 = "";
            //string 스탯 = "";

            //switch (jobChice)
            //{
            //    case 1:
            //        직업 = "전사";
            //        특성 = "근접 공격";
            //        무기 = "도끼";
            //        스탯 = "피흡 + 20, 공격력 + 20";
            //        break;
            //    case 2:
            //        직업 = "마법사";
            //        특성 = "강력한 마법  공격";
            //        무기 = "지팡이, 마법서";
            //        스탯 = "마나 + 100, 마법력 + 20";
            //        break;
            //    case 3:
            //        직업 = "도적";
            //        특성 = "암살";
            //        무기 = "단검";
            //        스탯 = "기력 + 100, 공격력 + 50";
            //        break;
            //    case 4:
            //        직업 = "검사";
            //        특성 = "근접 공격";
            //        무기 = "대검";
            //        스탯 = "체력 + 50, 공격력 + 40";
            //        break;
            //    default:
            //        Console.WriteLine("❌ 잘못된 선택입니다.");
            //        Console.WriteLine("1~4 중에서 선택해주세요.");
            //        break;
            //}

            //Console.WriteLine("\n=== 캐릭터 생성 ===");
            //Console.WriteLine($"직업 : {직업}");
            //Console.WriteLine($"특성 : {특성}");
            //Console.WriteLine($"무기 : {무기}");
            //Console.WriteLine($"스탯 : {스탯}");

            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine("공"); //엄청길게 캐스팅해야하는 구절
            //}

            // === 몬스터 웨이브 시작 ===
            //👹 고블린 #1 생성!
            //👹 고블린 #2 생성!
            //👹 고블린 #3 생성!
            //👹 고블린 #4 생성!
            //👹 고블린 #5 생성!
            //총 5마리 생성 완료!
            //int MosterWave1 = 5;
            //for (int i = 1; i <= MosterWave1; i++)
            //{
            //    Console.WriteLine($"👹 고블린 #{i} 생성!");
            //}
            //Console.WriteLine($"총 {MosterWave1}마리 생성 완료!");

            //=== 게임 시작 카운트다운 ===
            //5...
            //4...
            //3...
            //2...
            //1...
            //🎮 게임 시작!

            //Console.WriteLine("=== 게임 시작 카운트다운 ===");
            //for (int i = 5; i > 0; i--)
            //{
            //    Console.WriteLine($"{i}...");
            //}
            //Console.WriteLine("🎮 게임 시작!");

            //무한 반복
            //for (; ; )
            //{
            //    Console.WriteLine("무한반복");
            //    Thread.Sleep(1000);
            //}

            //랜덤함수
            // 게임에서 굉장히 중요한 기능이다.

            //Random random = new Random(); //랜덤함수 사용방법

            ////사용방법
            //int number1 = random.Next(1, 7); // 1~6까지 나옴
            //Console.Write(number1);

            //검 종류
            // 무한의 대검 10 %
            // 카타나 20 %
            // 엑스칼리버 30 %
            // 정기정검 40 %

            //string sword = "무한의 대검";

            //Console.WriteLine("당신은 20번뽑기가 가능합니다. 지금 실행합니다.");

            //Random rand = new Random();

            //int random = 0;

            //for (int i = 0; i < 20; i++)
            //{
            //    random = rand.Next(1, 101);

            //    if(random >= 1 && random <= 10)
            //    {
            //        sword = "무한의 대검";
            //    }
            //    else if (random >= 11 && random <= 30)
            //    {
            //        sword = "카타나";
            //    }
            //    else if (random >= 31 && random <= 60)
            //    {
            //        sword = "엑스칼리버";
            //    }
            //    else if (random >= 61 && random <= 100)
            //    {
            //        sword = "정기정검";
            //    }

            //    Console.WriteLine(sword);
            //    Thread.Sleep(500);

            //}
        }
    }
}
