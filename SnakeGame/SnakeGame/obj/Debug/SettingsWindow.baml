   M S B A M L   `   `   `  ����D  @SnakeGame, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:SnakeGame	SnakeGame  5   	       SnakeGame.SettingsWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:SnakeGame     5   	     � Title$  SettingsWindow��5   	   $	��300��6    $	��300��6-   
������.��5	      �  � RowDefinitions 5
   
   �� 5      6   �� 5      6    � ColumnDefinitions 5   
   �� 5      6!   �� 5      6!   .+�5   
   � $��0��6   $��0��6    5      �� 5      6#   �� 5      6"   �� 5      6"   �� 5      6"   �� 5      6"   .+�5      �� $��Center=�6   $��0��68   $��	Tryb gry:��6E   $
��Bold"�6Z   6n   	� 5      -   5         	�Name$ ExploreImageModeRadio��5      $
��10,0q�69    	� 	GroupName$ GameMode��6G   $��1��6\   $��Odkrywanie obrazka��6i   6�   	� 5      -   5        $ ChangeBackgroundModeRadio��5      $
��10,0q�6=   $ GameMode��6K   $��2��6`   $��Zmiana tła��6m   6�   	� 5      -   5        $ NormalSnakeModeRadio��5      $
��10,0q�68   $ GameMode��6F   $��3��6[   $��Normalny��6h   6}   5      � 5   
   $��0��6   $��1��6    5       �� 5!      6#   �� 5"      6"   �� 5#      6"   �� 5$      6"   �� 5%      6"   .+�5(      �� $��Center=�6   $��0��68   $��Poziom trudności:��6E   $
��Bold"�6b   6v   	� 5)      -   5        $ EasyDifficultyRadio��5)      $
��10,0q�67   $ DifficultyLevel��6E   $��1��6a   $��Łatwy��6n   6�   	� 5*      -   5        $ MediumDifficultyRadio��5*      $
��10,0q�69   $ DifficultyLevel��6G   $��2��6c   $��Średni��6p   6�   	� 5+      -   5        $ HardDifficultyRadio��5+      $
��10,0q�67   $ DifficultyLevel��6E   $��3��6a   $��Trudny��6n   6�   5,      � 5-   
   $��1��6   $��0��6    5.      �� 5/      6#   �� 50      6"   �� 51      6"   �� 52      6"   �� 53      6"   .+�56      �� $��Center=�6   $��0��68   $��Inne:��6E   $
��Bold"�6V   6j   �� 57      -   5         ��Name$ IsImmortalRadio��57      $
��10,0q�60   $��1��6>   $��Nieśmiertelność��6K   $��26��6e   $��Bottom=�6q   6�   �� 58      -   5        $ IsWallHardRadio��58      $
��10,0q�60   $��2��6>   $��2��6K   .��59      �� $!��Przechodzenie przez ściany��6   $
��Wrap=�6>   6T   6`   5:      � 5;   
   $��1��6   $��1��6    5<      �� 5=      6#   �� 5>      6"   �� 5?      6"   �� 5@      6"   .+�5B      �� -	   5        $��1��5B      $��30��6"   $	��120��6.   $��Zapisz��6:   6b   �� 5C      -
   5        $��2��5C      $��30��6"   $	��120��6.   $��Wróc��6:   6b   5D      5E      5F      