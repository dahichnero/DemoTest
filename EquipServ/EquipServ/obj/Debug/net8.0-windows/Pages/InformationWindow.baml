   M S B A M L   `   `   `  ����D  @EquipServ, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:EquipServ.PagesEquipServ.Pages  5   	   '    !EquipServ.Pages.InformationWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:EquipServ.Pages     5   	     � Title$  InformationWindow��5   	      AnotherWindows#��[  6#    � WindowStartupLocation$ CenterScreen=�6K    � DataContext 6p   ��  �� Mode$ OneWay=� �� RelativeSource �� *Self+.��5	      �  � ColumnDefinitions 5
   
   �� 5      $	��200 �6   �� 5      $��1* �6    � RowDefinitions 5   
   �� 5      $	��100 �6   �� 5      $��1* �6   .+�5   
   �� $��/Images/settings.png��6   $	��103��6.   $��81��6:   $��0��6F   $��0��6S   $��0 0 80 0q�6c   6w   �� 5   
   $��1��6   $��0��6"   $��0 30 0 0q�62   .+�5      �� -   5          
Navigation#��[ 5   '   $��
Выход��6K   6]   �� 5      -   5         ��Name$ 
addingbook��5      #��[ 68   $��	0 20 0 20q�6\   $��
Назад��6o   6�   5      �� 5   
    
 MenuUp#��[ 6   $��0��65   $��1��6B   $��0 0 0 30q�6R   .+�5      ��  �� Orientation$ 
Horizontal=�6   .+�5      �� .��6   &$Информация о работе6-   5      5      �� 5   
   $��1��6   $��1��6"   $��Center=�62   .+�5      �� .��6   $"Количество заявок:5!      �� 5"      -   5        	 ��Name$	 countReq��5"      5$      �� 5%      .��6   1/Среднее время выполнения:5'      �� 5(      -   5        $	 midTime��5(      5*      �� 5+      .��6   CAСтатистика по типам не исправности:5-      �� 5.      $ 
Horizontal=�6   .+�5/      �� .��6   Автономное:6%   �� 50      -   5        $	 auton��50      .��6'   26*   51      �� 52      $ 
Horizontal=�6   .+�53      �� .��6   Бытовое:6"   �� 54      -   5        $
	 tech��54      .��6&   26)   55      �� 56      $ 
Horizontal=�6   .+�57      �� .��6   Механическое:6'   �� 58      -   5        $
	 mech��58      .��6&   26)   59      5:      5;      5<      