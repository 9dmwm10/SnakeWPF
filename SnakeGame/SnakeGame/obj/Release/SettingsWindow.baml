   M S B A M L   `   `   `  ���� M  ISnakeSENSESoftware, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:SnakeSENSESoftwareSnakeSENSESoftware  '    !SnakeSENSESoftware.SettingsWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     2local clr-namespace:SnakeSENSESoftware       � Title$  SettingsWindow��$	��300��$	��300��
������.���  � RowDefinitions �� ��  � ColumnDefinitions �� �� .+�� $��0��$��0�� �� �� �� �� �� .+��� $��Center=�$��0��$��	Tryb gry:��$
��Bold"�	� -    	�Name$ ExploreImageModeRadio��$
��10,0q� 	� 	GroupName$ GameMode��$��1��$��Odkrywanie obrazka��	� -   $ ChangeBackgroundModeRadio��$
��10,0q�$ GameMode��$��2��$��Zmiana tła��	� -   $ NormalSnakeModeRadio��$
��10,0q�$ GameMode��$��3��$��Normalny��� $��0��$��1�� �� �� �� �� �� .+��� $��Center=�$��0��$��Poziom trudności:��$
��Bold"�	� -   $ EasyDifficultyRadio��$
��10,0q�$ DifficultyLevel��$��1��$��Łatwy��	� -   $ MediumDifficultyRadio��$
��10,0q�$ DifficultyLevel��$��2��$��Średni��	� -   $ HardDifficultyRadio��$
��10,0q�$ DifficultyLevel��$��3��$��Trudny��� $��1��$��0�� �� �� �� �� �� .+��� $��Center=�$��0��$��Inne:��$
��Bold"��� -    ��Name$ IsImmortalRadio��$
��10,0q�$��1��$��Nieśmiertelność��$��26��$��Bottom=��� -   $ IsWallHardRadio��$
��10,0q�$��2��$��2��.���� $!��Przechodzenie przez ściany��$
��Wrap=�� $��1��$��1�� �� �� �� �� .+��� -	   $��1��$��30��$	��120��$��Zapisz���� -
   $��2��$��30��$	��120��$��Wróc��