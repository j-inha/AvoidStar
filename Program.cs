using System;
using System.Threading;

namespace JIH
{
    class Program
    {
        static void Main(string[] args)
        {
            // 다음 코드는 콘솔 창에 Hello World를 띄우는 코드입니다.
            //Console.WriteLine("Hello, World!");
            Study.MyProgram.Play();

        }
    }
}

namespace Study
{
    class MyProgram
    {

        public static void Play()
        {
            int vertical = 30;
            int horizontal = 30;
            // 게임 시작
            // 타이틀 변경
            Console.Title = "별 피하기";
            // 콘솔 크기 변경
            Console.SetWindowSize(vertical, horizontal);
            // 콘솔창의 아래 중앙에 캐릭터가 위치하게 하는것
            // -> 콘솔의 x좌표 14, y좌표 28에 그려줘
            Console.SetCursorPosition(14, 28);
            Console.Write("◆");

            // 콘솔 커서를 안보이게 해줘 C#언어 visual 2022 miscrosoft c#
            Console.CursorVisible = false;
            //몬스터의 수
            int enemyCount = 6;

            Random random = new Random();
            int x = vertical / 2, y = horizontal - 2; //player position
            bool playerDead = false;
            bool Enermy = false; //star alive : true / star dead : false

            //별이 다중으로 내려오게 하는 방법
            //int[] Exs = new int[] { random.Next(0, 28), random.Next(0, 28) };
            int[] Exs = new int[enemyCount];
            int[] Exy = new int[enemyCount];

            for (int i = 0; i < Exs.Length; i++)
            {
                Exs[i] = random.Next(0, 28);
            }
            for (int i = 0; i < Exy.Length; i++)
            {
                Exy[i] = 0;
            }


            while (true)
            {

                Console.Clear();
                Console.SetCursorPosition(x, y);
                // draw player position
                Console.Write("◆");


                //동작키
                if (Console.KeyAvailable)
                {
                    var key = Console.ReadKey(true).Key;
                    Console.SetCursorPosition(x, y);
                    Console.Write("  ");

                    // change player position
                    if (key == ConsoleKey.UpArrow)
                    {
                        y--;
                        if (y < 0) y = 0;

                    }
                    if (key == ConsoleKey.W)
                    {
                        y--;
                        if (y < 0) y = 0;

                    }

                    //아래로이동
                    if (key == ConsoleKey.DownArrow)
                    {
                        y++;
                        if (y > 30) y = 30;

                    }
                    if (key == ConsoleKey.X)
                    {
                        y++;
                        if (y > vertical) y = vertical;

                    }

                    //왼쪽이동
                    if (key == ConsoleKey.LeftArrow)
                    {
                        x--;
                        if (x < 0) x = 0;

                    }
                    if (key == ConsoleKey.A)
                    {
                        x--;
                        if (x < 0) x = 0;

                    }
                    //오른쪽이동
                    if (key == ConsoleKey.RightArrow)
                    {
                        x++;
                        if (x > horizontal) x = horizontal;

                    }
                    if (key == ConsoleKey.D)
                    {
                        x--;
                        if (x < 0) x = 0;

                    }



                }
                //

                if (!Enermy)
                {
                    Enermy = true;
                }

                for (int i = 0; i < Exs.Length; i++)
                {
                    Console.SetCursorPosition(Exs[i], Exy[i]);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("★");
                    Console.ResetColor();
                }

                if (Enermy)
                {
                    for (int i = 0; i < Exs.Length; i++)
                    {
                        Exy[i] = Exy[i] + random.Next(0, 2); // 별들의 개별 속도 조절
                    }
                }
                //개별적으로 하늘에서 떨어지는 위치 정하기
                for (int i = 0; i < Exs.Length; i++)
                {
                    if (Exy[i] >= 28)
                    {
                        Exs[i] = random.Next(0, 28);
                        Exy[i] = 0;
                    }
                }

                for (int i = 0; i < Exs.Length; i++)
                {
                    if (x == Exs[i] && y == Exy[i])
                    {
                        Console.SetCursorPosition(10, 15);
                        Console.WriteLine("game over");
                        Thread.Sleep(50);
                        playerDead = true;
                        break;


                    }
                }
                if (playerDead)
                {

                    Console.WriteLine("게임을 재시작 하려면 z키를 누르세요");
                    var keys = Console.ReadKey(true).Key;

                    if (keys == ConsoleKey.Z)
                    {
                        Play();
                    }
                    else { break; }

                }
                   





                //게임을 꺼버릴수도있고 다시 계속 재생할 수도 있음
                Thread.Sleep(50);
            }

            Console.ReadKey();//무엇인가 입력하면 다음코드가 실행
        }
    }
}
