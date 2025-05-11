using Raylib_cs;

namespace Gomoku
{
    public static class Program
    {
        public static void Main()
        {
            int WindowSize = 800;
            int boardSize = 15;


            Raylib.InitWindow(WindowSize + boardSize*2, WindowSize + boardSize*2, "Hello World");
            Board board = new Board(boardSize, boardSize*7);

            while (!Raylib.WindowShouldClose())
            {
                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.Gray);

                board.DrawGrid();

                Raylib.EndDrawing();
            }

            Raylib.CloseWindow();
        }
    }
}

