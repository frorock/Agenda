   M S B A M L   `   `   `  ����T  PMahApps.Metro, Version=2.0.0.0, Culture=neutral, PublicKeyToken=51482d6f650b2b3fV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls  5      H DAgenda_Iliana, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:Agenda_Iliana.CustomControlsAgenda_Iliana.CustomControls 5   	   -clr-namespace:Agenda_IlianaAgenda_Iliana 5	   	      Agenda_Iliana.Log   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   PControls;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     5      X TFontAwesome.Sharp, Version=6.2.1.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10fFfa=http://schemas.awesome.incremented/wpf/xaml/fontawesome.sharp  5   	   ?customcontrols*clr-namespace:Agenda_Iliana.CustomControls  5   	   'localclr-namespace:Agenda_Iliana  5	   	     � Title$	  Log��5   	   $	��720��6   $
��1080��6"    � WindowStyle$
 None=�60    � 
ResizeMode$ NoResize=�5   	    � AllowsTransparency$
 True��5   	   
������  � WindowStartupLocation$ CenterScreen=�5   	   .��5      � .+�5   
   � .+�5      ��  �� CornerRadius$ 12��6   ��5      �� 5       �� ImageSource$% /Ressource/Background_login.jpg��6!   ._�5      �� $ 10��6   $��2q�5       J� Opacity$
 0.95Q�5      ��5      �� 5       �� 
StartPoint$	 0,0&�6.   	 �� EndPoint$		 1,1&�6?   .��5      � 
 � Color$
 #462AD8��6+    � Offset$ 0Q�6;   � 5      $
 #DA34AE��6+   $
 0.75Q�6;   � 5      $
 #8A16C1��6+   $ 1Q�6;   5      ��5"      �� 5#      $	 0,1&�6.   $		 1,0&�6?   .��5$      � $
 #060531��6+   $ 0Q�6;   � 5%      $
 #1B1448��6+   $
 0.75Q�6;   5&      ._�5)      �  � RowDefinitions 5*      �� 5+      $��30 �6,   �� 5,      .+�5/      �  � ColumnDefinitions 50      �� 51   "   �� 52   "   $��25 �63   �� 53   "   $��25 �63   �� 54   "   $��5 �63   .+�57      �� $��LOGIN��6(   
�������$��10(�59       $��0��5:       $��Center=�5;       $��10,0,0,0q�5<       �� 5A      -   5         ��Name$ 	BTN_Close��5A   %      
Top_Button#��[  5B      $��2��5C      .��5E   "   !  FontAwesome.Sharp.IconImage  �  �FontAwesome.Sharp.IconImageBase`1[[FontAwesome.Sharp.IconChar, FontAwesome.Sharp, Version=6.2.1.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10f]]   Icon$ X=�6/      
Foreground
 �����$��3q�5G      5H      5J      �� 5L      $	��250��6%   $��2��5M       �� Orientation$ Vertical=�5N      $��0,35,0,0q�5O      .+�5Q        $ AddressBook=�6+    �#a100f2$	��100��5S   #   $	��100��6/   �� 5U      $��TaskMate��6(   
�������$��25(�5W       $��Medium"�5X       $��Center=�5Y       $��0,15,0,0q�5Z       �� 5\      $ 
Horizontal=�6)   $��0,50,0,0q�5]   !   .+�5_   "     $ UserAlt=�6/   
 �����$��16��5a   '   $��16��5b   '   $��0,0,5,0q�5c   '   �� 5e   "   $��Username��6,   
�������$��12(�5g   $   $��Medium"�5h   $   5j      �� 5m      -   5         ��Name$ TB_User��5m   &   $��13(�5o      $��Medium"�5p      
������� �� 
CaretBrush
 �����
�������$��0,0,0,1q�5t      $��28��5u      $��Center=�5v      
������ $��0,5,0,0q�5x      ��5n      �� *
Username+ �� UpdateSourceTrigger$ PropertyChanged=�.��5x   .   5y      �� 5{      $ 
Horizontal=�6)   $��0,30,0,0q�5|   !   .+�5~   "     $	 Key=�6/   
 �����$��16��5�   '   $��16��5�   '   $��0,0,5,0q�5�   '   �� 5�   "   $��Password��6,   
�������$��12(�5�   $   $��Medium"�5�   $   5�      4  .Agenda_Iliana.CustomControls.BindablelPassword  5�      -   5          Name$ TB_Password��5�      $��28��5�      $��0,5,0,0q�5�         Password 5�      �� *
Password+$ PropertyChanged=� �� Mode$ TwoWay=�5�      �� 5�      -   5         ��Name$ ErrorMessage��5�       ���#D7596D$��12(�5�       $��Medium"�5�       $��0,10,0,0q�5�       $
��Wrap=�5�       �� 5�      -   5        $ 
BTN_Submit��5�   %     Submit_Button#��[ 5�      $��0,30,0,0q�5�      5�      �� 5�      $ 
Horizontal=�6)   $��Center=�5�   !   $��0,15,0,0q�5�   !   .+�5�   "   �� $��Forgot Password?��6,   
�������$��12(�5�       $��Medium"�5�       �� 5�   "   $��Reset��6,   
�������$��12(�5�       $��Medium"�5�        � Cursor$
 Hand��5�       $��8,0,0,0q�5�       5�      )   #MahApps.Metro.Controls.ProgressRing  5�      -   5          Name$ 	MySpinner��5�   4      IsActive$ False��6G   $��50��6X   $��50��6c   
�������$��30q�6�   5�      5�      5�      5�      5�      5�      5�      