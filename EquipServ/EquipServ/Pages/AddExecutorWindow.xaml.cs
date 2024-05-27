using Azure.Core;
using EquipServ.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
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
    /// Логика взаимодействия для AddExecutorWindow.xaml
    /// </summary>
    public partial class AddExecutorWindow : Window
    {
        User findUser;
        ServiceEquipmentContext context;
        Models.Request RequestFind;
        ExecutorRequest ExecutorRequest;
        public List<User> Executors { get; set; }
        public AddExecutorWindow(User user, int reqId, ExecutorRequest ex)
        {
            context = new ServiceEquipmentContext();
            findUser = user;
            RequestFind = context.Requests.First(x => x.RequestId == reqId);
            ExecutorRequest = ex;
            Executors = context.Users.Where(x => x.Role == 3).ToList();
            ExecutorRequest.Request = reqId;
            InitializeComponent();
            if (ex is null)
            {
                choose.Content = "Изменение ответсвенного";
            }
            info.Content= RequestFind.Description + RequestFind.Date + RequestFind.Srok + RequestFind.SerialNumber + RequestFind.ClientNavigation.ClientName + RequestFind.ClientNavigation.ClientLastName
                + RequestFind.EquipmentNavigation.EquipmentName + RequestFind.StatusNavigation.StatusName + RequestFind.TypeOfFaultNavigation.TypeOfFaultName;
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
            requestAnnounce.Request = RequestFind.RequestId;
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
                AddAnnounce(2);
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
