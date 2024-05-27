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
using static System.Collections.Specialized.BitVector32;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EquipServ.Pages
{
    /// <summary>
    /// Логика взаимодействия для AddRequestWindow.xaml
    /// </summary>
    public partial class AddRequestWindow : System.Windows.Window
    {
        User findUser;
        Request Requestt;
        ServiceEquipmentContext context;
        public List<Equipment> Equipments { get; set; }
        public List<TypeOfFault> TypeOfFaults { get; set; }

        public List<Client> Clients { get; set; }

        public List<Models.Status> Statuses { get; set; }
        public AddRequestWindow(User user, Request request)
        {
            context=new ServiceEquipmentContext();
            findUser = user;
            Requestt = request;
            Equipments = context.Equipment.ToList();
            TypeOfFaults = context.TypeOfFaults.ToList();
            Clients=context.Clients.ToList();
            Statuses=context.Statuses.ToList();
            InitializeComponent();
            if (Requestt.RequestId != 0 && findUser.Role==1)
            {
                sNum.IsEnabled = false;
                exDate.IsEnabled = false;
                srokDate.IsEnabled = false;
                EqC.IsEnabled = false;
                Typec.IsEnabled = false;
                ClientC.IsEnabled = false;
                choose.Content = "Изменение заявки";
            }
            if (Requestt.RequestId != 0 && findUser.Role == 2)
            {
                sNum.IsEnabled = false;
                exDate.IsEnabled = false;
                EqC.IsEnabled = false;
                Typec.IsEnabled = false;
                ClientC.IsEnabled = false;
                statusC.IsEnabled = false;
                descriptions.IsEnabled = false;
                choose.Content = "Изменение заявки";
            }
        }


        public void AddAnnounce (int announ)
        {
            RequestAnnounce requestAnnounce = new RequestAnnounce();
            requestAnnounce.Announce = announ;
            requestAnnounce.Request = Requestt.RequestId;
            context.RequestAnnounces.Add(requestAnnounce);
            context.SaveChanges();
        }
        private void addorupdate (object sender, RoutedEventArgs e)
        {
            if (Requestt.RequestId == 0)
            {
                context.Requests.Add(Requestt);
            }
            try
            {
                if (Requestt.RequestId != 0)
                {
                    AddAnnounce(3);
                }
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
                context.Requests.Remove(Requestt);
            }
        }

        private void rem (object sender, RoutedEventArgs e)
        {
            if (Requestt.RequestId != 0)
            {
                context.Entry(Requestt).Reload();
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
    }
}
