using SnakeLib;
using SnakeLibs.DrawSnake;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace SnakeLibs
{
    public class SnakeGame
    {
        public Snake snake;

        public Point Berry;
        public IDrawSnake DrawSnake { get; set; }
        public int WidthOfSnakeBoard { get; set; }
        public int HeightOfSnakeBoard { get; set; }
        public int SquareSideLength { get; set; }
        public bool IsWallHard { get; set; }
        public bool IsBerryEated { get; set; }
        public bool IsGameOver { get; set; }
        public bool IsImmortal { get; set; }
        public int Score { get; set; }
        public int BerryTimeLifeSeconds { get; set; }
        private DateTime DateOfCreateBerry { get; set; }

        public SnakeGame(bool isWallHard, int squareSideLength = 50)
        {
            this.IsWallHard = isWallHard;
            this.SquareSideLength = squareSideLength;
            this.IsBerryEated = true;
            this.Berry = new Point() { X = -800, Y = -800 };
            snake = new Snake(squareSideLength);
        }
        public void Init()
        {
            DrawSnake.OnSnakeInit();
        }
        public void GameTick()
        {
            snake.Direction = snake.DirectionBuffer;
            var snakeHead = snake.snakeElements.Last();
            SnakeMove(snakeHead);

            if (!IsGameOver) DrawSnake.OnSnakeMove();
            else DrawSnake.OnGameOver();
        }

        public void SnakeMove(Point snakeHead)
        {
            // Head of snake is on the end of List, ending is at beginning

            // Point is to instead of moving all snake elements, just move last to first and then use it as head
            Point snakeEnding = snake.snakeElements.First();
            Point copyOfSnakeEnding = snakeEnding;

            snakeEnding.X = snakeHead.X;
            snakeEnding.Y = snakeHead.Y;

            if (snake.Direction == 0)
                snakeEnding.Y = snakeEnding.Y - SquareSideLength;
            else if (snake.Direction == 1)
                snakeEnding.X = snakeEnding.X + SquareSideLength;
            else if (snake.Direction == 2)
                snakeEnding.Y = snakeEnding.Y + SquareSideLength;
            else if (snake.Direction == 3)
                snakeEnding.X = snakeEnding.X - SquareSideLength;

            // snakeEnding is now snakeHead

            if (!IsWallHard) snakeEnding = MakeWallPassage(snakeEnding);
            else if (WallIsHitted(snakeEnding) && !IsImmortal) IsGameOver = true;

            if (SnakeHitHimself(snakeEnding) && !IsImmortal) IsGameOver = true;

            if (BerryIsEated(snakeEnding)) DrawSnake.OnSnakeEatBerry();
            else snake.snakeElements.Remove(copyOfSnakeEnding);

            // adding new snakeHead at end of the list
            snake.snakeElements.Add(snakeEnding);
        }
        public Point MakeWallPassage(Point snakeHead)
        {
            if (snakeHead.X < 0) snakeHead.X = WidthOfSnakeBoard - SquareSideLength;
            else if (snakeHead.X >= WidthOfSnakeBoard) snakeHead.X = 0;

            if (snakeHead.Y < 0) snakeHead.Y = HeightOfSnakeBoard - SquareSideLength;
            else if (snakeHead.Y >= HeightOfSnakeBoard) snakeHead.Y = 0;

            return snakeHead;

        }
        public bool WallIsHitted(Point snakeHead)
        {
            if (snakeHead.X < 0) return true;
            if (snakeHead.X >= WidthOfSnakeBoard) return true;
            if (snakeHead.Y < 0) return true;
            if (snakeHead.Y >= HeightOfSnakeBoard) return true;

            return false;
        }

        public void CreateBerry(int secondsToBerryDisapear)
        {
            BerryTimeLifeSeconds = secondsToBerryDisapear;
            Random random = new Random();
            Berry.X = random.Next(0, WidthOfSnakeBoard / SquareSideLength) * SquareSideLength;
            Berry.Y = random.Next(0, HeightOfSnakeBoard / SquareSideLength) * SquareSideLength;
            while (BerryIsInsideSnake(Berry))
            {
                Berry.X = random.Next(0, WidthOfSnakeBoard / SquareSideLength) * SquareSideLength;
                Berry.Y = random.Next(0, HeightOfSnakeBoard / SquareSideLength) * SquareSideLength;
            }
            IsBerryEated = false;
            DateOfCreateBerry = DateTime.Now;
            DrawSnake.OnBerryCreate();
        }

        public bool BerryIsEated(Point snakeHead)
        {
            if (snakeHead.X == Berry.X && snakeHead.Y == Berry.Y)
            {
                Score += BerryTimeLifeSeconds - (int)(DateTime.Now - DateOfCreateBerry).TotalSeconds;
                IsBerryEated = true;
                return true;
            }
            return false;
        }
        public bool SnakeHitHimself(Point snakeHead)
        {
            for (int i = 1; i < snake.snakeElements.Count; i++)
                if (snake.snakeElements[i].X == snakeHead.X && snake.snakeElements[i].Y == snakeHead.Y) return true;

            return false;
        }
        private bool BerryIsInsideSnake(Point berry)
        {
            if (snake.snakeElements.Contains(berry)) return true;
            return false;
        }
    }

}
