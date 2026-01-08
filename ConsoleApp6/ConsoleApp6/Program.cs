using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Text;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            //int i = 0;

            //while (i < 5)
            //{
            //    Console.WriteLine(i);
            //    i++; // 증감
            //}

            //int countDown = 10;
            //while (countDown > 0)
            //{
            //    Console.WriteLine(countDown);
            //    Thread.Sleep(500);
            //    countDown--;
            //}

            // 예제 3 합계 구하기 (1+2+3+4+5)
            //int sum = 0;
            //int i = 1;

            //Console.WriteLine("\n === 예제 3: 합계 구하기 ===");
            //while (i <= 5)
            //{
            //    sum += i;
            //    Console.Write(i);
            //    if (i != 5)
            //    {
            //        Console.Write(" + ");
            //    }

            //    i++;
            //}
            //Console.WriteLine(" = " + sum);

            // 예제 4: 특정 값까지 반복
            //Console.WriteLine("\n=== 예제 4: 목표 달성하기 ===");
            //int coins = 0;
            //int target = 50;
            //int day = 0;

            //while (coins < target)
            //{
            //    day++;
            //    coins += 10;
            //    Console.WriteLine($"{day}일차: 코인 {coins}개");
            //}

            //Console.WriteLine($"?? 목표 달성! {day}일 걸렸습니다.");

            //int x = 5;
            //do
            //{
            //    Console.WriteLine("최소 한번 실행");
            //    x--;
            //} while (x > 0);

            ////예제 5 중식 메뉴판 선택
            //string choice;
            //int totalPrice = 0;

            //do
            //{
            //    //메뉴출력
            //    Console.WriteLine("메뉴판");
            //    Console.WriteLine("1. 짜장면 - 5,000원");
            //    Console.WriteLine("2. 짬뽕 - 6,000원");
            //    Console.WriteLine("3. 탕수육 - 15,000원");
            //    Console.WriteLine("4. 볶음밥 - 7,000원");
            //    Console.WriteLine("0. 주문완료");
            //    Console.WriteLine("======================");
            //    Console.WriteLine("메뉴 번호를 선택하세요: ");

            //    choice = Console.ReadLine();

            //    //메뉴 선택 처리
            //    switch (choice)
            //    {
            //        case "1":
            //            Console.WriteLine("짜장면 추가! (+5000원)");
            //            totalPrice += 5000;
            //            break;
            //        case "2":
            //            Console.WriteLine("짬뽕 추가! (+6000원)");
            //            totalPrice += 6000;
            //            break;
            //        case "3":
            //            Console.WriteLine("탕수육 추가! (+15000원)");
            //            totalPrice += 15000;
            //            break;
            //        case "4":
            //            Console.WriteLine("볶음밥 추가! (+7000원)");
            //            totalPrice += 7000;
            //            break;
            //        case "0":
            //            Console.WriteLine("주문을 완료합니다.");
            //            break;

            //    }

            //    //0번 선택 전까지
            //    if (choice != "0")
            //    {
            //        Console.WriteLine($"현재 총액: {totalPrice:N0}원");
            //    }

            //} while (choice != "0"); // 0을 입력할 떄까지 반복

            //for (int i = 0; i <= 10; i++)
            //{
            //    if (i == 5)
            //        break;
            //    Console.WriteLine(i);
            //}

            //for (int i = 0; i <= 10; i++)
            //{
            //    if (i == 5)
            //    {
            //        continue;
            //    }
            //        Console.WriteLine(i);
            //}

            //for (int i =1; i <= 10; i++)
            //{
            //    if (i % 2 == 0) continue;
            //    Console.WriteLine(i); // 홀수만 출력
            //}

            //int n = 1;

            //천마귀환:
            //Console.WriteLine("나야 들기름");

            //if (n <= 5)
            //{
            //    Console.WriteLine(n);
            //    n++;
            //    goto 천마귀환; //레이블로 이동
            //}

            // 예제 1: 사각형 그리기
            //⬜ ⬜ ⬜
            //⬜ ⬜ ⬜
            //⬜ ⬜ ⬜
            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write("⬜");
            //    }
            //    Console.WriteLine();
            //}

            // 예제 2: 숫자표 만들기
            //1 2 3
            //1 2 3
            //1 2 3
            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 1; j <= 3; j++)
            //    {
            //        Console.Write(j + " ");
            //    }
            //    Console.WriteLine();
            //}

            //=== 예제 3: 좌표찍기 ===
            //(0, 0)(1, 0)(2, 0)
            //(0, 1)(1, 1)(2, 1)
            //(0, 2)(1, 2)(2, 2)

            //for (int y = 0; y < 3; y++)
            //{
            //    for (int x = 0; x < 3; x++)
            //    {
            //        Console.Write($"(x: {x}, y: {y})");
            //    }
            //    Console.WriteLine();
            //}

            // 별 찍기
            //for (int i = 0; i < 6; i++)
            //{
            //    for (int j = 0; j < i; j++)
            //    {
            //        Console.Write("⭐");
            //    }
            //    Console.WriteLine();
            //}


            //for (int i = 0; i < 5; i++)
            //{
            //    for (int j = 0; j < 5; j++)
            //    {
            //        if(i <= j)
            //        {
            //            Console.Write("⭐");
            //        }
            //        else
            //        {
            //            Console.Write("  ");
            //        }
            //    }
            //    Console.WriteLine();
            //}

            //=== 예제 6: 곱셈표 ===
            //1×1 = 1 1×2 = 2 1×3 = 3
            //2×1 = 2 2×2 = 4 2×3 = 6
            //3×1 = 3 3×2 = 6 3×3 = 9

            //for (int i = 1; i < 4; i++)
            //{
            //    for (int j = 1; j < 4; j++)
            //    {
            //        Console.Write($"{i} x {j} = {i*j} ");
            //    }
            //    Console.WriteLine();
            //}

            //=== 예제 9: 미니 게임 맵 ===
            //🏠 🟩 🟩 🟩
            //🟩 🟩 🟩 🟩
            //🟩 🟩 🟩 🟩
            //🟩 🟩 🟩 🎯

            //for (int i = 0; i < 4; i++)
            //{
            //    for (int j = 0; j < 4; j++)
            //    {
            //        if (i == 0 && j == 0)
            //        {
            //            Console.Write("🏠 ");
            //        }
            //        else if (i == 3 && j == 3)
            //        {
            //            Console.Write("🎯");
            //        }
            //        else
            //        {
            //            Console.Write("🟩 ");
            //        }
            //    }
            //    Console.WriteLine();
            //}


        }
    }
}
