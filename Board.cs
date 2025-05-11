using Raylib_cs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gomoku
{
    public enum State
    {
        Black = -1,
        Blank = 0,
        White = 1
    }

    public class Board
    {

        State[,] Grid { get; set; }
        bool Player { get; set; } //true - white, false - black

        private int cellSize;

        public Board(int boardSize, int cellSize)
        {

            Grid = new State[boardSize, boardSize];
            Player = true; //white starts
            this.cellSize = cellSize;

            SetEmptyGrid();

        }

        public void SetEmptyGrid()
        {
            for (int i = 0; i < Grid.GetLength(0); i++)
            {
                for (int j = 0; j < Grid.GetLength(1); j++)
                {
                    Grid[i,j] = State.Blank;
                }
            }
        }

        public void DrawGrid()
        {
            for (int i = 0; i < Grid.GetLength(0); i++)
            {
                for (int j = 0; j < Grid.GetLength(1); j++)
                {
                    int pointX = i * cellSize / 2 + cellSize / 2;
                    int pointY = j * cellSize / 2 + cellSize / 2;

                    switch (Grid[i,j])
                    {
                        case State.Black:
                            Raylib.DrawCircle(pointX, pointY, (float)cellSize / 10, Color.Black);
                            break;
                        case State.Blank:
                            Raylib.DrawCircle(pointX, pointY, (float)cellSize / 10, Color.Yellow);
                            break;
                        case State.White:
                            Raylib.DrawCircle(pointX, pointY, (float)cellSize / 10, Color.White);
                            break;
                        default:
                            break;
                    }

                    
                }
            }
        }



    }
}
