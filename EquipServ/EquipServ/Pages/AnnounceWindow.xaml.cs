
using EquipServ.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Логика взаимодействия для AnnounceWindow.xaml
    /// </summary>
    public partial class AnnounceWindow : Window
    {
        User findUser;
        ServiceEquipmentContext context;
        public ObservableCollection<RequestAnnounce> RequestsAnnounces { get; private set; }
        public AnnounceWindow(User user )
        {
            findUser = user;
            context = new ServiceEquipmentContext();
            InitializeComponent();
            RequestsAnnounces = new ObservableCollection<RequestAnnounce>(context.RequestAnnounces.Include(z => z.AnnounceNavigation).Include(x => x.RequestNavigation).Include(x => x.RequestNavigation.EquipmentNavigation).Include(x=>x.RequestNavigation.ClientNavigation).Include(x=>x.RequestNavigation.CommentNavigation).
                Include(x=>x.RequestNavigation.StatusNavigation));
        }

        private void toBack (object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void CloseAway (object sender, RoutedEventArgs e)
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
