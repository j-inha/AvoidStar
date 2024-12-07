using System;

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
            // 게임 시작
            // 타이틀 변경
            Console.Title = "별 피하기";
            // 콘솔 크기 변경
            Console.SetWindowSize(30, 30);
            // 콘솔창의 아래 중앙에 캐릭터가 위치하게 하는것
            // -> 콘솔의 x좌표 14, y좌표 28에 그려줘
            Console.SetCursorPosition(14, 28);
            Console.Write("◆");

            // 콘솔 커서를 안보이게 해줘 C#언어 visual 2022 miscrosoft c#
            Console.CursorVisible = false;

            int x = 14, y = 28;

            while (true)
            {
                //Console.Clear();    
                Console.SetCursorPosition(x, y);
                // draw player position
                Console.Write("◆");



                if (Console.KeyAvailable)
                {
                    var key = Console.ReadKey(true).Key;
                    Console.SetCursorPosition(x, y);
                    Console.Write("  ");

                    // change player position
                    if(key == ConsoleKey.UpArrow)
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
                        if (y > 30) y = 30;

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
                        if (x > 30) x = 30;

                    }
                    if (key == ConsoleKey.D)
                    {
                        x--;
                        if (x < 0) x = 0;

                    }



                }

            }

            Console.ReadKey();
        }
    }
}
