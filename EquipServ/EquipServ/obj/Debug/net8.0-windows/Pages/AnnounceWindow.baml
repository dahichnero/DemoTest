   M S B A M L   `   `   `  ����D  @EquipServ, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:EquipServ.PagesEquipServ.Pages  5   	   $    EquipServ.Pages.AnnounceWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:EquipServ.Pages     5   	     � Title$  AnnounceWindow��5   	      AnotherWindows#��[  6     � WindowStartupLocation$ CenterScreen=�6H    � DataContext 6m   ��  �� Mode$ OneWay=� �� RelativeSource �� *Self+.��5	      �  � ColumnDefinitions 5
   
   �� 5      $	��200 �6   �� 5      $��1* �6    � RowDefinitions 5   
   �� 5      $	��100 �6   �� 5      $��1* �6   .+�5   
   �� $��/Images/settings.png��6   $	��103��6.   $��81��6:   $��0��6F   $��0��6S   $��0 0 80 0q�6c   6w   �� 5   
   $��1��6   $��0��6"   $��0 30 0 0q�62   .+�5      �� -   5          
Navigation#��[ 5   '   $��
Назад��6K   6]   �� 5      -   5         ��Name$ 
addingbook��5      #��[ 68   $��	0 20 0 20q�6\   $��
Выход��6o   6�   5      �� 5   
    
 MenuUp#��[ 6   $��0��65   $��1��6B   $��0 0 0 30q�6R   .+�5      ��  �� Orientation$ 
Horizontal=�6   .+�5      �� .��6   Уведомления:6&   5      5      �� 5   
   -   5        	 ��Name$	 allRequests��5   �   $��1��6   $��1��6    $��Disabled=�61   ��6g   �� *RequestsAnnounces+��5      �� 5       .R�5!      � ���#F8F8FF$��0 0 0 0q�60    5"      �� 5#      $	��375 �6/   �� 5$      $	��140 �6/   �� 5%      $	��189 �6/   .+�5'      �� $��7q�6%   $��0��60   
 � ToolTip
 5(      �� 5)   "   �6&   �� *1/RequestNavigation.CommentNavigation.CommentName+.+�5+      �� $��16(�6(   $
��Wrap=�66   Описание: �� 5,      �6   �� *RequestNavigation.Description+�� 5-      
Тип: �� 5.      �6   �� *97RequestNavigation.TypeOfFaultNavigation.TypeOfFaultName+�� 5/      Статус: �� 50      �6   �� */-RequestNavigation.StatusNavigation.StatusName+�� 51      Клиент: �� 52      �6   �� */-RequestNavigation.ClientNavigation.ClientName+ Оборудование: �� 53      �6    �� *53RequestNavigation.EquipmentNavigation.EquipmentName+�� 54      
Дата: �� 55      �6   �� *RequestNavigation.Date+ Срок: �� 56      �6   �� *RequestNavigation.Srok+57      58      �� 59      $��2��6%   .+�5:      �� �� 5;      �6"   �� *!AnnounceNavigation.AnnounceName+5<      5=      5>      5?      ��5A      �� 5B      .R�5C      � 5D      5F      5G      5H      