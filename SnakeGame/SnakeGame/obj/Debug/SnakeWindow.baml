   M S B A M L   `   `   `  ����D  @SnakeGame, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:SnakeGame	SnakeGame  5   	       SnakeGame.SnakeWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:SnakeGame     5   	   -   5          � Title$  Snake��5   	   $	��450��5	   	   $	��800��5
   	    � 
ResizeMode$ NoResize=�5   	   ��5      �� 5   
    �� ImageSource$! /images/backgroundImage.jpg��6   6A   .��5      � -   5         �Name$ GameGrid��5       � RowDefinitions 5   
   �� 5      $��2* �6   6*   �� 5      $��8* �6   6*    � ColumnDefinitions 5   
   �� 5      $��5* �6   6,   �� 5      $��6* �6   6,   �� 5      $��5* �6   6,   .+�5   
   �� $��1��6   $��1��6   
���   �$��3q�6B   $	��226��6V   $	��226��6b   ._�5      �� -   5         ��Name$ SnakeBoardCanvas��5      $	��220��60   
������$	��220��6T   5      5      � 5   
   $��0��6   $��1��6    5       �� 5!      $��2* �6    6.   �� 5"      $��6* �6    6.   .+�5$      �� -   5         ��Name$ DownloadStatusLabel��5$   �   $��0��6   $��Center=�6"   $��Tahoma)�6F   $��16(�6Z   $��SemiBold"�6h   
���  ��$
��Left=�6�   $��	10,10,0,0q�6�   $	��Top=�6�    J� RenderTransformOrigin$ 0.5,0.5&�6�   $	��228��6  $��57��6   5%      �� 5&      -   5        $ PreviewLabel��5&      $��Podgląd��6*   
�������
����·�$��1��6i   $��Center=�6v   $��Tahoma)�6�   $��16(�6�   $��SemiBold"�6�   $
��Left=�6�   $��	47,10,0,0q�6�   $	��Top=�6   $ 0.5,0.5&�6  $	��154��68  5'      �� 5(      -   5        	 ��Name$	 PreviewImageContainer��5(      $��1��64   $	��154��6A   $	��154��6M   
���   �$��2q�6n   ._�5)      �� -   5        
 ��Name$
 PreviewImage��5)   5   $	��150��6   $	��150��6(   5+      5,      5-      � 50   
   $��0��6   $��1��6    51      �� 52      $��* �6    6-   �� 53      $��* �6    6-   .+�55      �� -   5        $ 	TimeLabel��55      $��0��6'   $��Tahoma)�64   $��Czas: 00:00��6H   $��18(�6^   $��SemiBold"�6l   $��Center=�6�   
�������6�   �� 56      -	   5        $ 
ScoreLabel��56      $��1��6(   $��Tahoma)�65   $��	Punkty: 0��6I   $��18(�6]   $��SemiBold"�6k   $��Center=�6�   
�������6�   57      59      5:      