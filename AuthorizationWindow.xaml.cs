using System;
using System.Data;
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
using NidzhatUP.nidzhatDataSetTableAdapters;

namespace NidzhatUP
{
    /// <summary>
    /// Логика взаимодействия для Authorization.xaml
    /// </summary>
    public partial class AuthorizationWindow : Window
    {
        usersTableAdapter usersTableAdapter = new usersTableAdapter();
        public AuthorizationWindow()
        {
            InitializeComponent();
        }

        private void Auth_Click(object sender, RoutedEventArgs e)
        {
            string login = Login.Text;
            string password = Password.Text;
            bool reg = false;
            DataRowCollection AllLogins = usersTableAdapter.GetData().Rows;
            for (int i = 0; i < AllLogins.Count; i++)
            {
                if (AllLogins[i][1].ToString() == login && AllLogins[i][2].ToString() == password)
                {
                    reg = true;
                    switch (AllLogins[i][3])
                    {
                        case 1:
                            AdminWindow adminWindow = new AdminWindow(Convert.ToInt32(AllLogins[i][0]));
                            adminWindow.Show();
                            Close();
                            break;
                        case 2:
                            ModerWindow moderWindow = new ModerWindow();
                            moderWindow.Show();
                            Close();
                            break;
                        case 3:
                            ClientWindow clientWindow = new ClientWindow(Convert.ToInt32(AllLogins[i][0]));
                            clientWindow.Show();
                            Close();
                            break;
                        default:
                            MessageBox.Show("Произошел сбой в системе или функционал для вашей роли еще не разработан.");
                            break;
                    }
                }
            }
            if (!reg) MessageBox.Show("Неверный логин или пароль!");
        }
    }
}
