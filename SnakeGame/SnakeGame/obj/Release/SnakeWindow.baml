   M S B A M L   `   `   `  ���� M  ISnakeSENSESoftware, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:SnakeSENSESoftwareSnakeSENSESoftware  $    SnakeSENSESoftware.SnakeWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     2local clr-namespace:SnakeSENSESoftware     -     � Title$  Snake��$	��450��$	��800�� � 
ResizeMode$ NoResize=�����  �� ImageSource$! /images/backgroundImage.jpg��.��� -    �Name$ GameGrid�� � RowDefinitions �� $��2* ��� $��8* � � ColumnDefinitions �� $��5* ��� $��6* ��� $��5* �.+��� $��1��$��1��
���   �$��3q�$	��226��$	��226��._��� -    ��Name$ SnakeBoardCanvas��$	��220��
������$	��220��� $��0��$��1�� �� $��2* ��� $��6* �.+��� -    ��Name$ DownloadStatusLabel��$��0��$��Center=�$��Tahoma)�$��16(�$��SemiBold"�
���  ��$
��Left=�$��	10,10,0,0q�$	��Top=� J� RenderTransformOrigin$ 0.5,0.5&�$	��228��$��57���� -   $ PreviewLabel��$��Podgląd��
�������
����·�$��1��$��Center=�$��Tahoma)�$��16(�$��SemiBold"�$
��Left=�$��	47,10,0,0q�$	��Top=�$ 0.5,0.5&�$	��154���� -   	 ��Name$	 PreviewImageContainer��$��1��$	��154��$	��154��
���   �$��2q�._��� -   
 ��Name$
 PreviewImage��$	��150��$	��150��� $��0��$��1�� �� $��* ��� $��* �.+��� -   $ 	TimeLabel��$��0��$��Tahoma)�$��Czas: 00:00��$��18(�$��SemiBold"�$��Center=�
��������� -	   $ 
ScoreLabel��$��1��$��Tahoma)�$��	Punkty: 0��$��18(�$��SemiBold"�$��Center=�
�������