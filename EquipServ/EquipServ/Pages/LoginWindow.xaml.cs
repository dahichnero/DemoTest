using EquipServ.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace EquipServ.Pages
{
    /// <summary>
    /// Логика взаимодействия для LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        ServiceEquipmentContext context;
        int count = 0;

        private string GetCaptcha()
        {
            Random rnd = new Random();
            int num = rnd.Next(6, 8);
            string captcha = "";
            int tot1 = 0;
            do
            {
                int chr = rnd.Next(48, 123);
                if ((chr >= 48 && chr <= 57) || (chr >= 65 && chr <= 90) || (chr >= 97 && chr <= 122))
                {
                    captcha += (char)chr;
                    tot1++;
                    if (tot1 == num)
                        break;
                }
            }
            while (true);
            return captcha;
        }
        public LoginWindow()
        {
            context = new ServiceEquipmentContext ();
            InitializeComponent();
            captchaEx.Content = GetCaptcha();
        }

        private void SignIn(object sender, RoutedEventArgs e)
        {
            string login = log.Text.Trim();
            string password = pass.Password.Trim();
            string captchaFull = cap.Text.Trim();
            if (String.IsNullOrEmpty(login) || String.IsNullOrEmpty(password) || String.IsNullOrEmpty(captchaFull) || captchaFull != captchaEx.Content)
            {
                log.Text = "";
                pass.Password = "";
                cap.Text = "";
                count++;
                MessageBox.Show("Access denied");
                captchaEx.Content = GetCaptcha();
                if (count == 10)
                {
                    log.IsEnabled = false;
                    pass.IsEnabled = false;
                    sign.IsEnabled = false;
                    cap.IsEnabled = false;
                    Thread.Sleep(10000); //DispatcherTimer
                    log.IsEnabled = true;
                    pass.IsEnabled = true;
                    sign.IsEnabled = true;
                    cap.IsEnabled = true;
                    count = 0;
                }
            }
            else
            {
                User? findUser = context.Users.FirstOrDefault(x => x.Login == login && x.Password == password);
                if (findUser is null)
                {
                    log.Text = "";
                    pass.Password = "";
                    cap.Text = "";
                    count++;
                    MessageBox.Show("Access denied");
                    captchaEx.Content = GetCaptcha();
                    if (count == 10)
                    {
                        log.IsEnabled = false;
                        pass.IsEnabled = false;
                        sign.IsEnabled = false;
                        cap.IsEnabled = false;
                        //DispatcherTimer
                        Thread.Sleep(10000);
                        log.IsEnabled = true;
                        pass.IsEnabled = true;
                        sign.IsEnabled = true;
                        cap.IsEnabled = true;
                        count = 0;
                    }
                }
                else
                {
                    switch (findUser.Role)
                    {
                        case 1:
                            MainEqWindow mainEq = new MainEqWindow(findUser);
                            mainEq.Show();
                            this.Close();
                            break;
                        case 2:
                            MainEqmaWindow mainEqMa = new MainEqmaWindow(findUser);
                            mainEqMa.Show();
                            this.Close();
                            break;
                        case 3:
                            MainEqExWindow mainEqEx = new MainEqExWindow(findUser);
                            mainEqEx.Show();
                            this.Close();
                            break;
                    }
                }
            }
        }
    }
}
