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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NidzhatUP
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Конструктор окна, устанавливающий отображение визуальных элементов
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Открывает окно регистрации, закрывая текущее.
        /// </summary>        
        /// <param name="sender">Объект, откуда вызывался метод</param>
        /// <param name="e">Событие, которое вызвало метод</param>
        private void Reg_Click(object sender, RoutedEventArgs e)
        {
            RegistrationWindow window = new RegistrationWindow();
            window.Show();
            Close();
        }
        /// <summary>
        /// Открывает окно авторизации, закрывая текущее
        /// </summary>
        /// <param name="sender">Объект, откуда вызывался метод</param>
        /// <param name="e">Событие, которое вызвало метод</param>
        private void Auth_Click(object sender, RoutedEventArgs e)
        {
            AuthorizationWindow window = new AuthorizationWindow();
            window.Show();
            Close();
        }
    }
}
