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
    /// Логика взаимодействия для NewExecutorWindow.xaml
    /// </summary>
    public partial class NewExecutorWindow : Window
    {
        User findUser;
        ServiceEquipmentContext context;
        ExecutorRequest ExecutorRequest;
        Request request;
        public List<User> Executors { get; set; }
        public NewExecutorWindow(User user, Request req)
        {
            findUser = user;
            context= new ServiceEquipmentContext();
            request = req;
            Executors = context.Users.Where(x => x.Role == 3).ToList();
            InitializeComponent();
            info.Content = req.Description + req.Date + req.Srok + req.SerialNumber + req.ClientNavigation.ClientName + req.ClientNavigation.ClientLastName
                + req.EquipmentNavigation.EquipmentName + req.StatusNavigation.StatusName + req.TypeOfFaultNavigation.TypeOfFaultName;
            ExecutorRequest.Request = req.RequestId;
        }

        private void Backto (object sender, RoutedEventArgs e)
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

        private void Exit (object sender, RoutedEventArgs e)
        {
            this.Close();
        }


        public void AddAnnounce (int announ)
        {
            RequestAnnounce requestAnnounce = new RequestAnnounce();
            requestAnnounce.Announce = announ;
            requestAnnounce.Request = request.RequestId;
            context.RequestAnnounces.Add(requestAnnounce);
            context.SaveChanges();
        }
        private void addorupdate (object sender, RoutedEventArgs e)
        {
            if (ExecutorRequest.ExecutorReqId == 0)
            {
                context.ExecutorRequests.Add(ExecutorRequest);
            }
            try
            {
                AddAnnounce(1);
                context.SaveChanges();
                MessageBox.Show("Added");
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
            } catch
            {
                MessageBox.Show("Error");
                context.ExecutorRequests.Remove(ExecutorRequest);
            }
        }

        private void rem (object sender, RoutedEventArgs e)
        {
            if (ExecutorRequest.ExecutorReqId != 0)
            {
                context.Entry(ExecutorRequest).Reload();
            }
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
