using Raylib_cs;
using System.Runtime.CompilerServices;

namespace Gomoku
{
    public static class Program
    {
        public static void Main()
        {
            int windowSize = 800;
            int gridSize = 15;
            int cellSize = windowSize / gridSize;


            Raylib.InitWindow(windowSize + cellSize, windowSize + cellSize, "Hello World");
            Board board = new Board(gridSize, cellSize);

            while (!Raylib.WindowShouldClose())
            {
                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.Gray);

                //if (Raylib.IsMouseButtonDown(MouseButton.Left))
                //{
                //    int pointX = Raylib.GetMouseX() * boardSize * 7 / 2 + boardSize * 7 / 2;
                //    int pointY = Raylib.GetMouseY() * boardSize * 7 / 2 + boardSize * 7 / 2;

                //    board.PlaceRock(pointX, pointY);
                //}

                board.DrawGrid();

                Raylib.EndDrawing();
            }

            Raylib.CloseWindow();
        }
    }
}

