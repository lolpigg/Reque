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
using NidzhatUP.nidzhatDataSetTableAdapters;

namespace NidzhatUP
{
    /// <summary>
    /// Логика взаимодействия для Registration.xaml
    /// </summary>
    public partial class RegistrationWindow : Window
    {
        usersTableAdapter usersTableAdapter = new usersTableAdapter();
        public RegistrationWindow()
        {
            InitializeComponent();
        }

        private void Reg_Click(object sender, RoutedEventArgs e)
        {
            string login = Login.Text;
            string password = Password.Text;
            string password2 = Password2.Text;
            if (password != password2)
            {
                MessageBox.Show("Пароли не совпадают!");
                return;
            }
            if (password.Length < 5)
            {
                MessageBox.Show("Пароль должен состоять из 5-ти или более символов.");
                return;
            }
            if (login.Length < 4)
            {
                MessageBox.Show("Логин должен состоять из 4-х или более символов.");
                return;
            }
            usersTableAdapter.InsertQuery(login, password, 3);
            MessageBox.Show("Вы успешно зарегистрированы!");
            MainWindow window = new MainWindow();
            window.Show();
            Close();
        }
    }
}
