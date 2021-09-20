using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using SnakeLib;
using System.Windows.Shapes;
using System.Windows.Threading;
using SnakeLibs;
using SnakeLibs.DrawSnake;

namespace SnakeGame
{
    /// <summary>
    /// Logika interakcji dla klasy SnakeWindow.xaml
    /// </summary>
    public partial class SnakeWindow : Window
    {
        public SnakeLibs.SnakeGame snakeGame;
        ImageLoader imageLoader;
        DrawSnake drawSnake;
        int gameTime;
        int gameSpeed;
        DispatcherTimer timeCounter;
        DispatcherTimer gameTimer;
        DispatcherTimer berryTimer;

        public SnakeWindow(string gameMode, int gameSpeed=100)
        {
            InitializeComponent();

            SnakeBoardCanvas.Width = 220;
            SnakeBoardCanvas.Height = 220;

            DownloadStatusLabel.Background = new SolidColorBrush(Color.FromArgb(120, 206, 209, 201));  
            
            gameTime = 0;
            this.gameSpeed = gameSpeed;

            drawSnake = new DrawSnake(SnakeBoardCanvas);

            if (gameMode.Equals(GameModes.ExploreImageMode))
            {
                InitializeImageLoader();
                MakePreviewImageLayout();

                drawSnake.OnSnakeEatBerryHandler += imageLoader.SelectNewImage;
                drawSnake.OnSnakeMoveHandler += ChangeSnakeBackgroundWhileMoving;

                imageLoader.OnDownloadFinish = () => {
                    drawSnake.IsImageLoaded = true;
                    drawSnake.currentImage = imageLoader.currentImage;
                    OnDownloadSucces();
                    };

            }
            else if (gameMode.Equals(GameModes.ChangeBackgroundMode))
            {
                InitializeImageLoader();               
                HidePreviewImageLayout();
                DownloadStatusLabel.Visibility = Visibility.Visible;

                drawSnake = new DrawSnake(SnakeBoardCanvas);

                drawSnake.OnSnakeEatBerryHandler = imageLoader.SelectNewImage;
                drawSnake.OnSnakeMoveHandler += ChangeCanvasBackground;

                imageLoader.OnDownloadFinish = () => {

                    drawSnake.IsImageLoaded = true;
                    drawSnake.currentImage = imageLoader.currentImage;
                    OnDownloadSucces();

                };
            }
            else if (gameMode.Equals(GameModes.NormalSnakeMode))
            {
                HidePreviewImageLayout();
                drawSnake = new DrawSnake(SnakeBoardCanvas);
            }

            gameTimer = new DispatcherTimer();
            gameTimer.Tick += gameTimer_Tick;
            gameTimer.Interval = new TimeSpan(0, 0, 0, 0, gameSpeed);

            berryTimer = new DispatcherTimer();
            berryTimer.Tick += berryTimer_Tick;
            berryTimer.Interval = new TimeSpan(0,0,1);


            timeCounter = new DispatcherTimer();
            timeCounter.Tick += timeCounter_Tick;
            timeCounter.Interval = new TimeSpan(0, 0, 1);

            StartNewGame();
        }

        private void timeCounter_Tick(object sender, EventArgs e)
        {
            gameTime++;

            int minutes = gameTime/60;
            int seconds = gameTime - (minutes * 60);
            string time = "Czas: ";

            if(minutes < 10)
                time +="0" + minutes.ToString() + ":";
            else 
                time += minutes.ToString() + ":";

            if (seconds < 10) 
                time += "0" + seconds.ToString();
            else 
                time += seconds.ToString();


            TimeLabel.Content = time;


        }
        private void gameTimer_Tick(object sender, EventArgs e)
        {
            if (!snakeGame.IsGameOver)
            {
                snakeGame.GameTick();
                ScoreLabel.Content = "Punkty: " + snakeGame.Score;
            }
            else
            {
                timeCounter.Stop();
                berryTimer.Stop();
                if (!(snakeGame.DrawSnake as DrawSnake).gameOverTimer.IsEnabled)
                {
                    ((DispatcherTimer)sender).Stop();

                    MessageBoxResult result = MessageBox.Show("Przegrałeś! Chcesz zagrać ponownie?", "Game over", MessageBoxButton.YesNo);
                    switch (result)
                    {
                        case MessageBoxResult.No:
                            {
                                this.Close();
                                break;
                            }
                        case MessageBoxResult.Yes:
                            {
                                StartNewGame();
                                break;
                            }
                    }
                }
            }
        }
        private void berryTimer_Tick(object sender, EventArgs e)
        {
            int berryTimeLife = new Random().Next(5, 15);
            snakeGame.CreateBerry(berryTimeLife);
            ((DispatcherTimer)sender).Interval = new TimeSpan(0, 0, berryTimeLife);
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.Key)
            {
                case Key.W:
                    {
                        snakeGame.snake.DirectionBuffer = 0;
                        break;
                    }
                case Key.D:
                    {
                        snakeGame.snake.DirectionBuffer = 1;
                        break;
                    }
                case Key.S:
                    {
                        snakeGame.snake.DirectionBuffer = 2;
                        break;
                    }
                case Key.A:
                    {
                        snakeGame.snake.DirectionBuffer = 3;
                        break;
                    }
            }
        }

