using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleApp8
{
    internal class Program
    {

        ////1단계 기본함수
        //static void SayHello()
        //{
        //    Console.WriteLine("안녕하세요, 용사님");
        //    Console.WriteLine("모험을 시작합니다.");

        //}

        //// 게임 시작 메시지
        //static void ShowGameStart()
        //{
        //    Console.WriteLine("╔═══════════════════════════════════╗");
        //    Console.WriteLine("║ ⚔  RPG 게임 시작 ⚔                ║");
        //    Console.WriteLine("╚═══════════════════════════════════╝");
        //}

        //// 구분선 출력
        //static void PrintSeparator()
        //{
        //    Console.WriteLine("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━");
        //}

        //// 게임 메뉴창 
        //static void ShowGameMenu()
        //{
        //    Console.WriteLine("1. 시작");
        //    Console.WriteLine("2. 옵션");
        //    Console.WriteLine("3. 제작진");
        //    Console.WriteLine("4. 종료");

        //}

        //static void Attack(int att, int def)
        //{
        //    Console.WriteLine("공격력 전달 받았다. : " + att);
        //    Console.WriteLine("방어력 : " + def);

        //}

        //static void PlayerInfo(string chpName, int health, int healthRegen, int spd, int luk)
        //{
        //    Console.WriteLine($"플레이어 이름 : {playerName}");
        //    Console.WriteLine($"체력 : {att}");
        //    Console.WriteLine($"체력 재생 : {att}");
        //    Console.WriteLine($"마나 : {att}");
        //    Console.WriteLine($"마나 재생 : {att}");
        //    Console.WriteLine($"공격력 : {att}");
        //    Console.WriteLine($"공격 속도 : {att}");
        //    Console.WriteLine($"방어력 : {dex}");
        //    Console.WriteLine($"마법 저항력 : {dex}");
        //    Console.WriteLine($"사거리 : {dex}");
        //    Console.WriteLine($"이동 속도 : {dex}");


        //}

        //2단계 활용
        //static void GreetPlayer(string playerName)
        //{
        //    Console.WriteLine($"환영합니다. {playerName}님");
        //}

        //static void ShowPlayerInfo(string job, int level)
        //{
        //    Console.WriteLine($"직업 : {job}");
        //    Console.WriteLine($"레벨 : {level}");

        //}

        ////매개 변수 3개 체력바 출력
        //static void DrawHealtBar(int current, int max, int barLength)
        //{
        //    Console.WriteLine("HP [");

        //    int filledLength = (int)((double)current / max * barLength);

        //    for (int i = 0; i < barLength; i++)
        //    {
        //        if(i < filledLength)
        //        {
        //            Console.Write("■");
        //        }
        //        else
        //        {
        //            Console.Write("□");
        //        }
        //    }

        //    Console.WriteLine($"] {current}/{max}");
        //}

        ////데미지 계산 출력
        //static void ShowDamage(string attacker, string target, int damage)
        //{
        //    Console.WriteLine($"{attacker}의 공격");
        //    Console.WriteLine($"    {target}에게 {damage} 데미지!");
        //}

        //반환값이 있는 함수 3단계

        //정수반환
        //static int GetNumber() // 정수 반환
        //{
        //    return 42;
        //}
        ////문자열 반환
        //static string GetString() // 문자열 반환
        //{
        //    return "안녕하세요!";
        //}

        //static void Attack()
        //{
        //    Console.WriteLine("기본공격");
        //    Console.WriteLine("데미지 : 50");
        //}

        //매개변수 1개 
        //static void Attack(string target)
        //{
        //    Console.WriteLine($"{target}을(를) 공격합니다.");
        //    Console.WriteLine("데미지 : 50");
        //}

        //static void Attack(string skillName, string target, int damage)
        //{
        //    Console.WriteLine($"✨ 스킬 발동: {skillName}");
        //    Console.WriteLine($"⚔️ {target}에게 {damage} 데미지!");
        //}

        //기본매개변수 사용
        //static void CastFireBall(string target, int damage = 100, int manaCost = 30)
        //{
        //    Console.WriteLine($" 파이어볼 시전!");
        //    Console.WriteLine($" 대상: {target}");
        //    Console.WriteLine($" 데미지: {damage}");
        //    Console.WriteLine($" 마나 소모: {manaCost}");
        //}

        //static void UseItem(string itemName, int healAmount = 50)
        //{
        //    Console.WriteLine($"💊 {itemName} 사용!");
        //    Console.WriteLine($"회복량: {healAmount} HP");
        //}

        //static void RandomCreature(string mosterName, int level, int mosterCount)
        //{
        //    Console.WriteLine($"✨ {mosterName} 소환!");
        //    Console.WriteLine($"레벨: {level}");
        //    Console.WriteLine($"수량: {mosterCount}마리");
        //}

        //static void Attack(ref int a)
        //{
        //    Console.WriteLine("공격력 : " + a);
        //    a++;
        //}

        //static void Attack (out int attack, out int defense)
        //{
        //    attack = 10;
        //    defense = 20;

        //    attack++;
        //    defense++;
        //}

        //일반함수
        //static void Swap1(ref int a,ref int b)
        //{
        //    int temp = a;
        //    a = b;
        //    b = temp;
        //}

        //1부터 n까지의 합 구학
        //static int SumToN(int n)
        //{
        //    if (n <= 0)
        //    {
        //        return 0;
        //    }

        //    return n + SumToN(n - 1);
        //}

        //💪 연습 문제


        //문제 1: 평균 계산 함수

        //정수 배열을 받아 평균을 반환하는 함수를 만드세요.

        //문제 2: 등급 판별 함수

        //점수를 받아 A, B, C, D, F 등급을 반환하는 함수를 만드세요.

        //문제 3: 소수 판별 함수

        //숫자를 받아 소수인지 판별하는 함수를 만드세요.

        //문제 4: 경험치 시스템

        //현재 경험치와 획득 경험치를 받아
        //레벨업 여부와 새 경험치를 반환하는 함수를 만드세요. (out 사용)

        //문제 5: 아이템 강화 시스템

        //강화 레벨에 따라 성공 확률이 달라지는
        //아이템 강화 시스템을 함수로 구현하세요.

        // 평균반환 함수
        static float Average(int[] score)
        {
            int sum = 0;
            for(int i = 0; i < score.Length; i++)
            {
                sum += score[i];
            }

            return (float)sum / score.Length;
        }

        // 등급 판별 함수
        static char GetGrade(int score)
        {
            if (score >= 90)
                return 'A';
            else if (score >= 80)
                return 'B';
            else if (score >= 70)
                return 'C';
            else if (score >= 60)
                return 'D';
            else
                return 'F';
        }

        // 소수 판별 함수
        static bool IsPrime(int score)
        {
            if (score <= 1)
                return false;
            for (int i = 2; i <= Math.Sqrt(score); i++)
            {
                if (score % i == 0)
                    return false;
            }
            return true;
        }

        // 경험치 시스템 함수
        static void ExpSystem(int currentExp, int ExpGainde, out bool isLevelUp, out int newExp)
        {
            isLevelUp = false;
            newExp = currentExp + ExpGainde;

            if (newExp >= 1000)
            {
                isLevelUp = true;
                newExp -= 1000; // 레벨업 후 남은 경험치 계산
            }
        }

        // 아이템 강화 시스템 함수
        static bool EnhanceItem(int enhanceLevel)
        {
            Random random = new Random();
            int successRate; // 성공 확률

            switch (enhanceLevel)
            {
                case 0:
                    successRate = 100;
                    break;
                case 1:
                    successRate = 80;
                    break;
                case 2:
                    successRate = 60;
                    break;
                case 3:
                    successRate = 40;
                    break;
                case 4:
                    successRate = 20;
                    break;
                case 5:
                    successRate = 10;
                    break;
                default:
                    successRate = 0;
                    break;
            }
            int roll = random.Next(1, 101); // 1부터 100까지의 랜덤 숫자 생성
            return roll <= successRate;

        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            bool isLevelUp;
            int newExp;
            int expGained = 600;
            int currentExp = 900;

            // 문제 1: 평균 계산 함수
            int[] scores = { 85, 90, 78, 92, 88 };
            float avg = Average(scores);
            Console.WriteLine("문제 1: 평균 계산 함수\n");
            for (int i = 0;i < scores.Length; i++)
            {
                Console.Write($"점수 {i + 1}: {scores[i]} | ");
            }

            Console.WriteLine();

            Console.WriteLine($"평균 점수: {avg}\n");

            // 문제 2: 등급 판별 함수
            char grade = GetGrade(scores[0]);
            Console.WriteLine("문제 2: 등급 판별 함수");
            Console.WriteLine($"점수: {scores[0]}, 등급: {grade}\n");

            // 문제 3: 소수 판별 함수
            bool isPrime = IsPrime(scores[0]);
            Console.WriteLine("문제 3: 소수 판별 함수");
            Console.WriteLine($"숫자: {scores[0]}, 소수 여부: {isPrime}\n");

            // 문제 4: 경험치 시스템
            ExpSystem(currentExp, expGained, out isLevelUp, out newExp);
            Console.WriteLine("문제 4: 경험치 시스템\n");
            Console.WriteLine($"== 1000 경험치 이상 얻으면 레벨업?! ==");
            Console.WriteLine($"현재 경험치 : {currentExp}, 획득한 경험치 : {expGained}\n");
            
            if (isLevelUp)
            {
                Console.WriteLine($"!! 레벨업 했습니다 !! || 현재 레벨 경험치 : {newExp}\n");
            }
            else
            {
                Console.WriteLine($" ㅠㅠ 레벨업 하지 못했습니다. ㅠㅠ || 현재 레벨 경험치 : {newExp}\n");
            }

            //문제 5: 아이템 강화 시스템
            EnhanceItem(3);
            Console.WriteLine("문제 5: 아이템 강화 시스템");
            if (EnhanceItem(3))
            {
                Console.WriteLine("강화 성공!");
            }
            else
            {
                Console.WriteLine("강화 실패!");
            }

        }
    }
}
