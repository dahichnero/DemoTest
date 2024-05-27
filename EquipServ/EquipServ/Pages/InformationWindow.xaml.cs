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
    /// Логика взаимодействия для InformationWindow.xaml
    /// </summary>
    public partial class InformationWindow : Window
    {
        User findUser;
        ServiceEquipmentContext context;
        public InformationWindow(User user)
        {
            findUser = user;
            context = new ServiceEquipmentContext();
            InitializeComponent();
            countReq.Content = context.Requests.Count(z=>z.Status==1);
            midTime.Content = context.Requests.Average(z=>z.Srok.DayNumber-z.Date.DayNumber);
            auton.Content = context.Requests.Count(z=>z.Status==1 && z.TypeOfFault==1);
            tech.Content = context.Requests.Count(z=>z.Status==1 && z.TypeOfFault==2);
            mech.Content = context.Requests.Count(z => z.Status == 1 && z.TypeOfFault == 3);
        }

        private void CloseAway (object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void toBack (object sender, RoutedEventArgs e)
        {
            switch (findUser.Role)
            {
                case 1:
                    MainEqWindow mainEqWindow = new MainEqWindow(findUser);
                    mainEqWindow.Show();
                    this.Close();
                    break;
                case 3:
                    MainEqExWindow mainEqExWindow = new MainEqExWindow(findUser);
                    mainEqExWindow.Show();
                    this.Close();
                    break;
                case 2:
                    MainEqmaWindow mainEqma = new MainEqmaWindow(findUser);
                    mainEqma.Show();
                    this.Close();
                    break;
            }
        }
    }
}
