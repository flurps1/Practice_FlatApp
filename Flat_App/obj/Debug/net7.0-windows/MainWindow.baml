   M S B A M L   `   `   `  ����C  ?Flat_App, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:Flat_AppFlat_App  5   	       Flat_App.MainWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *flatAppclr-namespace:Flat_App     5   	     � Title$  
MainWindow��5   	   $	��600��6   $	��920��6)    � 
ResizeMode$ NoResize=�5	   	   
������  � AllowsTransparency$ False��5   	    � DataContext 5         Flat_App.ViewModel  5   
   .��5      �� ���#272537 �� CornerRadius$ 25��5   	   ._�5   
   �  � ColumnDefinitions 5      �� 5      $	��200 �6#   �� 5       � RowDefinitions 5      �� 5      $��75 �6    �� 5      .+�5      �� $	��App��6   $��Center=�5      $
��Left=�5      
�������$��30(�5!      $��20q�5"      �� 5$      $��1��6   $��0��6&   .+�5%      	� $
��Home��6   $��50��5&      
�������$��20(�5(       d� 	IsChecked$
 TrueY�5)         MenuButtonTheme#��[  5*      ��5+      �� *HomeViewCommand+	� 5-      $��	Discovery��6   $��50��5.      
�������$��20(�50      #��[  51      ��52      �� *DiscoveryViewCommand+	� 55      $��Settings��6   $��50��56      
�������$��20(�58      #��[  59      ��5:      �� *DiscoveryViewCommand+5<      �� 5=      $��1��6   $��1��5>      $��10q�5?      ��5@      �� *CurrentView+5A      5B      5C      