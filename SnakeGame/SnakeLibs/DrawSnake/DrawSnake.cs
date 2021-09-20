using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace SnakeLibs.DrawSnake
{
    public class DrawSnake : IDrawSnake
    {
        public List<Rectangle> snakeGraphicSquares;
        public SnakeGame snakeGame { get; set; }
        public Canvas SnakeGameBoard { get; set; }
        public Rectangle BerrySquare { get; set; }
        public BitmapImage currentImage { get; set; }
        public bool IsImageLoaded { get; set; }
        public Rectangle ErrorSquare { get; set; }
        public bool IsBerryEated { get; set; }

        public delegate void onSnakeEatBerryHandler();
        public onSnakeEatBerryHandler OnSnakeEatBerryHandler;

        public delegate void onSnakeMoveHandler();
        public onSnakeMoveHandler OnSnakeMoveHandler;


        public DispatcherTimer gameOverTimer;

        public DrawSnake(Canvas snakeBoard)
        {
            this.IsBerryEated = false;
            IsImageLoaded = false;
            snakeGraphicSquares = new List<Rectangle>();
            this.SnakeGameBoard = snakeBoard;
            gameOverTimer = new DispatcherTimer();
            gameOverTimer.Interval = new TimeSpan(0, 0, 0, 0, 45);
            gameOverTimer.Tick += error_Tick;

        }
        public void error_Tick(object sender, EventArgs e)
        {
            var snakeHead = snakeGraphicSquares.Last();
            snakeGraphicSquares.Remove(snakeHead);
            snakeHead.Fill = new SolidColorBrush(Colors.Red);
            if (snakeGraphicSquares.Count == 0)
            {
                ((DispatcherTimer)sender).Stop();
            }
        }
        public void OnGameOver()
        {
            gameOverTimer.Start();
        }

        public void OnSnakeEatBerry()
        {
            IsBerryEated = true;

            if(this.OnSnakeEatBerryHandler != null)
                this.OnSnakeEatBerryHandler.Invoke();

            SnakeGameBoard.Children.Remove(BerrySquare);
            SnakeGameBoard.Background = new SolidColorBrush(Colors.LightGreen);
        }

        public void OnSnakeInit()
        {
            SnakeGameBoard.Children.Clear();
            ErrorSquare = new Rectangle()
            {
                Width = snakeGame.SquareSideLength,
                Height = snakeGame.SquareSideLength,
                Fill = new SolidColorBrush(Colors.Red)
            };
            snakeGame.snake.snakeElements.ForEach(snakeElement =>
            {
                Rectangle snakeSquare = CreateSquare(Colors.Green);

                snakeGraphicSquares.Add(snakeSquare);
                SnakeGameBoard.Children.Add(snakeSquare);
                Canvas.SetLeft(snakeSquare, snakeElement.X);
                Canvas.SetTop(snakeSquare, snakeElement.Y);
            });
        }

        public void OnSnakeMove()
        {
            Rectangle snakeEding;
            if (IsImageLoaded && OnSnakeMoveHandler != null)
                OnSnakeMoveHandler.Invoke();
            if (IsBerryEated)
            {
                IsBerryEated = false;
                snakeEding = CreateSquare(Colors.Green);
                SnakeGameBoard.Children.Add(snakeEding);
            }
            else
            {
                snakeEding = snakeGraphicSquares.First();
                snakeGraphicSquares.Remove(snakeEding);
            }
            Canvas.SetLeft(snakeEding, snakeGame.snake.snakeElements.Last().X);
            Canvas.SetTop(snakeEding, snakeGame.snake.snakeElements.Last().Y);
            snakeGraphicSquares.Add(snakeEding);
        }

        public void OnBerryCreate()
        {
            if (SnakeGameBoard.Children.Contains(BerrySquare)) SnakeGameBoard.Children.Remove(BerrySquare);
            BerrySquare = CreateSquare(Colors.Purple);
            SnakeGameBoard.Children.Add(BerrySquare);
            Canvas.SetLeft(BerrySquare, snakeGame.Berry.X);
            Canvas.SetTop(BerrySquare, snakeGame.Berry.Y);
        }

        public Rectangle CreateSquare(Color color)
        {
            return new Rectangle()
            {
                Width = snakeGame.SquareSideLength - (snakeGame.SquareSideLength / 10),
                Height = snakeGame.SquareSideLength - (snakeGame.SquareSideLength / 10),
                Fill = new SolidColorBrush(color)
            };
        }      
    }
}
