   M S B A M L   `   `   `  ����D  @EquipServ, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:EquipServ.PagesEquipServ.Pages  5   	   '    !EquipServ.Pages.NewExecutorWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:EquipServ.Pages     5   	     � Title$  NewExecutorWindow��5   	      AnotherWindows#��[  6#    � WindowStartupLocation$ CenterScreen=�6K    � DataContext 6p   ��  �� Mode$ OneWay=� �� RelativeSource �� *Self+.��5	      �  � ColumnDefinitions 5
   
   �� 5      $	��200 �6   �� 5      $��1* �6    � RowDefinitions 5   
   �� 5      $	��100 �6   �� 5      $��1* �6   .+�5   
   �� $��/Images/settings.png��6   $	��103��6.   $��81��6:   $��0��6F   $��0��6S   $��0 0 80 0q�6c   6w   �� 5   
   $��1��6   $��0��6"   $��0 30 0 0q�62   .+�5      �� -   5          
Navigation#��[ 5   $   $��0 0 0 20q�6H   $��
Назад��6Z   6l   �� 5      -   5        #��[ 5   "   $��0 0 0 20q�6F   $��
Выход��6X   6j   5      �� 5   
   -   5         ��Name$ choose��5      $��0��6    $��1��6-    
 Header#��[ 6=   $��	30 35 0 0q�6]   .��6p   ><Назначение нового ответсвенного6�   �� 5   
   $��1��6   $��1��6"   $��
30,30,0,25q�62    �� Orientation$ 
Horizontal=�6F   .+�5      �� .+�5      �� .��6   Описание:6#   �� 5      -   5        $
 info��5      .��6&   FDТут в виде текста информация о заявке6M   �� 5      $ 
Horizontal=�6   .+�5      �� .��6   Ответственный:6,   �� 5      ��6   �� *	Executors+	 �� SelectedItem	 6A   �� *(&ExecutorRequest.UserExecutorNavigation+��5       �� 5!      .R�5"   "   �� �� 5#   &   �6*   �� *Name+ �� 5$   &   �6*   �� *
LastName+ �� 5%   &   �6*   �� *	Surname+5&   #   5'      5)      5*      �� 5,      $ 
Horizontal=�6   $	��276��66   $
��Left=�6B   .+�5-      �� -   5        
 ��Name$	
 add��5-        OformButton#��[ 6>   $��	0 10 10 0q�6c   .��6v   Добавить6�   �� 5.      -   5        #��[ 5.   )   $��
15 10 10 0q�6N   .��6b   Отменить6l   5/      50      52      53      54      