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
        public AdminWindow()
        {
            InitializeComponent();
            ClientsReqPage clientsReqPage = new ClientsReqPage();
            Frame.Content = clientsReqPage;
        }

        private void History_Click(object sender, RoutedEventArgs e)
        {
            HistoryPage historyPage = new HistoryPage();
            Frame.Content = historyPage;
        }

        private void Analysis_Click(object sender, RoutedEventArgs e)
        {
            AnalyticsPage analyticsPage = new AnalyticsPage();
            Frame.Content = analyticsPage;
        }

        private void Client_Click(object sender, RoutedEventArgs e)
        {
            ClientsReqPage clientsReqPage = new ClientsReqPage();
            Frame.Content = clientsReqPage;
        }
    }
}
