   M S B A M L   `   `   `  ���� M  ISnakeSENSESoftware, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:SnakeSENSESoftwareSnakeSENSESoftware  #    SnakeSENSESoftware.MenuWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     2local clr-namespace:SnakeSENSESoftware       � Title$  
MenuWindow��$	��450��$	��800������  �� ImageSource$! /images/backgroundImage.jpg��.���  � RowDefinitions �� �� �� �� �� .+��� -    ��Name$ 
PlayButton��$
��Graj�����	#FFFFED9B$��40(�$��SemiBold"�$��Center=�$	��Top=�$��Comic Sans MS)�$��1��$	��300��$��75������  �� 
TargetType" ��.R���  ��Name$ bdr_main�� �� CornerRadius$ 20��$��4q�
���   �
�������._��� $��Center=�$��Center=�$��8,6,8,6q�$��Content�� �� Triggers P�  P� Property �@J�IsMouseOver	 P� Value	 . . ��� 
 �� 
TargetName$
 bdr_main�� �� Property � �� �� Value �� $" /images/WoodenPlankHover.png��P�  �@J�IsMouseOver	 .  . ��� $
 bdr_main�� � �� �� $ /images/wooodenPlank.png���� -   $ SettingsButton��$��2��$��
Ustawienia�����	#FFFFED9B$��40(�$��SemiBold"�$��Center=�$	��Top=�$��Comic Sans MS)�$	��300��$��75������ " ��.R��� $ bdr_main��$ 20��$��4q�
���   �
�������._��� $��Center=�$��Center=�$��8,6,8,6q�$��Content�� P�  �@J�IsMouseOver	 . . ��� $
 bdr_main�� � �� �� $" /images/WoodenPlankHover.png��P�  �@J�IsMouseOver	 .  . ��� $
 bdr_main�� � �� �� $ /images/wooodenPlank.png���� -   $ 
ExitButton��$��3��$��Wyjście��$��40(�$��SemiBold"�$��Center=�$	��Top=�$��Comic Sans MS)�$	��300��$��75�����	#FFFFED9B���� " ��.R��� $ bdr_main��$ 20��$��4q�
���   �
�������._��� $��Center=�$��Center=�$��8,6,8,6q�$��Content�� P�  �@J�IsMouseOver	 . . ��� $
 bdr_main�� � �� �� $" /images/WoodenPlankHover.png��P�  �@J�IsMouseOver	 .  . ��� $
 bdr_main�� � �� �� $ /images/wooodenPlank.png��