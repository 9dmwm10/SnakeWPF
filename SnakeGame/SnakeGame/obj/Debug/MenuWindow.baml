   M S B A M L   `   `   `  ����D  @SnakeGame, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:SnakeGame	SnakeGame  5   	       SnakeGame.MenuWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:SnakeGame     5   	     � Title$  
MenuWindow��5   	   $	��450��6   $	��800��6)   ��5
      �� 5   
    �� ImageSource$! /images/backgroundImage.jpg��6   6A   .��5      �  � RowDefinitions 5   
   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6   .+�5   
   �� -   5         ��Name$ 
PlayButton��5   �   $
��Graj��6   ���	#FFFFED9B$��40(�67   $��SemiBold"�6E   $��Center=�6[   $	��Top=�6   $��Comic Sans MS)�6�   $��1��6�   $	��300��6�   $��75��6�   ��5      �� 5       �� 
TargetType" ��6"   .R�5      ��  ��Name$ bdr_main��6    �� CornerRadius$ 20��6/   $��4q�6A   
���   �
�������._�5      �� $��Center=�6+   $��Center=�6F   $��8,6,8,6q�6c   $��Content��6t   5       �� Triggers 5      P� 5       P� Property �@J�IsMouseOver	 P� Value	 . . �5      �� 
 �� 
TargetName$
 bdr_main��6%    �� Property � �� �� Value 5   "   �� 5   &   $" /images/WoodenPlankHover.png��61   5!      5"      P� 5#       �@J�IsMouseOver	 .  . �5$      �� $
 bdr_main��6%    � �� 5%   "   �� 5&   &   $ /images/wooodenPlank.png��61   5(      5)      5+      5-      �� 5.   
   -   5        $ SettingsButton��5.   3   $��2��6   $��
Ustawienia��6   ���	#FFFFED9B$��40(�6b   $��SemiBold"�6p   $��Center=�6�   $	��Top=�6�   $��Comic Sans MS)�6�   $	��300��6�   $��75��6�   ��5/      �� 50      " ��6"   .R�51      �� $ bdr_main��6   $ 20��6/   $��4q�6A   
���   �
�������._�52      �� $��Center=�6+   $��Center=�6F   $��8,6,8,6q�6c   $��Content��6t   53       54      P� 55       �@J�IsMouseOver	 . . �56      �� $
 bdr_main��6%    � �� 57   "   �� 58   &   $" /images/WoodenPlankHover.png��61   5:      5;      P� 5<       �@J�IsMouseOver	 .  . �5=      �� $
 bdr_main��6%    � �� 5>   "   �� 5?   &   $ /images/wooodenPlank.png��61   5A      5B      5D      5F      �� 5G   
   -   5        $ 
ExitButton��5G      $��3��6   $��Wyjście��62   $��40(�6D   $��SemiBold"�6R   $��Center=�6h   $	��Top=�6�   $��Comic Sans MS)�6�   $	��300��6�   $��75��6�   ���	#FFFFED9B��5H      �� 5I      " ��6"   .R�5J      �� $ bdr_main��6   $ 20��6/   $��4q�6A   
���   �
�������._�5K      �� $��Center=�6+   $��Center=�6F   $��8,6,8,6q�6c   $��Content��6t   5L       5M      P� 5N       �@J�IsMouseOver	 . . �5O      �� $
 bdr_main��6%    � �� 5P   "   �� 5Q   &   $" /images/WoodenPlankHover.png��61   5S      5T      P� 5U       �@J�IsMouseOver	 .  . �5V      �� $
 bdr_main��6%    � �� 5W   "   �� 5X   &   $ /images/wooodenPlank.png��61   5Z      5[      5]      5_      5`      5a      