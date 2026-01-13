using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShootingGame
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.SetWindowSize(80, 25); // 콘솔창 크기 설정
            Console.SetBufferSize(80, 25); // 버퍼 크기도 동일하게 설정 (스크롤 방지)

            Console.CursorVisible = false;

            ConsoleKeyInfo keyInfo;

            while (true)
            {

                if (Console.KeyAvailable) // 키가 눌렸는지 확인
                {
                    keyInfo = Console.ReadKey(true); // 화면에 입력한 키가 보이지 않게 함
                    
                    switch (keyInfo.Key)
                    {
                        case ConsoleKey.UpArrow:
                            Console.WriteLine("위쪽 화살표 키가 눌렸습니다.");
                            break;
                        case ConsoleKey.LeftArrow:
                            Console.WriteLine("왼쪽 화살표 키가 눌렸습니다.");
                            break;
                        case ConsoleKey.RightArrow:
                            Console.WriteLine("오른쪽 화살표 키가 눌렸습니다.");
                            break;
                        case ConsoleKey.DownArrow:
                            Console.WriteLine("아래쪽 화살표 키가 눌렸습니다.");
                            break;
                    }
                    
                }
            }
        }
    }
}
