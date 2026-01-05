using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 상수 : 값을 변경할 수 없는 변수
            const double PI = 3.14159; // 상수 Pi 선언 및 초기화
            const int MaxScore = 100; // 정수형 상수 선언

            // 출력
            //Console.WriteLine("PI : " + PI);
            //Console.WriteLine("Max Score : " + MaxScore);
            //Console.WriteLine("** 실행 결과 **");
            //Console.WriteLine("'''");
            //Console.WriteLine("=== 게임 설정 ===");
            //Console.WriteLine("최대 플레이어: " + MaxUsers + "명");
            //Console.WriteLine("시작 골드: " + StartScore +"G");
            //Console.WriteLine("버전: " + version);
            //Console.WriteLine("'''");

            //const int Max_PLAYER_USERS = 4;
            //const int StART_SCORE = 1000;
            //const string GAME_VERSION = "1.0.0";


            //Console.WriteLine("** 실행 결과 **");
            //Console.WriteLine("'''");
            //Console.WriteLine("=== 게임 설정 ===");
            //Console.WriteLine($"최대 플레이어: {Max_PLAYER_USERS}명");
            //Console.WriteLine($"시작 골드: {StART_SCORE}G");
            //Console.WriteLine($"버전: {GAME_VERSION}");
            //Console.WriteLine("'''");

            //숫자 데이터 형식: 정수와 실수를 다룰 떄 사용하는 다양한 타입
            //int integerNum = 10; // 정수 데이터
            //float floatNum = 3.14f; //단정밀도 실수
            //double doubleNum = 3.14159;// 배정밀도 실수

            //Console.WriteLine("정수형: " + integerNum);
            //Console.WriteLine("단정밀도 실수형: " + floatNum);
            //Console.WriteLine("배정밀도 실수형: " + doubleNum);

            //byte level = 50; // 레벨 (0~255)
            //short attack = 1500; // 공격력
            //int gold = 1234567; // 소지금
            //long experience = 999999999L; // 경험치 (L 접미사 필수)
            //Console.WriteLine("=== 캐릭터 정보 ===");
            //Console.WriteLine($"레벨: {level}");
            //Console.WriteLine($"공격력: {attack}");
            //Console.WriteLine($"골드: {gold:N0}골드"); // N0 : 전 단위 구분
            //Console.WriteLine($"경험치 : {experience:N0}점");

            // 타입별 최대값 확인
            //Console.WriteLine("\n=== 타입별 최대값 ===");
            //Console.WriteLine($"byte 최대값: {byte.MaxValue}");
            //Console.WriteLine($"short 최대값: {short.MaxValue}");
            //Console.WriteLine($"int 최대값: {int.MaxValue:N0}");
            //Console.WriteLine($"long 최대값: {long.MaxValue:N0}");

            // 실수 데이터 형식: 소수점을 포함한 숫자를 표현
            //float singlePrecision = 3.14f; // 단정밀도 실수 (4바이트)
            //double doublePrecision = 3.1415926535; // 배정밀도 실수 (8바이트)
            //decimal highPrecision = 3.1415926535897932384626433833m; // 고정소수점 실수 (16바이트)

            //Console.WriteLine(singlePrecision); // 출력 : 3.14
            //Console.WriteLine(doublePrecision); // 출력 : 3.1415926535
            //Console.WriteLine(highPrecision); // 출력 : 3.1415926535897932384626433833

            //접미사 사용: 숫자의 데이터 형식을 명시
            //int integerValue = 100; //기본 정수형(int)
            //long longValue = 100L; //정수형(long)
            //float floatValue = 3.14f; //실수형(float)
            //double doubleValue = 3.14; //기본 실수형(double)
            //decimal decimalValue = 3.14m; //고정밀도 실수형(decimal)

            //Console.WriteLine(integerValue);
            //Console.WriteLine(longValue);
            //Console.WriteLine(floatValue);
            //Console.WriteLine(doubleValue);
            //Console.WriteLine(decimalValue);

            //char 형식: 단일 문자를 표현 unicode로 통합 즉 2바이트 크기로 통일됐다는 의미
            //char letter = 'A'; // 문자 'A' 저장
            //char symbol = '#'; // 특수 기호 저장
            //char number = '9'; // 숫자 형태의 문자 저장(문자 '9', 숫자 9 아님)

            //Console.WriteLine(letter);
            //Console.WriteLine(symbol);
            //Console.WriteLine(number);

            //출력
            // ==== 캐릭터 능력치 ====
            //float 이동속도 5.5
            //double 공격속도 1.25
            //decimal 아이템 가격 12.99

            //float moveSpeed = 5.5f; // 이동 속도
            //double attackSpeed = 1.25; // 공격 속도
            //decimal itemPrice = 12.99m; // 아이템 가격

            //Console.WriteLine("==== 캐릭터 능력치 ====");
            //Console.WriteLine($"이동속도 : {moveSpeed}");
            //Console.WriteLine($"공격속도 : {attackSpeed}");
            //Console.WriteLine($"아이템 가격 : {itemPrice}G");

            //string 형식: 여러 문자를 저장
            //string greeting = "Hello, World!"; // 문자열 저장
            //string name = "Alice"; // 이름 저장

            //Console.WriteLine(greeting);
            //Console.WriteLine(name);

            // 문자 (char) - 단 하나의 문자만
            //char grade = 'A';
            //char symbol = '★';
            //char number = '9'; // 문자 '9'이지 숫자 9가 아님!

            // 문자열 (string) - 여러 문자의 조합
            //string playerName = "홍길동";
            //string welcomeMessage = "게임에 오신 것을 환영합니다!";
            //string emptyString = ""; // 빈 문자열도 가능


            //**실행 결과: **
            //=== RPG 게임 ===
            //플레이어: 홍길동
            //등급: A등급 ★
            //게임에 오신 것을 환영합니다!

            //Console.WriteLine("**실행 결과: **");
            //Console.WriteLine("=== RPG 게임 ===");
            //Console.WriteLine($"플레이어: {playerName}");
            //Console.WriteLine($"등급: {grade}등급 {symbol}");
            //Console.WriteLine(welcomeMessage);

            //bool 형식 : 참(true) 또는 거짓(false) 값을 저장
            //bool isRunning = true;
            //bool isFinished = false;

            //Console.WriteLine($"게임 실행 중: {isRunning}");
            //Console.WriteLine($"게임 종료 여부: {isFinished}");

            // 실전 예제

            // === 게임 상태 ===
            // 게임 실행 중: True
            // 일시정지: False
            //열쇠 소지: False
            //문 열림: False
            //플레이어 생존: True

            //=== 캐릭터 상태 ===
            //체력: 80
            //건강 상태: True
            // 위험 상태: False

            //bool isGameRunning = true; // 게임 실행 상태
            //bool isPaused = false; // 게임 일시정지 상태
            //bool hasKey = false; // 열쇠 소지 여부
            //bool isDoorOpen = false; // 문 열림 여부
            //bool isPlayerAlive = true; // 플레이어 생존 여부
            //int health = 80; // 캐릭터 체력
            //bool isHealthy = health > 60; // 건강 상태
            //bool isInDanger = health < 60; // 위험 상태

            //Console.WriteLine("=== 게임 상태 ===");
            //Console.WriteLine($"게임 실행 중: {isGameRunning}");
            //Console.WriteLine($"일시정지: {isPaused}");
            //Console.WriteLine($"열쇠 소지: {hasKey}");
            //Console.WriteLine($"문 열림: {isDoorOpen}");
            //Console.WriteLine($"플레이어 생존: {isPlayerAlive}");
            //Console.WriteLine("\n=== 캐릭터 상태 ===");
            //Console.WriteLine($"체력: {health}");
            //Console.WriteLine($"건강 상태: {isHealthy}");
            //Console.WriteLine($"위험 상태: {isInDanger}");

            // using System;를 사용하지 않을 시 사용
            //System.Int32 number = 1234; //int의 닷넷 형식
            //System.String text = "Hello"; // string의 닷넷 형식
            //System.Boolean flag = true; // bool의 닷넷 형식

            //Console.WriteLine(number);
            //Console.WriteLine(text);
            //Console.WriteLine(flag);

            //int number = 123;
            //string numberAsString = number.ToString(); // 정수를 문자열로 변환

            //bool flag = true;
            //string flagAsString = flag.ToString(); // 불리언을 문자열로 변환

            //Console.WriteLine(numberAsString); // 출력: "123"
            //Console.WriteLine(flagAsString); // 출력: "True"

            //Console.Clear(); // 콘솔 내용 한번 싹 지움
            // Thread.Sleep(1000); 괄호 시간만큼 

            Thread.Sleep(5000); // 5초
            Console.WriteLine("흑백요리사 대표 문자는 3가지는?");
            Thread.Sleep(500); // 0.5초
            Console.WriteLine(" ----");
            Thread.Sleep(500); // 0.5초
            Console.WriteLine(@"/    \     | ");
            Thread.Sleep(500); // 0.5초
            Console.WriteLine("|    |     | ");
            Thread.Sleep(500); // 0.5초
            Console.WriteLine(@"\    /     |====");
            Thread.Sleep(500); // 0.5초
            Console.WriteLine(@"\    /     |");
            Thread.Sleep(500); // 0.5초
            Console.WriteLine(" ----");
            Thread.Sleep(500); // 0.5초
            Console.WriteLine("          ----");
            Thread.Sleep(500); // 0.5초
            Console.WriteLine(@"         /    \ ");
            Thread.Sleep(500); // 0.5초
            Console.WriteLine("         |    |   ");
            Thread.Sleep(500); // 0.5초
            Console.WriteLine(@"         \    /  ");
            Thread.Sleep(500); // 0.5초
            Console.WriteLine(@"         \    /  ");
            Thread.Sleep(500); // 0.5초
            Console.WriteLine("          ----");

            Thread.Sleep(3000); // 5초
            Console.Clear();

            Thread.Sleep(1000); // 0.5초
            Console.WriteLine("      ----");
            Thread.Sleep(500); // 0.5초
            Console.WriteLine(@"     /    \ ");
            Thread.Sleep(500); // 0.5초
            Console.WriteLine("     |    |  ");
            Thread.Sleep(500); // 0.5초
            Console.WriteLine(@"     \    / ");
            Thread.Sleep(500); // 0.5초
            Console.WriteLine(@"     \    / ");
            Thread.Sleep(500); // 0.5초
            Console.WriteLine("      ----");
            Thread.Sleep(500); // 0.5초
            Console.WriteLine("   ━━━━━━━━━━");
            Thread.Sleep(500); // 0.5초
            Console.WriteLine("    ━━━━━━━━");
            Thread.Sleep(500); // 0.5초
            Console.WriteLine("            ┃   ");
            Thread.Sleep(500); // 0.5초
            Console.WriteLine("    ━━━━━━━━    ");
            Thread.Sleep(500); // 0.5초
            Console.WriteLine("    ┃   ");
            Thread.Sleep(500); // 0.5초
            Console.WriteLine("    ━━━━━━━━");

            Thread.Sleep(3000); // 5초
            Console.Clear();

            Thread.Sleep(500); // 0.5초
            Console.WriteLine("     ━━━━  ━━━━");
            Thread.Sleep(500); // 0.5초
            Console.WriteLine("         ┃    ┃ ");
            Thread.Sleep(500); // 0.5초
            Console.WriteLine("         ┃    ┃  ");
            Thread.Sleep(500); // 0.5초
            Console.WriteLine("       ━━━━━━━━━━ ");
            Thread.Sleep(500); // 0.5초
            Console.WriteLine("         ━━━━━━ ");
            Thread.Sleep(500); // 0.5초
            Console.WriteLine("         ┃   ");
            Thread.Sleep(500); // 0.5초
            Console.WriteLine("         ━━━━━━");
            Thread.Sleep(500); // 0.5초
            Console.WriteLine("         ┃");
            Thread.Sleep(500); // 0.5초
            Console.WriteLine("         ━━━━━━━   ");

            Thread.Sleep(3000); // 5초
            Console.Clear();
            Console.WriteLine("요리 괴물 vs 손종원 승부는 바로~~~~");
            Thread.Sleep(5000); // 5초
            Console.WriteLine("다음 시간에 계속 ^^");
        }
    }
}
