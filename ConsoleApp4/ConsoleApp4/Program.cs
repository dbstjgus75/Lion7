using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //사용자 입력을 문자열로 받기
            //Console.Write("이름을 입력하세요 : ");
            //string userName = Console.ReadLine(); // 사용자로부터 입력 받기

            //Console.WriteLine($"안녕하세요 {userName}님!"); //입력값 출력

            //문자열을 정수로 변환
            //Console.Write("나이를 입력하세요 : ");
            //string input = Console.ReadLine();
            //int age = int.Parse(input);

            //Console.Write($"내년에는 {age + 1}살이군요!!");

            //이진수를 정수로 변환
            //Console.Write("2진수를 입력하세요: ");
            //string binaryInput = Console.ReadLine();
            //int decimalValue = Convert.ToInt32(binaryInput, 2); // 2진수 -> 10진수 변환

            //정수를 이진수로 변환
            //string binaryOutput = Convert.ToString(decimalValue, 2);

            //Console.WriteLine($"입력한 이진수 : {binaryInput}");
            //Console.WriteLine($"10진수로 변환 : {decimalValue}");
            //Console.WriteLine($"다시 이진수로 변환 : {binaryOutput}");

            //=== 캐릭터 생성 ===
            //캐릭터 이름을 입력하세요: 홍길동
            //환영합니다, 홍길동님!
            //시작 레벨을 입력하세요 : 5
            //홍길동님의 시작 레벨은 5입니다.

            //Console.WriteLine("=== 캐릭터 생성 ===");
            //Console.Write("캐릭터 이름을 입력하세요: ");
            //string userName = Console.ReadLine();
            //Console.WriteLine($"환영합니다, {userName}님!");
            //Console.Write("시작 레벨을 입력하세요 : ");
            //string levelInput = Console.ReadLine();
            //int userLevel =  int.Parse(levelInput); //Convert.ToInt32(levelInput);
            //Console.WriteLine($"{userName}님의 시작 레벨은 {userLevel}입니다.");

            //var를 사용하여 변수 선언
            //var name = "Alince"; //문자열로 추론
            //var age = 25; //정수로 추론
            //var isStudent = true; //논리값으로 추론
            //var aaa = 3.1; // double 타입으로 변환
            //Console.WriteLine(aaa.GetType());
            //Console.WriteLine($"이름 : {name}, 나이 : {age}, 학생 여부 : {isStudent}");

            //default 키워드를 사용한 기본값 설정
            //int defaultInt = default; // 0
            //string defaultString = default; // null
            //bool defaultBool = default; // false
            //float defaultFloat = default; // 0
            //double defaultDouble = default; // 0 

            //Console.WriteLine($"정수 기본값: {defaultInt}");
            //Console.WriteLine($"문자열 기본값: {defaultString}");
            //Console.WriteLine($"논리값 기본값: {defaultBool}");
            //Console.WriteLine($"실수f 기본값: {defaultFloat}");
            //Console.WriteLine($"실수d 기본값: {defaultDouble}");

            //1.암시적 변환(작은 타입->큰 타입)
            //int smallNumber = 100;
            //long bigNumber = smallNumber; // int -> long(자동 타입)
            //double doubleNumber = smallNumber; // int -> double(자동 변환)

            //Console.WriteLine("=== 암시적 변환 ===");
            //Console.WriteLine($"int : {smallNumber.GetType()}");
            //Console.WriteLine($"long : {bigNumber.GetType()}");
            //Console.WriteLine($"double : {doubleNumber.GetType()}");

            //2. 명시적 변환 (큰타입 -> 작은타입)
            //double pi = 3.14159;
            //int intPi = (int)pi; // 소수점을 버림! 명시적 변환

            //Console.WriteLine("\n=== 명시적 변환 ===");
            //Console.WriteLine($"double : {pi}");
            //Console.WriteLine($"int로 변환 : {intPi}");

            //3. 문자열을 숫자로 변환
            //string scoreText = "95";
            //int score = int.Parse(scoreText); // 문자열 -> 정수

            //string priceText = "19.99";
            //double price = double.Parse(priceText); // 문자열 -> 실수

            //Console.WriteLine("\n=== 문자열 변환 ===");
            //Console.WriteLine($"점수(문자열) : {scoreText} -> 숫자: {score}");
            //Console.WriteLine($"가격(문자열) : {priceText} -> 숫자: {price}");

            //4. 숫자를 문자열로 변환
            //int playerLevel = 50;
            //string levelText = playerLevel.ToString();

            //Console.WriteLine("\n=== 숫자를 문자열로 ===");
            //Console.WriteLine($"레벨(숫자): {playerLevel} -> 문자열 : {levelText}");

            //연산자
            //int a = 5, b = 2;
            //int sum = a + b; // 산술연산자 사용 +
            //bool isEqual = (a == b); // 관계형 연산자 사용

            //Console.WriteLine($"합 : {sum}");
            //Console.WriteLine($"a와 b가 같은가? {isEqual}");

            //단항 연산자
            //int number = 5;
            //Console.WriteLine(+number); // 양수 출력 : 5
            //Console.WriteLine(-number); //음수 출력 : -5

            //bool flag = true;
            //Console.WriteLine(!flag); // 논리 부정 : 반대 변환. 

            //int a = 10, b = 3;

            //Console.WriteLine(a + b);
            //Console.WriteLine(a - b);
            //Console.WriteLine(a * b);
            //Console.WriteLine(a / b);
            //Console.WriteLine(a % b);

            // 문자열 연결 연산자
            //string firstName = "Alice";
            //string lastName = "Smith";

            //Console.WriteLine(firstName + " " + lastName);

            //int sum = 0;

            //a = a + b;

            //할당 연산자
            //a += b;

            //Console.WriteLine("합계 : " + a);

            //int a = 5;
            //int b = 4;

            //a += b;
            //Console.WriteLine("합계 : " + a);
            //a = 5;
            //a -= b;
            //Console.WriteLine("합계 : " + a);
            //a = 5;
            //a *= b;
            //Console.WriteLine("합계 : " + a);
            //a = 5;
            //a /= b;
            //Console.WriteLine("합계 : " + a);
            //a = 5;
            //a %= b;
            //Console.WriteLine("합계 : " + a);

            // a *= b -= b /= b; // 이것도 연속으로 가능

            //캐릭터 스탯 계산
            //int baseAttack = 50; // 기본 공격력
            //int weaponDamage = 30; // 무기 공격력
            //int totalAttack = baseAttack + weaponDamage; // 최고 공격력

            //Console.WriteLine("=== 공격력 계산 ===");
            //Console.WriteLine($"기본 공격력 : {baseAttack}");
            //Console.WriteLine($"무기 데미지 : {weaponDamage}");
            //Console.WriteLine($"총 공격력 : {totalAttack}");

            //// 데미지 계산
            //int playerHealth = 100; // 플레이어 체력
            //int damage = 25; // 공통 데미지
            //playerHealth = playerHealth - damage; // 한번 데미지 입음

            //Console.WriteLine("\n === 데미지 계산 ===");
            //Console.WriteLine($"받은 데미지: {damage}");
            //Console.WriteLine($"남은 체력: {playerHealth}");

            ////경험치 계산
            //int mosterSkilled = 5; // 처치한 몬스터
            //int exPerMonster = 100; // 몬스터 경험치
            //int totalExp = mosterSkilled * exPerMonster; // 죽인 몬스터만큼 경험치량

            //Console.WriteLine("=== 경험치 획득 ===");
            //Console.WriteLine($"처치한 몬스타: {mosterSkilled}마리");
            //Console.WriteLine($"몬스터당 경험치: {exPerMonster}");
            //Console.WriteLine($"총 경험치: {totalExp}");

            ////아이템 분배
            //int totalGold = 1000; // 총 소지금
            //int playerCount = 4; // 플레이어 인원 수
            //int goldPerPlayer = totalGold / playerCount; // 1인당 골드
            //int remainingGold = totalGold % playerCount; // 남은 골드

            //Console.WriteLine("=== 골드 분배 ===");
            //Console.WriteLine($"총 골드: {totalGold}");
            //Console.WriteLine($"플레이어 수 : {playerCount}명");
            //Console.WriteLine($"1인당 골드 : {goldPerPlayer}");
            //Console.WriteLine($"남은골드: {remainingGold}");

            // 증감 연산자 ++ --
            //int b = 3;

            //후위는 컴파일 시점에서 증가나 감소되지 않고 다음라인에서 연산된다.
            //b++; //후위 증가 : 선 대입 후 증가 
            //Console.WriteLine(b);

            //--b; //전위 감소 : 선 증가 후 대입
            //Console.WriteLine(b);

            //int killCount = 0;
            //int amao = 30;
            //int countDown = 3;

            //Console.WriteLine("=== 몬스터 처치 ===");
            //Console.WriteLine($"고블린 처치! (킬 카운트: {++killCount})");
            //Console.WriteLine($"오크 처치! (킬 카운트: {++killCount})");
            //Console.WriteLine($"드래곤 처치! (킬 카운트: {++killCount})");
            //Console.WriteLine($"총 처치 수: {killCount}마리");

            //Console.WriteLine("\n=== 사격 ===");
            //Console.WriteLine($"남은 탄약: {amao}");
            //Console.WriteLine($"발사! 남은 탄약: {--amao}");
            //Console.WriteLine($"발사! 남은 탄약: {--amao}");
            //Console.WriteLine($"발사! 남은 탄약: {--amao}");

            //Console.WriteLine("\n=== 카운트다운 ===");
            //Console.WriteLine(countDown--);
            //Console.WriteLine(countDown--);
            //Console.WriteLine(countDown);
            //Console.WriteLine("발사!");

            // 관계형 연산자와 논리 연산자
            //int x = 5;
            //int y = 10;

            //Console.WriteLine(x < y); // true
            //Console.WriteLine(x > y); // false
            //Console.WriteLine(x == y); // false
            //Console.WriteLine(x != y); // true

            //AND
            //bool a = true;
            //bool b = true;

            //Console.WriteLine(a && b);
            //a = false;
            //b = true;
            //Console.WriteLine(a && b);
            //a = true;
            //b = false;
            //Console.WriteLine(a && b);
            //a = false;
            //b = false;
            //Console.WriteLine(a && b);

            // OR
            //bool a = false, b = false;
            //Console.WriteLine(a || b);
            //a = false; b = true;
            //Console.WriteLine(a || b);
            //a = true; b = false;
            //Console.WriteLine(a || b);
            //a = true; b = true;
            //Console.WriteLine(a || b);

            //!
            //bool a = false;

            //Console.WriteLine(!a);

            // 8비트 = 1바이트
            //int x = 5; // 0101 // int는 4바이트이므로 총 4 * 8 = 32 비트 
            //int y = 3; // 0011

            //비트 AND
            //string binary = Convert.ToString(x & y, 2);  // 두 비트가 1로 동일하면 하나라도 다르면 0
            //Console.WriteLine($"8비트 : {binary.PadLeft(8, '0')}");

            //비트 OR
            //binary = Convert.ToString(x | y, 2);  // 둘중에 하나가 1이라면 1 둘 다 0이면 0
            //Console.WriteLine($"8비트 : {binary.PadLeft(8, '0')}");

            //비트 XOR
            //binary = Convert.ToString(x ^ y, 2); // 두 비트 같으면 0 다르면 1  
            //Console.WriteLine($"8비트 : {binary.PadLeft(8, '0')}");

            //비트 NOT
            //binary = Convert.ToString(~x, 2); // 비트의 반대 0 -> 1, 1 -> 0
            //Console.WriteLine($"8비트 : {binary.PadLeft(8, '0')}");

            //int value = 4; // 0100
            //string binary = Convert.ToString(value << 1, 2);

            // << >>
            //Console.WriteLine($"8비트 : {binary.PadLeft(8, '0')}");
            //binary = Convert.ToString(value >> 1, 2);
            //Console.WriteLine($"8비트 : {binary.PadLeft(8, '0')}");


            // 인벤토리 코드
            //int inventory = 0; // 0000 0000 

            //Console.WriteLine($"초기 인벤토리: {Convert.ToString(inventory, 2).PadLeft(8, '0')}");

            ////슬롯 번호
            //int slot1 = 1; //활
            //int slot2 = 2; //지팡이

            ////슬롯 0에 활을 추가
            //inventory = inventory | (1 << slot1); // 2번째로 1추가
            //Console.WriteLine($"슬롯 {slot1}에 활 추가");
            //Console.WriteLine($"초기 인벤토리: {Convert.ToString(inventory, 2).PadLeft(8, '0')}");

            ////슬롯 0에 활을 추가
            //inventory = inventory | (1 << slot2); // 2번째로 1추가
            //Console.WriteLine($"슬롯 {slot2}에 지팡이 추가");
            //Console.WriteLine($"초기 인벤토리: {Convert.ToString(inventory, 2).PadLeft(8, '0')}");

            //연습문제 1 RPG 체력 계산기
            //int currentHP = 80;
            //int maxHP = 100;
            //Console.WriteLine($"초기 체력: {currentHP}/{maxHP}");
            //currentHP -= 25;
            //Console.WriteLine($"데미지 -25: {currentHP}/{maxHP}");
            //currentHP += 30;
            //Console.WriteLine($"회복 +30: {currentHP}/{maxHP}");
            //currentHP -= 5;
            //Console.WriteLine($"독 데미지 -5: {currentHP}/{maxHP}");

            //연습문제 2 경험치와 레벨 계산
            //int expPerMonster = 150;
            //int monstersKilled = 3;
            //int expForLevelUp = 500;

            //Console.WriteLine($"\n처치한 몬스터: {monstersKilled}마리");
            //int gainedExp = monstersKilled * expPerMonster;
            //Console.WriteLine($"획득 경험치: {gainedExp}");
            //Console.WriteLine($"레벨업까지 필요: {expForLevelUp - gainedExp}");

            //연습문제 3 아이템 분배 시스템
            //int totalGold = 1234;
            //int partyMembers = 5;

            //Console.WriteLine($"\n총 골드: {totalGold}");
            //Console.WriteLine($"파티원: {partyMembers}");
            //Console.WriteLine($"1인당 골드: {totalGold / partyMembers}");
            //Console.WriteLine($"남은 골드: {totalGold % partyMembers}");

            // 연습문제 4 던전 입장 가능 여부
            //int playerLevel = 35;
            //int requiredLevel = 30;
            //bool hasKey = true;
            //int currentHP = 60;
            //int maxHP = 100;

            //Console.WriteLine("=== 던전 입장 조건 ===");

            //bool inputLevel= playerLevel >= requiredLevel;
            //Console.WriteLine($"레벨 조건 (30 이상): {inputLevel}");

            //Console.WriteLine($"열쇠 보유: {hasKey && true}");

            //bool requiredHp = (maxHP / 2) <= currentHP;
            //Console.WriteLine($"체력 조건 (50% 이상): {requiredHp}");
            //Console.WriteLine($"입장 가능: {inputLevel && hasKey && requiredHp}");

            // 연습문제 5 상점 할인 계산기
            //int originalPrice = 5000;
            //bool isVIP = true;
            //bool hasCoupon = true;

            //int VipPrice = 0; // VIP 적용만 한 가격
            //int CpPrice = 0; // 쿠폰만 적용한 가격
            //int price = 0; // 최종 가격
            //Console.WriteLine($"원가: {originalPrice}골드");

            //if (isVIP && hasCoupon)
            //{

            //    VipPrice = (int)(originalPrice * 0.8);
            //    CpPrice = VipPrice - 500;
            //    price = CpPrice;

            //}
            //else if (isVIP == true && hasCoupon != true)
            //{
            //    VipPrice = (int)(originalPrice * 0.8);
            //}
            //else if (isVIP != true && hasCoupon != false)
            //{
            //    CpPrice -= 500;
            //}

            //Console.WriteLine($"VIP 할인 (20%): {VipPrice}골드");
            //Console.WriteLine($"쿠폰 할인 (-500): {CpPrice}골드");

            //if (isVIP && hasCoupon)
            //{
            //    Console.WriteLine($"최종 가격: {price}골드");
            //}

        }
    }
}
