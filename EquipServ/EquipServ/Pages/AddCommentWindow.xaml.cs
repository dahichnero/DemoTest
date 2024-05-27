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
    /// Логика взаимодействия для AddCommentWindow.xaml
    /// </summary>
    public partial class AddCommentWindow : System.Windows.Window
    {
        public Comment Commentt;
        User findUser;
        Request reqw;
        ServiceEquipmentContext context;
        Comment findComment;
        public AddCommentWindow(User user, Request req)
        {
            findUser=user;
            reqw = req;
            context=new ServiceEquipmentContext();
            InitializeComponent();
            infoAbout.Content = reqw.Description + reqw.Date + reqw.Srok + reqw.SerialNumber + reqw.ClientNavigation.ClientName + reqw.ClientNavigation.ClientLastName
                +reqw.EquipmentNavigation.EquipmentName + reqw.StatusNavigation.StatusName + reqw.TypeOfFaultNavigation.TypeOfFaultName;
            //DataContext = this;
        }

        private void addorupdate (object sender, RoutedEventArgs e)
        {
            Commentt.Date = DateTime.Now;
            context.Comments.Add(Commentt);
            try
            {
                AddAnnounce(5);
                context.SaveChanges();
                MessageBox.Show("Комментарий создан");
                findComment = context.Comments.FirstOrDefault(z=>z.CommentName==Commentt.CommentName && z.Date==Commentt.Date);
                reqw.Comment = findComment.CommentId;
                context.Requests.Update(reqw);
                context.SaveChanges();
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
                MessageBox.Show("Ошибка");
                context.Comments.Remove(Commentt);
            }
        }

        public void AddAnnounce (int announ)
        {
            RequestAnnounce requestAnnounce = new RequestAnnounce();
            requestAnnounce.Announce = announ;
            requestAnnounce.Request = reqw.RequestId;
            context.RequestAnnounces.Add(requestAnnounce);
            context.SaveChanges();
        }

        private void rem (object sender, RoutedEventArgs e)
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
    }
}
