using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Runtime.InteropServices;

namespace 대장장이_키우기
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 랜덤
            Random rand = new Random();

            Console.WriteLine(" 대장장이 키우기 ");

            int pmoney = 100;
            int input;
            int rnd;
            int SSS수량 = 0;
            int SS수량 = 0;
            int S수량 = 0;
            int A수량 = 0;
            int B수량 = 0;
            int C수량 = 0;



            Thread.Sleep(500);

            // 무한반복
            while (true)
            {
                Console.Clear();
                Console.WriteLine("1. 나무캐기");
                Console.WriteLine("2. 장비뽑기");
                Console.WriteLine("3. 인벤토리");
                Console.WriteLine("4. 나가기");
                Console.Write("입력 : ");
                input = int.Parse(Console.ReadLine()); // input에 키로 눌린 숫자 담기

                if(input == 1) // 나무 캐기 화면
                {
                    while (true)
                    {
                        Console.WriteLine("나무캐기(엔터)");
                        Console.WriteLine("뒤로가기 x");

                        string str = Console.ReadLine();

                        pmoney += 100;
                        Console.WriteLine("소지금 : " + pmoney);
                        if (str == "x")
                        {
                            Console.WriteLine("뒤로가기");
                            break;
                        }
                    }
                }
                else if (input == 2)
                {
                    //장비 뽑기
                    if(pmoney >= 1000) // 돈이 있는지 확인후 뽑기
                    {
                        pmoney -= 1000;

                        //20번 뽑기
                        for (int i = 1; i <= 20; i++)
                        {
                            rnd = rand.Next(1, 101);

                            if(rnd == 1) // 1%
                            {
                                Console.WriteLine("도끼등급 SSS");
                                SSS수량++;
                            }
                            else if (rnd >= 2 && rnd <= 6) // 1%
                            {
                                Console.WriteLine("도끼등급 SS");
                                SS수량++;
                            }
                            else if (rnd >= 7 && rnd <= 17) // 10%
                            {
                                Console.WriteLine("도끼등급 S");
                                S수량++;
                            }
                            else if (rnd >= 18 && rnd <= 38) // 20%
                            {
                                Console.WriteLine("도끼등급 A");
                                A수량++;
                            }
                            else if (rnd >= 39 && rnd <= 69) // 20%
                            {
                                Console.WriteLine("도끼등급 B");
                                B수량++;
                            }
                            else
                            {
                                Console.WriteLine("도끼등급 C");
                                C수량++;
                            }
                            Thread.Sleep(500);
                        }
                    }
                    else
                    {
                        Console.WriteLine("현재 잔액 : " + pmoney);
                        Console.WriteLine("돈이 부족합니다. \n");
                        Thread.Sleep(1000);
                    }
                }
                else if (input == 3)
                {
                    Console.WriteLine("인벤토리 내역");
                    Console.WriteLine("-----------------------");
                    Console.WriteLine($"SSS 갯수: {SSS수량}");
                    Console.WriteLine($"SSS 갯수: {SS수량}");
                    Console.WriteLine($"SSS 갯수: {S수량}");
                    Console.WriteLine($"SSS 갯수: {A수량}");
                    Console.WriteLine($"SSS 갯수: {B수량}");
                    Console.WriteLine($"SSS 갯수: {C수량}");

                    Thread.Sleep(2000);
                }
                else if (input == 4)
                {
                    Console.WriteLine("게임을 나갑니다.");
                    Environment.Exit(0);
                }


            }
        }
    }
}
