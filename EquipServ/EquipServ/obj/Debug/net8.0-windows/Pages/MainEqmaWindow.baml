   M S B A M L   `   `   `  ����D  @EquipServ, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:EquipServ.PagesEquipServ.Pages  5   	   $    EquipServ.Pages.MainEqmaWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:EquipServ.Pages     5   	     � Title$  MainEqmaWindow��5   	      AnotherWindows#��[  6     � WindowStartupLocation$ CenterScreen=�6H    � DataContext 6m   ��  �� Mode$ OneWay=� �� RelativeSource �� *Self+.��5	      �  � ColumnDefinitions 5
   
   �� 5      $	��200 �6   �� 5      $��1* �6    � RowDefinitions 5   
   �� 5      $	��100 �6   �� 5      $��1* �6   .+�5   
   �� $��/Images/settings.png��6   $	��103��6.   $��81��6:   $��0��6F   $��0��6S   $��0 0 80 0q�6c   6w   �� 5   
   $��1��6   $��0��6"   $��0 30 0 0q�62   .+�5      �� -   5          
Navigation#��[ 5   '   $��
Выход��6K   6]   �� 5      -   5         ��Name$
 info��5      #��[ 69   $��	0 20 0 20q�6]   $��Информация��6p   6�   �� 5      -   5        $ announ��5      #��[ 68   $��0 0 0 20q�6\   $��Уведомления��6n   6�   �� 5      -   5        $
 main��5      #��[ 66   $%��Главная страница��6Z   6w   5      �� 5   
    
 MenuUp#��[ 6   $��0��65   $��1��6B   $��0 0 0 30q�6R   .+�5      ��  �� Orientation$ 
Horizontal=�6   .+�5      �� .��6   Поиск:6    �� 5      -   5        	 ��Name$	 searchTextBox��5        
MenuSearch#��[ 61   6l   �� 5      $	��200��6   6)   5       5!      �� 5"   
   -   5        
 ��Name$
 allRequests��5"   �   $��1��6   $��1��6    $��Disabled=�61   ��6g   �� *
Requests+��5#      �� 5$      .R�5%      � ���#F8F8FF$��0 0 0 0q�60    5&      �� 5'      $	��375 �6/   �� 5(      $	��140 �6/   �� 5)      $	��189 �6/   .+�5+      �� $��7q�6%   $��0��60    � ToolTip 5,      �� 5-   "   �6&   �� *CommentNavigation.CommentName+.+�5/      �� $��16(�6(   $
��Wrap=�66   Описание: �� 50      �6   �� *Description+�� 51   
   
Тип: �� 52      �6   �� *" TypeOfFaultNavigation.NameOfType+�� 53   
   Статус: �� 54      �6   �� *StatusNavigation.StatusName+�� 55   
   Клиент: �� 56      �6   �� *ClientNavigation.ClientName+ Оборудование: �� 57       �6$   �� *#!EquipmentNavigation.EquipmentName+�� 58      
Дата: �� 59      �6    �� *Date+ Срок: �� 5:      �6!   �� *Srok+5;      5<      �� 5=      $��1��6%   .+�5>      �� ��6+   �� *ExecutorRequests+��5?   "   �� 5@   &   .R�5A   *   �� -   5        .��5B   .   �� �� 5C      �6   �� *UserExecutorNavigation.Name+ �� 5D   .   �62   �� *!UserExecutorNavigation.LastName+ �� 5E   .   �62   �� * UserExecutorNavigation.Surname+5F   /   5G   +   5H   '   5J      5K      �� 5L      $��2��6&   $	��Top=�68   .+�5M      �� -   5          Help#��[ 5M   %   $��90 0 0 0q�6C   .��5N   "   �� $��./Images/user.png��6(   5O      �� 5P      -	   5        #��[ 5P   %   $��90 0 0 0q�6C   .��5Q   "   �� $��./Images/change.png��6(   5R      5S      5T      5U      ��5W      �� 5X      .R�5Y      � 5Z      5\      5]      5^      