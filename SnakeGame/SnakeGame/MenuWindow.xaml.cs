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
using System.Windows.Shapes;

namespace SnakeGame
{
    /// <summary>
    /// Logika interakcji dla klasy MenuWindow.xaml
    /// </summary>
    public partial class MenuWindow : Window
    {
        bool IsWallHard;
        int GameSpeed;
        bool IsImmortal;
        string GameMode;

        public MenuWindow()
        {
            InitializeComponent();
            IsWallHard = true;
            GameMode = GameModes.ExploreImageMode;
            IsImmortal = false;
            GameSpeed = 100;
            Point a = new Point(2, 2);
            Point b = a;
            MessageBox.Show(b.X + " " + b.Y);
        }

        private void PlayButton_Click(object sender, RoutedEventArgs e)
        {
            SnakeWindow game = new SnakeWindow(GameMode,GameSpeed);
            game.snakeGame.IsWallHard = IsWallHard;
            game.snakeGame.IsImmortal = IsImmortal;
            game.Show();
        }

        private void SettingsButton_Click(object sender, RoutedEventArgs e)
        {
            SettingsWindow settingsWindow = new SettingsWindow(this.IsWallHard, this.GameSpeed, this.IsImmortal, this.GameMode,ReceiveSettingsFromWindow);
            settingsWindow.GameSpeed = this.GameSpeed;
            settingsWindow.GameMode = this.GameMode;
            settingsWindow.IsWallHard = this.IsWallHard;
            settingsWindow.IsImmortal = this.IsImmortal;
            settingsWindow.ShowDialog();
        }
        private void ReceiveSettingsFromWindow(bool isWallHard, int gameSpeed, bool IsImmortal, string gameMode)
        {
            this.IsWallHard = isWallHard;
            this.GameSpeed = gameSpeed;
            this.IsImmortal = IsImmortal;
            this.GameMode = gameMode;
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
