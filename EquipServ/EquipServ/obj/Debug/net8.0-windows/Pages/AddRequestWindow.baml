   M S B A M L   `   `   `  ����D  @EquipServ, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:EquipServ.PagesEquipServ.Pages  5   	   &     EquipServ.Pages.AddRequestWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:EquipServ.Pages     5   	     � Title$  AddRequestWindow��5   	      AnotherWindows#��[  6"    � WindowStartupLocation$ CenterScreen=�6J    � DataContext 6o   ��  �� Mode$ OneWay=� �� RelativeSource �� *Self+.��5	      �  � ColumnDefinitions 5
   
   �� 5      $	��200 �6   �� 5      $��1* �6    � RowDefinitions 5   
   �� 5      $	��100 �6   �� 5      $��1* �6   .+�5   
   �� $��/Images/settings.png��6   $	��103��6.   $��81��6:   $��0��6F   $��0��6S   $��0 0 80 0q�6c   6w   �� 5   
   $��1��6   $��0��6"   $��0 30 0 0q�62   .+�5      �� -   5          
Navigation#��[ 5   $   $��0 0 0 20q�6H   $��
Назад��6Z   6l   �� 5      -   5        #��[ 5   "   $��0 0 0 20q�6F   $��
Выход��6X   6j   5      �� 5   
   -   5         ��Name$ choose��5      $��0��6    $��1��6-    
 Header#��[ 6=   $��	30 35 0 0q�6]   .��6p   #!Добавление заявки6�   �� 5   
   $��1��6   $��1��6"   $��
30,30,0,25q�62    �� Orientation$ 
Horizontal=�6F   .+�5      �� .+�5      �� .��6   Описание:6#   �� 5      -   5        	 ��Name$	 descriptions��5      ��60   �� *Requestt.Description+.��6V   5      �� 5      6   �� 5      .��6   Серийный номер:6)   �� 5       -   5        $
	 sNum��5       ��6(   �� *Requestt.SerialNumber+.��6O   5!      �� 5"      6   �� 5#      .��6   Дата начала:6&   (  "System.Windows.Controls.DatePicker  5$      -   5        
  Name$
 exDate��5$         SelectedDate 6-   �� *Requestt.Date+6V   �� 5%      6   �� 5&      .��6   Дата срока:6%     5'      -   5        $
 srokDate��5'       6/   �� *Requestt.Srok+6X   �� 5(      6   �� 5)      $ 
Horizontal=�6   .+�5*      �� .��6   Оборудование:6+   �� 5+      -   5         ��Name$	 EqC��5+   x   ��6   �� *
Equipments+ �� SelectedItem 6B   �� *Requestt.EquipmentNavigation+��5,      �� 5-      .R�5.   "   �� �� 5/   &   �6*   �� *EquipmentName+50   #   51      53      54      �� 56      $ 
Horizontal=�6   .+�57      �� .��6   Тип поломки:6*   �� 58      -	   5        $ Typec��58   |   ��6   �� *TypeOfFaults+ 6D   �� * Requestt.TypeOfFaultNavigation+��59      �� 5:      .R�5;   "   �� �� 5<      �6   �� *TypeOfFaultName+5=   #   5>      5@      5A      �� 5D      $ 
Horizontal=�6   .+�5E      �� .��6   Клиент:6%   �� 5F      -
   5        $ ClientC��5F   r   ��6   �� *	Clients+ 6?   �� *Requestt.ClientNavigation+��5G      �� 5H      .R�5I   "   �� �� 5J      �6   �� *
ClientName+ �� 5K   &   �6*   �� *ClientLastName+ �� 5L   &   �6*   �� *ClientSurName+5M   #   5N      5P      5Q      �� 5S      $ 
Horizontal=�6   .+�5T      �� .��6   Статус:6%   �� 5U      -   5        $ statusC��5U   s   ��6   �� *
Statuses+ 6@   �� *Requestt.StatusNavigation+��5V      �� 5W      .R�5X   "   �� �� 5Y   &   �6*   �� *
StatusName+5Z   #   5[      5]      5^      �� 5_      $ 
Horizontal=�6   $	��276��66   $
��Left=�6B   .+�5`      �� -   5         ��Name$	 add��5`        OformButton#��[ 6>   $��	0 10 10 0q�6c   .��6v   Добавить6�   �� 5a      -   5        #��[ 5a   )   $��
15 10 10 0q�6N   .��6b   Отменить6l   5b      5c      5e      5f      5g      