   M S B A M L   `   `   `  ����J  FRandom-Password, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:Random_PasswordRandom_Password  5   	        Random_Password.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:Random_Password     5   	     � Title$  Random Password��5   	   $	��550��6!   $	��900��6.    � 
ResizeMode$ NoResize=�6:    � WindowStartupLocation$ CenterScreen=�6P   .��5	      �  � ShowGridLines .  ��5   
   �� 5       �� 
StartPoint$	 0,0&�6"    �� EndPoint$	 1,1&�63   .��5      �  � Color$ 	LightBlue��6    � Offset$ -5Q�61   � 5      $ Violet��6   $ 1Q�6.   5       � RowDefinitions 5   
   �� 5      $��1* �6   �� 5      $��4* �6   �� 5      $
��1.5* �6   .+�5   
   �� $��Password Generater��6   $��40(�6.   $��Center=�6<   $��Center=�6Y   $��DemiBold"�6t   
�������$��Segoe Print)�6�   6�   �� 5   
   $��1��6   	 �� Orientation$	 
Horizontal=�6"   $	��100��6;   $��Center=�6H   $��	70,25,0,0q�6e   $	��Top=�6x   .+�5      �� -   5        
 ��Name$
 PasswordBox��5   4   $	��500��6    �� 
IsReadOnly . $	��100��6I   $��Medium&�6V   $��48(�6k   $��Center=�6y   
���   �$��2q�6�    J� RenderTransformOrigin$ 0.5,0.5&�6�   $��Center=�6�   $��Center=�6�   $��Center=�6  $��SimSun)�6?  $��0,-4,0,4q�6S  .��6e   � 	Resources 5       �� 
TargetType �� Property �� Value��%d   '��       �� 5      " ��6   .�5      ��  �@��CornerRadius$ 10��69   6F   5      5      .��6%   5      �� 5       -   5         ��Name$ Clipboardbtn��5    E   $��70��6   $��70��6    
������ $��20,0,0,0q�6[   ��5!      �� 5"      .R�5#      ��  �� CornerRadius$ 50��6!   ._�5$      �� $��Images\clipboard.png��6$   6D   5%      5&       � ToolTip 5(      _� 5)       _� 	Placement$	 Top=�6   .��6.   Click To Copy5+      5-      5.      �� 5/   
   $��1��6   $��	0,150,0,0q�6"   $	 Vertical=�66   $��Center=�6M   .+�50      �� $	��Top=�6   $	 
Horizontal=�61   $��Center=�6J   .+�51      �� $"��Enter the Length Of Password��6   
�������$��Segoe Print)�6S   $��15(�6l   6|   �� 52      -   5        $
 	Lengthbox��52   2   $	��100��6   $��40��6&   
���   �$��1q�6Y   $��20,0,0,0q�6m   $��Center=�6   $��Center=�6�   $��18(�6�   $��Segoe UI Semibold)�6�   .��6   53      ��%d   '��       �� 54      " ��6   .�55      ��  �@��CornerRadius$ 10��65   6B   56      57      .��6!   58      �� 59      -   5         ��Name$ Passwordstrength��59   B   $��20,0,0,0q�6   $��40��6+   $��40��66   $ 50��6\   6p   5:      �� 5;      $	 
Horizontal=�6   $��Center=�62   $��0,30,0,0q�6M   .+�5<      �� -   5         ��Name$ NumberCheckBox��5<   A   $��Numbers��6   $��20��6)   $	��100��65   
������� � LayoutTransform 5=      �� 5>       �� ScaleX$	 1.5Q�6%    �� ScaleY$	 1.5Q�62   6A   5@      �� 5A      -   5        $ LowercaseCheckBox��5A      $��	UpperCase��67   $��20��6K   $	��100��6W   
������� 5B      �� 5C      $	 1.5Q�6%   $	 1.5Q�62   6A   5E      �� 5F      -   5        $ UpperCaseCheckBox��5F      $��	LowerCase��67   $��20��6K   $	��100��6W   
������� 5G      �� 5H      $	 1.5Q�6%   $	 1.5Q�62   6A   5J      �� 5K      -   5        $ SymbolCheckBox��5K      $��Symbols��64   $��20��6F   $	��100��6R   
������� 5L      �� 5M      $	 1.5Q�6%   $	 1.5Q�62   6A   5O      5P      5Q      �� 5R      -	   5        $��70��5R      $	��450��6!   $��3��6-   ��5S      �� 5T      .R�5U      �� $ 15��6   
��� � �._�5V      �� $��Generate��6$   
�������$��Center=�6G   $��35(�6d   $��Center=�6r   $��Segoe Print)�6�   6�   5W      5X      5Z      5[      5\      