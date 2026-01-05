using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 리터럴 : 코드에서 고정된 값
            //int number = 10; // 정수형 리터럴
            //double pi = 3.14; // 실수형 리터럴
            //char letter = 'A'; // 문자 리터럴
            //string name = "Alice"; // 문자열 리터럴

            //Console.WriteLine("정수: " + number); // 출력 : 10
            //Console.WriteLine("실수: " + pi); // 출력 : 3.14
            //Console.WriteLine("문자: " + letter); // 출력 : A
            //Console.WriteLine("문자열: " + name); // 출력 : Alice

            //Console.Write(0);
            //Console.Write(0);

            // 정수 리터럴
            // 플레이스코어 100
            //파이 3.14
            // 등급 'A'
            // //플레이어 이름 홍길동

            // 결과 출력하기

            //int playScore = 100; // 플레이어 스코어
            //double pi = 3.14; // 원주율
            //char grade = 'A'; // 등급
            //string name = "홍길동"; // 플레이어 이름
            //bool isGameOver = false; // 게임 오버 여부

            //Console.WriteLine("플레이스코어 " + playScore);
            //Console.WriteLine("파이 " + pi);
            //Console.WriteLine("등급 " + grade);
            //Console.WriteLine("플레이어 이름 " + name);
            //Console.WriteLine("게임 오버 여부 " + isGameOver);

            //변수 선언후 값 저장
            //string greeting; // 문자열 변수를 선언
            //greeting = "안녕 월드야"; //변수에 값을 저장

            //Console.WriteLine(greeting); // 변수의 값을 출력

            //변수 초기화
            //int score = 100; // 변수 선언과 동시에 값 초기화
            //double temperature = 36.5; // 실수형 변수 선언과 초기화
            //string city = "Seoul"; // 문자열 변수 선언과 초기화

            //변수
            //Console.WriteLine(score); // 출력: 100
            //Console.WriteLine(temperature); // 출력: 36.5
            //Console.WriteLine(city); // 출력: Seoul

            // 방법1: 선언 후 할당
            //int health;
            //health = 100;

            // 방법2: 선언과 동시에 할당
            //int maxHealth = 100;
            //int damage = 15;

            //게임로직 출력
            //Console.WriteLine("체력 : " + health + "/" + maxHealth);

            // 데미지를 받았습니다.
            //Console.WriteLine("데미지 : " + damage);

            // 같은 데이터 타입 한번에 선언
            //int x = 10, y = 20, z = 30;

            //Console.WriteLine("x: " + x);
            //Console.WriteLine("y: " + y);
            //Console.WriteLine("z: " + z);

            //int age = 20;
            //string name = "윤서현";

            // 출력 방법
            //Console.WriteLine("나이: {0}", name);

            //Console.WriteLine("나이: {0} / 이름 : {1}", age, name);

            //Console.WriteLine("나이: " + age);

            //Console.WriteLine($"나이: {age}");

            //Console.WriteLine($"나이 : {age} 이름 : {name}");

            // 3D 좌표 예시
            //int posX = 0, posY = 50, posZ = 100;

            //Console.WriteLine("posX : {0} posY : {1} poxZ : {2}", posX, posY, posZ);

            //Console.WriteLine("posX : " + posX + " posY : " + posY + " posZ : " + posZ);

            //Console.WriteLine($"posX : {posX} posY : {posY} posZ : {posZ}");

            // RGB 색상 값 예시
            //int red = 255, green = 128, blue = 0;

            //Console.WriteLine("red : {0} green : {1} blue : {2}", red, green, blue);

            //Console.WriteLine("red : " + red + " green : " + green + " blue : " + blue);

            //Console.WriteLine($"red : {red} green : {green} blue : {blue}");



            // ━┃┏ ┓┛┗┣ ┳ ┫┻ ╋ 


            //          Console.WriteLine("                                     ");
            //          Console.WriteLine("                                        ");
            //          Console.WriteLine("                                        ");
            //          Console.WriteLine("  ┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓");
            //          // 윗부분은 줄을 바꿔야 그림이 나오니까 WriteLine 유지
            //          Console.WriteLine(@"  ┃    __          __  _    _    ____               __  __       _____    ___       ┃");
            //          Console.WriteLine(@"  ┃    \ \        / / | |  | |  / __ \       /\    |  \/  |     |_   _|  |__ \      ┃");
            //          Console.WriteLine(@"  ┃     \ \  /\  / /  | |__| | | |  | |     /  \   | \  / |       | |       ) |     ┃");
            //          Console.WriteLine(@"  ┃      \ \/  \/ /   |  __  | | |  | |    / /\ \  | |\/| |       | |      / /      ┃");
            //          Console.WriteLine(@"  ┃       \  /\  /    | |  | | | |__| |   / ____ \ | |  | |      _| |_    |_|       ┃");
            //          Console.WriteLine (@"  ┃        \/  \/     |_|  |_|  \____/   /_/    \_\|_|  |_|     |_____|   (_)       ┃");
            //          Console.WriteLine("  ┃                                                                                 ┃");
            //          Console.WriteLine("  ┃                                                                                 ┃");
            //          Console.WriteLine(@"  ┃                                                                                 ┃
            //┃                                ■■■■■■■                                          ┃
            //┃                               ■  ●  ● ■                                         ┃
            //┃                               ■   ▼   ■                                         ┃
            //┃                                ■■■■■■■                                          ┃
            //┃                                /┃   ┃\                                          ┃
            //┃                               / ┃   ┃ \                                         ┃
            //┃                                  ━━━                                            ┃
            //┃                                  ┃ ┃                                            ┃");                                                      
            //          Console.WriteLine("  ┃                                                                                 ┃");
            //          Console.WriteLine("  ┃                                                                                 ┃");
            //          Console.WriteLine(@"  ┃       __      _____    _____                           _____        __          ┃");
            //          Console.WriteLine(@"  ┃      / /     |_   _|  / ____|     /\         /\       / ____|       \ \         ┃");
            //          Console.WriteLine(@"  ┃     / /  ___   | |   | (___      /  \       /  \     | |         ___ \ \        ┃");
            //          Console.WriteLine(@"  ┃     \ \  ___|  | |    \___ \    / /\ \     / /\ \    | |        |___ / /        ┃");
            //          Console.WriteLine(@"  ┃      \ \      _| |_   ____) |  / ____ \   / ____ \   | |____        / /         ┃");
            //          Console.WriteLine(@"  ┃       \_\    |_____| |_____/  /_/    \_\ /_/    \_\   \_____|      /_/          ┃");
            //          Console.WriteLine("  ┃                                                                                 ┃");
            //          Console.WriteLine(@"  ┃              _  _          _>>                _|_                               ┃");
            //          Console.WriteLine(@"  ┃             ( \/ )   |||    (  _)_    ||     (_|_)    ||                        ┃");
            //          Console.WriteLine(@"  ┃              \  /    |||     (___))   ||       |      ||                        ┃");
            //          Console.WriteLine(@"  ┃               \/                               |                                ┃");
            //          Console.WriteLine("  ┃                                                                                 ┃");
            //          Console.WriteLine("  ┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛");


            int age = 20;
            string name = "윤서현";
            
            // 출력 방법
            Console.WriteLine("나이: {0} / 이름 : {1}", age, name);

            Console.WriteLine("나이: " + age);

            Console.WriteLine($"나이: {age}");

        }
    }
}
