   M S B A M L   `   `   `  ����D  @EquipServ, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:EquipServ.PagesEquipServ.Pages  5   	   !    EquipServ.Pages.LoginWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:EquipServ.Pages     5   	     � Title$  LoginWindow��5   	    � WindowStartupLocation$ CenterScreen=�6    	  Login#��[  6B   .��5	      �� .+�5
   
   ��   LoginLabels#��[ 6   $��Center=�65   .��6R   Вход в систему6b   �� 5   
   $��/Images/settings.png��6   $	��178��6.   $	��146��6:   $��	0 14 0 28q�6G   6\   �� 5   
   #��[ 6   $��	55 10 0 0q�65   .��6H   Логин:6P   �� 5   
   -   5         ��Name$	 log��5        	LoginPass#��[ 6   6D   �� 5   
     	LoginLine#��[ 6   $��0 0 0 20q�62   6F   �� 5   
   #��[ 6   $��55 0 0 0q�65   .��6G   Пароль:6P   G� 5   
   -   5         G�Name$
 pass��5      6&   �� 5   
   #��[ 6   $��0 0 0 20q�62   6F   �� 5   
   -   5         ��Name$ 	captchaEx��5      $��Italic$�6#   $
��Bold"�66   $��Center=�6H   $��18(�6e   $��Lucida Handwriting)�6s   
���  ��6�   �� 5   
   #��[ 6   $��	55 10 0 0q�65   .��6H   
Captcha:6R   �� 5   
   -   5        $	 cap��5      #��[ 6   6D   �� 5   
   #��[ 6   $��0 0 0 20q�62   6F   �� 5   
    �� Orientation$ 
Horizontal=�6   $��Center=�6/   .+�5      �� -   5         ��Name$
 sign��5   &    �� 	IsDefault$
 True��6   $��
Войти��64     LoginButton#��[ 6S   $��Center=�6x   6�   5      5      5      