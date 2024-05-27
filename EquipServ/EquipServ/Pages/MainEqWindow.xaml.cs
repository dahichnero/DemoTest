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
using static System.Collections.Specialized.BitVector32;
using static System.Reflection.Metadata.BlobBuilder;

namespace EquipServ.Pages
{
    /// <summary>
    /// Логика взаимодействия для MainEqWindow.xaml
    /// </summary>
    public partial class MainEqWindow : Window
    {
        User findUser;
        ServiceEquipmentContext context;
        public ObservableCollection<Request> Requests { get; private set; }
        public MainEqWindow(User user)
        {
            context = new ServiceEquipmentContext();
            findUser = user;
            InitializeComponent();
            Requests=new ObservableCollection<Request>(context.Requests.Include(x=>x.Client).Include(x=>x.Equipment).Include(z=>z.Status).Include(z=>z.TypeOfFault).Include(z=>z.Comment).Include(s=>s.ExecutorRequests).ThenInclude(p=>p.UserExecutorNavigation));
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
            MainEqWindow mainEqWindow = new MainEqWindow(findUser);
            mainEqWindow.Show();
            this.Close();
        }

        private void toAddRequest (object sender, RoutedEventArgs e)
        {
            AddRequestWindow requestWindow = new AddRequestWindow(findUser, null);
            requestWindow.Show();
            this.Close();
        }


        private IQueryable<Request> applySearch (IQueryable<Request> query) =>
        query.Where(q => q.Description.Contains(searchTextBox.Text) ||
        q.StatusNavigation.StatusName.Contains(searchTextBox.Text) || q.TypeOfFaultNavigation.TypeOfFaultName.Contains(searchTextBox.Text) || q.EquipmentNavigation.EquipmentName.Contains(searchTextBox.Text)
        || q.ClientNavigation.ClientLastName.Contains(searchTextBox.Text));
        private void applyFilters ()
        {

            Requests.Clear();
            IQueryable<Request> query = context.Requests.Include(x => x.Client).Include(x => x.Equipment).Include(z => z.Status).Include(z => z.TypeOfFault).Include(z => z.Comment).Include(s => s.ExecutorRequests).ThenInclude(p => p.UserExecutorNavigation).AsQueryable();
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

        private void change (object sender, RoutedEventArgs e)
        {
            var req = (sender as Button)?.DataContext as Request;
            if (req is null)
                return;
            AddRequestWindow addRequest = new AddRequestWindow(findUser, req);
            addRequest.Show();
            this.Close();
        }

        private void addExecutor (object sender, RoutedEventArgs e)
        {
            var req = (sender as Button)?.DataContext as Request;
            if (req is null)
                return;
            AddExecutorWindow addExecutor = new AddExecutorWindow(findUser, req.RequestId,null);
            addExecutor.Show();
            this.Close();
        }

        private void changeEx (object sender, RoutedEventArgs e)
        {
            var reqEx = (sender as Button)?.DataContext as ExecutorRequest;
            if (reqEx is null)
                return;
            AddExecutorWindow addExecutor = new AddExecutorWindow(findUser, reqEx.Request, reqEx);
            addExecutor.Show();
            this.Close();
        }
    }
}
