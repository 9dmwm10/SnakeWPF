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
    /// Logika interakcji dla klasy SettingsWindow.xaml
    /// </summary>
    public partial class SettingsWindow : Window
    {

        public delegate void sendSettingsToMenuWindow(bool isWallHard, int gameSpeed, bool IsImmortal, string gameMode);
        public sendSettingsToMenuWindow SendSettingsToMenuWindow;

        public bool IsWallHard;
        public int GameSpeed;
        public bool IsImmortal;
        public string GameMode;
        public SettingsWindow()
        {
            InitializeComponent();
        }
        public SettingsWindow(bool isWallHard, int gameSpeed, bool IsImmortal, string gameMode, sendSettingsToMenuWindow sendSettings)
        {
            InitializeComponent();
            this.IsWallHard = isWallHard;
            this.GameSpeed = gameSpeed;
            this.IsImmortal = IsImmortal;
            this.GameMode = gameMode;
            SendSettingsToMenuWindow = sendSettings;
            if (!IsWallHard) IsWallHardRadio.IsChecked = true;
            if (IsImmortal) { IsImmortalRadio.IsChecked = true; IsWallHardRadio.IsChecked = true; }

            if (GameMode == GameModes.ExploreImageMode) ExploreImageModeRadio.IsChecked = true;
            if (GameMode == GameModes.ChangeBackgroundMode) ChangeBackgroundModeRadio.IsChecked = true;
            if (GameMode == GameModes.NormalSnakeMode) NormalSnakeModeRadio.IsChecked = true;

            if (GameSpeed == GameDifficulty.EasyLevel) EasyDifficultyRadio.IsChecked = true;
            if (GameSpeed == GameDifficulty.MediumLevel) MediumDifficultyRadio.IsChecked = true;
            if (GameSpeed == GameDifficulty.HardLevel) HardDifficultyRadio.IsChecked = true;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if ((bool)IsWallHardRadio.IsChecked) IsWallHard = false;
            else IsWallHard = true;
            if ((bool)IsImmortalRadio.IsChecked) { IsImmortal = true;}
            else { IsImmortal = false; }

            if ((bool)ExploreImageModeRadio.IsChecked) GameMode = GameModes.ExploreImageMode;
            if ((bool)ChangeBackgroundModeRadio.IsChecked) GameMode = GameModes.ChangeBackgroundMode;
            if ((bool)NormalSnakeModeRadio.IsChecked) GameMode = GameModes.NormalSnakeMode;

            if ((bool)EasyDifficultyRadio.IsChecked) GameSpeed = GameDifficulty.EasyLevel;
            if ((bool)MediumDifficultyRadio.IsChecked) GameSpeed = GameDifficulty.MediumLevel;
            if ((bool)HardDifficultyRadio.IsChecked) GameSpeed = GameDifficulty.HardLevel;

            this.SendSettingsToMenuWindow(IsWallHard, GameSpeed, IsImmortal, GameMode);
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void IsImmortalRadio_Checked(object sender, RoutedEventArgs e)
        {
            IsWallHardRadio.IsChecked = true;
            IsWallHardRadio.IsEnabled = false;
        }
        private void IsImmortalRadio_UnChecked(object sender, RoutedEventArgs e)
        {
            IsWallHardRadio.IsChecked = false;
            IsWallHardRadio.IsEnabled = true;
        }

    }
}
