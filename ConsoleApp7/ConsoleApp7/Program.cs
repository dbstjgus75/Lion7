using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {
        [DllImport("msvcrt.dll")]
        static extern int _getch(); //c언어 함수 가져옴

        static void Main(string[] args)
        {

            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            // 배열문

            // 방법 1
            //int[] scores = new int[5]; // 5개의 사물함을 준비

            //// 방법 2
            //int[] numbers = new int[] { 10, 20, 30, 40, 50 };

            ////방법 3
            //int[] values = { 1, 2, 3, 4, 5 };

            ////4번쨰
            //scores[0] = 1;
            //scores[1] = 2;
            //scores[2] = 3;
            //scores[3] = 4;
            //scores[4] = 5;

            //for(int i = 0; i < scores.Length; i++)
            //{
            //    Console.WriteLine(scores[i]);
            //}

            //인벤토리 시스템 (최대 5개)
            //string[] inventory = new string[5];
            //int count = 0; // 아이템 갯수

            //Console.WriteLine("인벤토리에 저장할 아이템을 추가해 주세요(최대 5개, Enter 입력 시 종료)");

            //while (count < inventory.Length)
            //{
            //아이템 추가

            //    Console.Write("아이템 이름 : ");

            //    inventory[count] = Console.ReadLine();
            //    count++;

            //    // 콘솔 키 입력받음
            //    ConsoleKeyInfo keyInfo = Console.ReadKey(true);
            //    if (keyInfo.Key == ConsoleKey.Enter)
            //    {
            //        break;
            //    }

            //}


            //인벤토리 출력
            //Console.WriteLine("=== 인벤토리 ===");

            //for (int i = 0; i < inventory.Length; i++)
            //{
            //    Console.WriteLine($"[{i+1}] {inventory[i]}");
            //}

            // === 캐릿터 스탯 ===
            //HP : 100
            //MP : 50
            //공격력 : 80
            //방어력 : 60
            //민첩: 45 

            //int[] 캐릭터스텟 = { 100, 50, 80, 60, 45 };
            //string[] 캐릭터스텟설명 = { "HP", "MP", "공격력", "방어력", "민첩" };


            //Console.WriteLine("=== 캐릭터 스텟 ===");
            //for (int i = 0; i < 캐릭터스텟.Length; i++)
            //{
            //    Console.WriteLine($"{캐릭터스텟설명[i]}: {캐릭터스텟[i]}");
            //}

            //=== 일일 퀘스트 진행도 ===
            //고블린: 5 / 5 ✅ 완료
            //오크: 3 / 5 ⏳ 진행중
            //슬라임: 8 / 5 ✅ 완료
            //드래곤: 2 / 5 ⏳ 진행중
            //좀비: 7 / 5 ✅ 완료

            //Console.WriteLine("=== 일일 퀘스트 진행도 ===");

            //string[] moster = { "고블린", "오크", "슬라임", "드래곤", "좀비" };
            //int mosterAllCatch = 5; // 총 몬스터 수
            //int[] mosterCount = {5, 3, 8, 2, 7}; //잡은 몬스터 수

            //for (int i = 0; i < moster.Length; i++)
            //{
            //    if (mosterCount[i] > mosterAllCatch)
            //    {
            //        Console.WriteLine($"{moster[i]}: {mosterCount[i]} / {mosterAllCatch} ✅ 완료");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{moster[i]}: {mosterCount[i]} / {mosterAllCatch} ⏳ 진행중");
            //    }

            //}

            //=== 일일 퀘스트 진행도 ===
            //고블린: 5 / 5 ✅ 완료
            //오크: 3 / 5 ⏳ 진행중
            //슬라임: 8 / 5 ✅ 완료
            //드래곤: 2 / 5 ⏳ 진행중
            //좀비: 7 / 5 ✅ 완료

            //Console.WriteLine("=== 일일 퀘스트 진행도 ===");

            //string[] mosterTypes = { "고블린", "오크", "슬라임", "드래곤", "좀비" };
            //int requiredKills = 5; // 총 몬스터 수
            //int[] dailyKills = { 5, 3, 8, 2, 7 }; //잡은 몬스터 수

            //for (int i = 0; i < dailyKills.Length; i++)
            //{
            //    string status = dailyKills[i] >= requiredKills ? "✅ 완료" : "⏳ 진행중";
            //    Console.WriteLine($"{mosterTypes[i]}: {dailyKills[i]} / {requiredKills} {status}");

            //}

            //int[] scores = { 85, 92, 78, 95, 88 }; // 총 학생 점수
            //int min = scores[0]; // 최저점
            //int max = scores[0]; // 최고점
            //int sum = 0; // 합계

            ////배열 길이
            //Console.WriteLine("총 점수 개수: " + scores.Length);

            ////배열 순회
            //Console.WriteLine("개별 점수");
            //for (int i = 0; i < scores.Length; i++)
            //{
            //    Console.WriteLine($"플레이어 {i + 1} : {scores[i]}점");
            //}

            ////합계 계산
            //for (int i = 0; i < scores.Length; i++)
            //{
            //    sum += scores[i];
            //}

            //Console.WriteLine($"총점: {sum}점");
            //Console.WriteLine($"평균: {(float)sum / (float)scores.Length}점");


            ////최고점 찾기
            //for (int i = 0; i < scores.Length; i++)
            //{
            //    if (min == 0 || min < scores[i])
            //    {
            //        min = scores[i];
            //    }
            //}
            ////최저점 찾기
            //for (int i = 0; i < scores.Length; i++)
            //{
            //    if (max == 0 || max > scores[i])
            //    {
            //        max = scores[i];
            //    }
            //}

            //Console.WriteLine($"최저점: {min}점, 최고점: {max}점");

            ////Array 클래스 메서드 활용
            //Console.WriteLine("=== Array 메서드 ===");

            ////정렬
            //int[] sortedScores = (int[])scores.Clone(); // 복사본 생성
            //Array.Sort(sortedScores);
            //Console.WriteLine("정렬 후: ");

            //for(int i = 0; i < sortedScores.Length; i++)
            //{
            //    Console.Write(sortedScores[i] + " ");
            //}

            ////역순정렬
            //Array.Reverse(sortedScores);
            //Console.Write("\n역순: \n");

            //for (int i = 0; i < sortedScores.Length; i++)
            //{
            //    Console.Write(sortedScores[i] + " ");
            //}

            //Console.WriteLine("\nforeach문 ");

            ////반복문 foreach
            //foreach (int i in sortedScores)
            //{
            //    Console.Write(i + " ");
            //}

            ////검색
            //int searchScore = 92;
            //int index = Array.IndexOf(sortedScores, searchScore); //특정 인덱스 검색 함수
            //Console.WriteLine($"\n{searchScore}점의 위치 인덱스: {index}");
            //Console.WriteLine("찾은값: " + scores[index]);

            //다차원 배열

            //int[,] array = new int[3, 4];

            //// 전체 요소 개수
            //int totalElements = array.Length;  // 12 (3 x 4)

            //// 특정 차원의 길이
            //int rows = array.GetLength(0);     // 3 (행 개수)
            //int cols = array.GetLength(1);     // 4 (열 개수)

            //// Rank: 배열의 차원 수
            //int dimensions = array.Rank;       // 2

            //=== 좌석 배치도 ===

            //[A1][A2][A3]
            //[B1][B2][B3]
            //[C1][C2][C3]

            //string[,] seats =
            //{
            //    {"A1", "A2", "A3" },
            //    {"B1", "B2", "B3"},
            //    {"C1", "C2", "C3"}
            //};


            //for (int i = 0; i < seats.GetLength(0); i++)
            //{
            //    for (int j = 0; j < seats.GetLength(1); j++)
            //    {
            //        Console.Write($"[{seats[i, j]}]");
            //    }
            //    Console.WriteLine();
            //}

            //첫 번째 좌석: A1
            //중앙 좌석: B2
            //마지막 좌석: C3

            //Console.WriteLine("첫번째 좌석: " + seats[0, 0]);
            //Console.WriteLine("중앙 좌석: " + seats[1, 1]);
            //Console.WriteLine("마지막 좌석: " + seats[2, 2]);

            //2D 게임맵
            //int[,] map = new int[5, 5]
            //{
            //  { 0,0,1,0,0},
            //  { 0,2,1,0,3},
            //  { 0,0,1,0,0},
            //  { 1,1,1,0,0},
            //  { 0,0,0,0,9},
            //};

            //Console.WriteLine("==던전맵==");
            //Console.WriteLine("0: 통로 1: 벽 2: 몬스터 3: 보물 9: 출구\n");
            ////Console.OutputEncoding = Encoding.UTF8;

            ////맵 출력
            //for (int y = 0; y < map.GetLength(0); y++)
            //{
            //    for (int x = 0; x < map.GetLength(1); x++)
            //    {
            //        switch (map[y, x])
            //        {
            //            case 0:
            //                Console.Write("⬜ ");
            //                break;
            //            case 1:
            //                Console.Write("⬛ ");
            //                break;
            //            case 2:
            //                Console.Write("👹 ");
            //                break;
            //            case 3:
            //                Console.Write("💎 ");
            //                break;
            //            case 9:
            //                Console.Write("🚪 ");
            //                break;
            //        }

            //    }
            //    Console.WriteLine();
            //}

            //=== 성적표 ===

            //이름  국어 영어  수학 과학  평균
            //━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
            //김철수 85  90  88  92  88.8
            //이영희 78  85  90  87  85.0
            //박민수 92  88  95  90  91.3

            //=== 과목별 평균 ===
            //국어: 85.0점
            //영어: 87.7점
            //수학: 91.0점
            //과학: 89.7점

            //string[] studentName = new string[] { "김철수", "이영희", "박민수" };
            //string[] subjects = { "국어", "영어", "수학", "과학" };

            //int[,] scores =
            //{
            //    // 국어, 영어, 수학, 과학
            //    {85, 90, 88, 92 },
            //    {78, 85, 90, 87 },
            //    {92, 88, 95, 90 }
            //};

            //Console.WriteLine("=== 성적표 ===");
            //Console.WriteLine("이름  국어 영어 수학 과학 평균");
            //Console.WriteLine("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━");

            //for (int i = 0; i < scores.GetLength(0); i++)
            //{
            //    int sum = 0;

            //    Console.Write(studentName[i] + " ");
            //    for (int j = 0; j < scores.GetLength(1); j++)
            //    {
            //        sum += scores[i, j];
            //        Console.Write(scores[i, j] + " ");
            //    }
            //    double average = (double)sum / scores.GetLength(1);
            //    Console.WriteLine($"{average:F1}");
            //}

            //Console.WriteLine("\n=== 과목별 평균 ===");
            //// 과목별 평균
            //for (int subject = 0; subject < scores.GetLength(1); subject++) // 4
            //{
            //    int sum = 0;
            //    for (int student = 0; student < scores.GetLength(0); student++) // 3
            //    {
            //        sum += scores[student, subject];
            //    }
            //    double avg = (double)sum / scores.GetLength(0);
            //    Console.WriteLine($"{subjects[subject]}: {avg:F1}점");
            //}

            //for (int subject = 0; subject < subjects.Length; subject++)
            //{
            //    int sum = 0;
            //    for (int student = 0; student < scores.GetLength(0); student++)
            //    {
            //        sum += scores[student, subject];
            //    }
            //    double average = (double)sum / scores.GetLength(0);
            //    Console.WriteLine($"{subjects[subject]}: {average:F1}점");
            //}

            // 가변 배열
            //string[][] raid = new string[3][];

            //raid[0] = new string[] { "전사", "힐러", "마법사", "궁수" };  //4명
            //raid[1] = new string[] { "도적", "전사", "힐러" };            //3명
            //raid[2] = new string[] { "마법사", "궁수", "힐러", "전사", "탱커" }; //5명

            //Console.WriteLine("=== 레이드 파티 구성 ===");
            //for (int i = 0; i < raid.Length; i++)
            //{
            //    Console.WriteLine($"파티 {i + 1} ({raid[i].Length}명):");
            //    for (int j = 0; j < raid[i].Length; j++)
            //    {
            //        Console.WriteLine($" - {raid[i][j]}");
            //    }
            //}

            //List<T> 컬렉션 완벽 가이드
            //🎯 List<T> 란?
            //List<T> 는 C#에서 가장 많이 사용되는 동적 배열(Dynamic Array) 컬렉션입니다.
            //T는 제네릭 타입 매개변수로, 저장할 데이터 타입을 지정합니다
            //크기가 자동으로 조절됩니다
            //System.Collections.Generic 네임스페이스에 포함

            //4.6 List < T > -동적 배열

            //🎯 핵심 개념
            //List<T> 는 크기가 자동으로 조절되는 동적 배열입니다.

            //📚 List vs 배열
            //| 특징 | 배열 | List<T> |
            //| ------| ------| ---------|
            //| 크기 | 고정 | 자동 조절 |
            //| 추가 / 삭제 | 불가 | 가능 |
            //| 성능 | 약간 빠름 | 약간 느림 |
            //| 편의성 | 기본 | 다양한 메서드 제공 |

            // 선언 방법
            //List<int> numbers = new List<int>();           // 빈 리스트
            //List<string> names = new List<string>();       // 문자열 리스트
            //List<float> prices = new List<float>();        // 실수 리스트

            // 초기값과 함께 선언
            //List<int> scores = new List<int> { 85, 90, 78, 95 };
            //List<string> items = new List<string> { "검", "방패", "포션" };

            // C# 3.0 이후 간단한 초기화
            //var players = new List<string> { "철수", "영희", "민수" };

            //    List<string> items = new List<string>();

            //Add: 끝에 추가
            //    items.Add("회복 포션");
            //    items.Add("마나 포션");

            //    List 생성
            //    List<string> inventory = new List<string>();

            //    Console.WriteLine("=== 도적 인벤토리 시스템 ===");

            //    //아이템 추가 (Add)
            //    inventory.Add("회복 포션");
            //    inventory.Add("마나 포션");
            //    inventory.Add("강철 검");

            //    Console.WriteLine("아이템 3개 추가");

            //    //현재 인벤토리
            //    Console.WriteLine($"인벤토리 ({inventory.Count}개):");

            //    for (int i = 0; i < inventory.Count; i++)
            //    {
            //        Console.WriteLine($"[{i + 1}] {inventory[i]}");
            //    }

            //    특정 위치에 추가(Insert)
            //    inventory.Insert(1, "전설 검");

            //    Console.WriteLine();

            //    for (int i = 0; i < inventory.Count; i++)
            //    {
            //        Console.WriteLine($"[{i + 1}] {inventory[i]}");
            //    }

            //    // 아이템 제거 (Remove)
            //    inventory.Remove("회복 포션");
            //    Console.WriteLine();

            //    for (int i = 0; i < inventory.Count; i++)
            //    {
            //        Console.WriteLine($"[{i + 1}] {inventory[i]}");
            //    }

            //    //인덱스로 제거 (RemoveAt)
            //    inventory.RemoveAt(0);
            //    Console.WriteLine();

            //    for (int i = 0; i < inventory.Count; i++)
            //    {
            //        Console.WriteLine($"[{i + 1}] {inventory[i]}");
            //    }


            // 딕셔너리

            //Dictionary<string, int> stats = new Dictionary<string, int>();

            ////데이터 추가
            //stats.Add("HP", 150);
            //stats.Add("MP", 80);
            //stats.Add("공격력", 75);
            //stats.Add("방어력", 50);
            //stats.Add("민첩", 60);

            //Console.WriteLine("=== 캐릭터 스탯 ===");

            //foreach (KeyValuePair<string, int> stat in stats)
            //{
            //    Console.WriteLine($"{stat.Key}: {stat.Value}");
            //}

            ////키 존재 확인
            //string searchStat = "방어력";

            //if (stats.ContainsKey(searchStat))
            //{
            //    Console.WriteLine("\n" + stats[searchStat]);
            //}
            //else
            //{
            //    Console.WriteLine("\n해당스텟이 없습니다.");
            //}


            //딕셔너리 컬렉션 이용해 구현
            //Dictionary<string, int> stores = new Dictionary<string, int>();
            //int myCoin = 600;
            //stores.Add("회복 포션", 50);
            //stores.Add("마나 포션", 40);
            //stores.Add("강철 검", 500);
            //stores.Add("가죽 갑옷", 300);
            //stores.Add("마법 반지", 1000);

            //Console.Write($"=== 상점 아이템 ===\t 내 골드:{myCoin}\n");
            //foreach (KeyValuePair<string, int> store in stores)
            //{
            //    Console.WriteLine($"{store.Key}: {store.Value}");
            //}

            //Console.Write("구매할 항목을 입력하세요 : ");
            //string buyItem = Console.ReadLine();

            //if (stores.ContainsKey(buyItem))
            //{
            //    int price = stores[buyItem];

            //    if (myCoin >= price)
            //    {

            //        myCoin -= price;
            //        Console.WriteLine($"'{buyItem}' 구매 성공!");
            //        Console.WriteLine($"남은 골드 : {myCoin} Gold");
            //    }
            //    else
            //    {
            //        Console.WriteLine("골드가 부족합니다.");
            //    }
            //}

            Console.SetWindowSize(80, 25); // 콘솔 창 크기 설정
            Console.SetBufferSize(80, 25); // 버퍼 크기도 동일하게 설정

            string[] player = new string[]
            {
                "->",
                ">>>",
                "->"
            }; //배열 문자열로 그리기

            // 미사일 위치
            List<int> missileXs = new List<int>();
            List<int> missileYs = new List<int>();


            // 플레이어 위치
            int playerX = 0;
            int playerY = 12;


            ConsoleKeyInfo keyInfo; //키정보

            Console.CursorVisible = false;//콘솔창 커서 안보이게 하기

            //Sleep() 1000 1초동안 프로그램을 잠시 멈춤

            //지연방법 시간을 계산해서 1초 루프

            //while (true)
            //{
            //    int dwTime = Environment.TickCount; // 1/1000 초가 흐릅니다.

            //    if(dwTime + 1000 < Environment.TickCount) //Sleep 방법은 게임이 멈추고 시작하는데 이 루프문은 실행중이면서 1초 늦게 실행되기에 최적화에 좋음
            //    {
            //        //현재 시간 세팅
            //        dwTime = Environment.TickCount;
            //        Console.WriteLine("1초루프 이프문");
            //    }

            //}
            
            int dwTime = Environment.TickCount; // 1/1000 초가 흐릅니다.

            while (true)
            {

                //1초루프
                if (dwTime + 50 < Environment.TickCount)
                {
                    //현재 시간 세팅
                    dwTime = Environment.TickCount;

                    Console.Clear();

                    //키영역
                    int pressKey; // 정수형 변수 선언 키값 받을거임

                    if (Console.KeyAvailable) // 키가 눌렸는지 체크
                    {
                        pressKey = _getch(); //아스키값 왼쪽 오른쪽

                        switch (pressKey)
                        {

                            case 72:  //위쪽방향 아스키코드                    
                                playerY--;
                                if (playerY < 1)
                                    playerY = 1;
                                break;
                            case 75:
                                //왼쪽 화살표키
                                playerX--;
                                if (playerX < 0)
                                    playerX = 0;
                                break;
                            case 77:
                                //오른쪽
                                playerX++;
                                if (playerX > 75)
                                    playerX = 75;
                                break;
                            case 80: //아래
                                playerY++;
                                if (playerY > 21)
                                    playerY = 21;
                                break;
                            case 32: // 스페이스바
                                
                                missileXs.Add(playerX);
                                missileYs.Add(playerY);
                                break;

                        }
                    }

                   

                    for (int i = 0; i < player.Length; i++)
                    {
                        //콘솔좌표 설정 플레이어X 플레이어Y
                        Console.SetCursorPosition(playerX, playerY + i);

                        //문자열배열 출력
                        Console.WriteLine(player[i]);
                    }

                    for (int i = 0; i < missileXs.Count; i++)
                    {
                        missileXs[i]++;

                        if (missileXs[i] < 75) // 밖에 안 빠져나간 경우
                        {
                            Console.SetCursorPosition(missileXs[i], missileYs[i] + 1);
                            Console.WriteLine("--D");
                        }
                        else
                        {
                            missileXs.RemoveAt(i);
                            missileYs.RemoveAt(i);
                        }

                    }

                    //if (shoot) // 발사중일 떄
                    //{
                    //    if(missileX < 75)
                    //    {
                    //        Console.SetCursorPosition(missileX, missileY + 1);
                    //        Console.WriteLine(missile);
                    //        missileX++;
                    //    }
                    //    else
                    //    {
                    //        shoot = false;
                    //    }


                    //}




                }

              



            }





        }
    }
}


//if (Console.KeyAvailable) //키가 눌렸을때 true
//{
//    keyInfo = Console.ReadKey(true); //키 입력 받기 

//    switch (keyInfo.Key)
//    {
//        case ConsoleKey.UpArrow: if (playerY > 0) playerY--; break;
//        case ConsoleKey.DownArrow: if (playerY < Console.WindowHeight - 1) playerY++; break;
//        case ConsoleKey.LeftArrow: if (playerX > 0) playerX--; break;
//        case ConsoleKey.RightArrow: if (playerX < Console.WindowWidth - 1) playerX++; break;
//        case ConsoleKey.Spacebar: Console.Write("미사일키"); break;
//        case ConsoleKey.Escape: return; //ESC키로 종료 
//    }

//}