        private void ChangeCanvasBackground()
        {
            drawSnake.IsImageLoaded = true;
            SnakeBoardCanvas.Background = new ImageBrush(imageLoader.currentImage);
        }      
        private void OnDownloadFail()
        {
            DownloadStatusLabel.Content = "Download Error!";
        }
        private void OnDownloadStart()
        {
            DownloadStatusLabel.Foreground = Brushes.Blue;
            DownloadStatusLabel.Content = "Downloading in progress!";
           // drawSnake.IsImageLoaded = false;
        }
        private void OnDownloadSucces()
        {
            PreviewImage.Fill = new ImageBrush(imageLoader.currentImage);
            DownloadStatusLabel.Content = "Download Success!";
            DownloadStatusLabel.Foreground = Brushes.Green;
        }

        private void StartNewGame()
        {
            snakeGame = new SnakeLibs.SnakeGame(true, 20);
            drawSnake.snakeGame = snakeGame;
            snakeGame.DrawSnake = drawSnake;

            gameTime = 0;
            TimeLabel.Content = "00:00";
            ScoreLabel.Content = "0";
            snakeGame.WidthOfSnakeBoard = (int)SnakeBoardCanvas.Width;
            snakeGame.HeightOfSnakeBoard = (int)SnakeBoardCanvas.Height;
            snakeGame.Init();
            gameTimer.Start();
            berryTimer.Start();
            timeCounter.Start();
        }

        private void MakePreviewImageLayout()
        {
            PreviewLabel.Visibility = Visibility.Visible;
            PreviewImageContainer.Visibility = Visibility.Visible;
            DownloadStatusLabel.Visibility = Visibility.Visible;
        }
        private void HidePreviewImageLayout()
        {
            PreviewLabel.Visibility = Visibility.Hidden;
            PreviewImageContainer.Visibility = Visibility.Hidden;
            DownloadStatusLabel.Visibility = Visibility.Hidden;
        }

        private void InitializeImageLoader()
        {
            imageLoader = new ImageLoader();
            imageLoader.imageUrls.Add("https://cdn.pixabay.com/photo/2015/02/28/15/25/snake-653639_960_720.jpg");
            imageLoader.imageUrls.Add("https://cdn.pixabay.com/photo/2016/08/31/18/19/snake-1634293_960_720.jpg");
            imageLoader.imageUrls.Add("https://cdn.pixabay.com/photo/2014/11/23/21/22/snake-543243_960_720.jpg");
            imageLoader.imageUrls.Add("https://cdn.pixabay.com/photo/2019/02/06/17/09/snake-3979601_960_720.jpg");
            imageLoader.imageUrls.Add("https://cdn.pixabay.com/photo/2015/02/28/15/25/rattlesnake-653642_960_720.jpg");
            imageLoader.OnDownloadingStart = () => { OnDownloadStart(); };
            imageLoader.OnDownloadfail = () => { OnDownloadFail(); };
        }

        public void ChangeSnakeBackgroundWhileMoving()
        {
            drawSnake.IsImageLoaded = true;
            var nowe = new TransformedBitmap(imageLoader.currentImage, new ScaleTransform(drawSnake.SnakeGameBoard.Width / imageLoader.currentImage.PixelWidth, drawSnake.SnakeGameBoard.Height / imageLoader.currentImage.PixelHeight));
            drawSnake.snakeGraphicSquares.ForEach(snake =>
            {
                CroppedBitmap croppedBitmap = new CroppedBitmap(nowe, new Int32Rect((int)Canvas.GetLeft(snake), (int)Canvas.GetTop(snake), 20, 20));
                snake.Fill = new ImageBrush() { ImageSource = croppedBitmap };
            });
        }
    }
}
