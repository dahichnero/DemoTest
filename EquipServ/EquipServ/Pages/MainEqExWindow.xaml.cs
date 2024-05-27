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
    /// Логика взаимодействия для MainEqExWindow.xaml
    /// </summary>
    public partial class MainEqExWindow : Window
    {
        User findUser;
        ServiceEquipmentContext context;
        public ObservableCollection<Request> Requests { get; private set; }
        public MainEqExWindow(User user)
        {
            findUser = user;
            context = new ServiceEquipmentContext();
            InitializeComponent();
            Requests = new ObservableCollection<Request>(context.Requests.Include(x => x.Client).Include(x => x.Equipment).Include(z => z.Status).Include(z => z.TypeOfFault).Include(z => z.Comment).Include(s => s.ExecutorRequests.Where(x => x.UserExecutor == findUser.UserId)).ThenInclude(p => p.UserExecutorNavigation));
        }

        private void CloseAway (object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void toInformation (object sender, RoutedEventArgs e)
        {
            InformationWindow information = new InformationWindow(findUser);
            information.Show();
            this.Close();
        }

        private void toAnnounce (object sender, RoutedEventArgs e)
        {
            AnnounceWindow announce = new AnnounceWindow(findUser);
            announce.Show();
            this.Close();
        }

        private void toMainPage (object sender, RoutedEventArgs e)
        {
            MainEqExWindow mainEqWindow = new MainEqExWindow(findUser);
            mainEqWindow.Show();
            this.Close();
        }

        private void addComment (object sender, RoutedEventArgs e)
        {
            var req = (sender as Button)?.DataContext as Request;
            if (req is null)
                return;
            AddCommentWindow addComment = new AddCommentWindow(findUser,req);
            addComment.Show();
            this.Close();
        }


        private IQueryable<Request> applySearch (IQueryable<Request> query) =>
        query.Where(q => q.Description.Contains(searchTextBox.Text) ||
        q.StatusNavigation.StatusName.Contains(searchTextBox.Text) || q.TypeOfFaultNavigation.TypeOfFaultName.Contains(searchTextBox.Text) || q.EquipmentNavigation.EquipmentName.Contains(searchTextBox.Text)
        || q.ClientNavigation.ClientLastName.Contains(searchTextBox.Text));
        private void applyFilters ()
        {

            Requests.Clear();
            IQueryable<Request> query = context.Requests.Include(x => x.Client).Include(x => x.Equipment).Include(z => z.Status).Include(z => z.TypeOfFault).Include(z => z.Comment).Include(s => s.ExecutorRequests.Where(x => x.UserExecutor == findUser.UserId)).ThenInclude(p => p.UserExecutorNavigation).AsQueryable();
            query = applySearch(query);
            foreach (Request service in query)
            {
                Requests.Add(service);
            }
        }
        private void search (object sender, TextChangedEventArgs e)
        {
            applyFilters();
        }
    }
}
