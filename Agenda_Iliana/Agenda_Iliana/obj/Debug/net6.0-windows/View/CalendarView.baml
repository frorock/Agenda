   M S B A M L   `   `   `  ����H  DAgenda_Iliana, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:Agenda_Iliana.CustomControlsAgenda_Iliana.CustomControls  5      7 clr-namespace:Agenda_Iliana.ViewAgenda_Iliana.View  5      %    Agenda_Iliana.View.CalendarView   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      X TFontAwesome.Sharp, Version=6.2.1.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10fFfa=http://schemas.awesome.incremented/wpf/xaml/fontawesome.sharp  5      ?customcontrols*clr-namespace:Agenda_Iliana.CustomControls  5      ,local clr-namespace:Agenda_Iliana.View  5      $��Trebuchet MS)�5
   7   .��5      � .+�5   
   �   � ColumnDefinitions  5      �� 5      $
��1.2* �6#   �� 5      $��* �6#   .+�5      �� ���#fefefe6   �� 5      $��1��6   ���#1C0E496&   5      � 5   
     5      �� 5      $
��1.2* �6#   �� 5      $��* �6#   .+�5      �� .+�5!      ��  �� Orientation$ 
Horizontal=�6   $��Center=�66   $��	0 50 0 30q�6S   .+�5#      	� $
��2021��6"      Calendar_Button#��[  61   	� 5$      $
��2022��6"   #��[  61   	� 5%      $
��2023��6"   #��[  61   	� 5&      $
��2025��6"   #��[  61   	� 5'      $
��2025��6"   #��[  61   5)      �� 5,      $ 
Horizontal=�6   $��Center=�66   .+�5-      	� $��1��6"     Month_Button#��[ 6.   	� 5.      $��2��6"   #��[ 6.   	� 5/      $��3��6"   #��[ 6.   	� 50      $��4��6"   #��[ 6.   	� 51      $��5��6"   #��[ 6.   	� 52      $��6��6"   #��[ 6.   	� 53      $��7��6"   #��[ 6.   	� 54      $��8��6"   #��[ 6.   	� 55      $��9��6"   #��[ 6.   	� 56      $��10��6"   #��[ 6/   	� 57      $��11��6"   #��[ 6/   	� 58      $��12��6"   #��[ 6/   59      �� 5;      $	��0.8��6   ���#cacaca$��30 10q�6>   �� 5=      -   5         ��Name$ TB_Month��5=      $��November��6.   ���#7209b7$��24(�6S    �� TextAlignment$ Center=�6a   $��SemiBold"�6x   $��	0 15 0 20q�6�   &   System.Windows.Controls.Calendar  5?      -   5          Name$ calendar��5?        CalendarCalendarItemStyle1   CalendarItemStyle# �  6.    # CalendarCalendarDayButtonStyle1   CalendarDayButtonStyle# �  6o     CalendarStyle1#���  6�   5@      �� 5B      -   5        $��Right_StackPanel��5B   )   $��1��6   .+�5D      �� $��24 45 30 10q�6   $ 
Horizontal=�62   .+�5E      �� -   5        $ TB_DaynbrLeft��5E       $��16��67   $��50(�6A   ���#ffffff6O   �� 5G      $��10 0 0 0q�6!   $��Center=�63   .+�5H      �� -   5        $ TB_MonthLeft��5H   $   $��November��6:   $��24(�6J   ���#ffffff6X   �� 5I      -   5        $ 
TB_DayLeft��5I   $   $��Monday��68   $��14(�6F   ���#ffd6ff6T   5J      	� 5L      -   5          BigCalendar_Button#��[ 5L   "   $��	112 0 5 0q�6N   .��5M      !  FontAwesome.Sharp.IconImage  �  �FontAwesome.Sharp.IconImageBase`1[[FontAwesome.Sharp.IconChar, FontAwesome.Sharp, Version=6.2.1.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10f]]   Icon$ 	AngleLeft=�6'     BigAngle#��[ 68   5N      	� 5O      -   5        #��[ 5O   "   .��5P        $ 
AngleRight=�6'   #��[ 69   5Q      5R      �� 5T      -	   5        $ TB_TaskLeft��5T      $��5 task - 2 dates left��61   ���#e0aaff$��16(�6c   $��	35 0 20 0q�6q   �� 5W      ���#7B5CD6 �� CornerRadius$ 10��6.   $��Center=�6@   $	��355��6]   $��	0 30 0 20q�6i   	 �� Padding$	 
17 15 5 15q�6|   ._�5[      �   5\      �� 5]      $
��281* �6/   �� 5^      $	��52* �6/   .+�5a      �� .+�5c      �   5d   "   �� 5e   &   $
��auto �67   �� 5f   &   $��* �67   .+�5i   "     $ Pencil=�6/   $��15��6=   $��15��6H   
   
Foreground
 �#ffd6ff6T   �� 5j   "   -
   5        $��TB_Note��5j   <   $��Add Note��6,     textHint#��[ 6K   6m   �� 5k   "   -   5        $��
TB_TxtNote��5k   2   $�� ��6*     textbox#��[ 6D   6e   5l      �� 5n      $��	0 12 0 11q�6(   $	��0.8��6;   ���#c73f6H   � 5p        5q   "   �� 5r   &   $
��auto �67   �� 5s   &   $	��23* �67   �� 5t   &   $
��110* �67   .+�5w   "     $
 Bell=�6/   $��15��6;   $��15��6F   
 �#ffd6ff$��0,1,0,0q�6g   �� 5x   "   -   5        $��TB_Time��5x   I   $��_ _ : _ _ - _ _ : _ _��6,   #��[ 6X   $��1��6�   $��2��6�   $��10,0,0,0q�6�   �� 5y   "   -   5        $��
TB_TxtTime��5y   2   $�� ��6*   #��[ 6D   $��1��6�   $��2��6�   $��10,0,0,0q�6�   5z      5|      	� 5}      -   5        $��1��5}   &   #��[  66   .��5~        $ 
PlusCircle=�6+   $��28��6=   $��28��6H   
 �#f9F9F96T   5      5�      5�      '   !Agenda_Iliana.CustomControls.Item  5�         Title$ Post on social networks��6&      Time$ 09:45 - 10:30��6F      Color$ #ffd6ff��6[      Icon$ CheckCircle=�6k      IconBell$ 	BellSlash=�6~     5�      $ Dinner with Joe��6&   $ 09:45 - 10:30��6>   $ #ffd6ff��6S   $ CheckCircle=�6c   $ 	BellSlash=�6v     5�      $ Send email to office��6&   $ 09:45 - 10:30��6C   $ #ffd6ff��6X   $ 
CircleThin=�6h   $
 Bell=�6z     5�      $ Review app design��6&   $ 09:45 - 10:30��6@   $ #ffd6ff��6U   $ 
CircleThin=�6e   $
 Bell=�6w     5�      $ Call Jennifer��6&   $ 09:45 - 10:30��6<   $ #ffd6ff��6Q   $ 
CircleThin=�6a   $
 Bell=�6s   5�      5�      5�      5�      