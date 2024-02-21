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

namespace NidzhatUP
{
    /// <summary>
    /// Логика взаимодействия для AdminWindow.xaml
    /// </summary>
    public partial class AdminWindow : Window
    {
        int id;
        /// <summary>
        /// Конструктор класса окна Администратора. Устанавливает отображение страницы и сохраняет id.
        /// </summary>
        /// <param name="admin_id">Собственное id из окна авторизации</param>
        public AdminWindow(int admin_id)
        {
            InitializeComponent();
            ClientsReqPage clientsReqPage = new ClientsReqPage();
            Frame.Content = clientsReqPage;
            id = admin_id;
        }
        /// <summary>
        /// Переключает отображение фрейма на страницу истории.
        /// </summary>
        /// <param name="sender">Объект, откуда вызывался метод</param>
        /// <param name="e">Событие, которое вызвало метод</param>
        private void History_Click(object sender, RoutedEventArgs e)
        {
            HistoryPage historyPage = new HistoryPage(id);
            Frame.Content = historyPage;
        }
        /// <summary>
        /// Переключает отображение фрейма на страницу аналитики.
        /// </summary>
        /// <param name="sender">Объект, откуда вызывался метод</param>
        /// <param name="e">Событие, которое вызвало метод</param>
        private void Analysis_Click(object sender, RoutedEventArgs e)
        {
            AnalyticsPage analyticsPage = new AnalyticsPage();
            Frame.Content = analyticsPage;
        }
        /// <summary>
        /// Переключает отображение фрейма на страницу запросов.
        /// </summary>
        /// <param name="sender">Объект, откуда вызывался метод</param>
        /// <param name="e">Событие, которое вызвало метод</param>
        private void Client_Click(object sender, RoutedEventArgs e)
        {
            ClientsReqPage clientsReqPage = new ClientsReqPage();
            Frame.Content = clientsReqPage;
        }
    }
}
