   M S B A M L   `   `   `  ����I  EBMI-Calculator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:BMI_CalculatorBMI_Calculator  5   	       BMI_Calculator.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:BMI_Calculator     5   	     � Title$  
MainWindow��5   	   $	��550��6   $	��900��6)   
������� � 
ResizeMode$ NoResize=�6H   .��5	      �  � ShowGridLines . .+�5
   
   �  � RowDefinitions 5      �� 5      $��1* �6    6.   �� 5      $��4* �6    6.   .+�5      �� 
������.+�5      �� $��BMI Calculator��6   $��Center=�62   $��	monospace)�6O   $��	ExtraBold"�6f   
�������$��Center=�6�   $��50(�6�   $��0,20,0,0q�6�   6�   5       � 5      $��1��6   5      �� 5      $��1��6    �� Orientation$ 
Horizontal=�6&   $��Center=�6?   .+�5      �� -   5         ��Name$ SIUnit��5   &   $	��100��6   $	��250��66   $��20q�6W   ��5      �� 5      .R�5      ��  �� CornerRadius$ 25��6%   ���#463190._�5   "   �� $��SI Units��6,   $��Center=�6<   $��35(�6Y   $
��Bold"�6g   
�������$��Center=�6�   6�   5      5      5      �� 5      -   5        $	��100��5      $	��250��6&   $��20q�62   ��5       �� 5!      .R�5"      �� $ 25��6%   ���#463190._�5#   "   �� $��US Units��6,   $
��Bold"�6<   
�������$��Center=�6a   $��35(�6~   $��Center=�6�   6�   5$      5%      5'      5(      5)      5*      5,      