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
    /// Логика взаимодействия для ModerWindow.xaml
    /// </summary>
    public partial class ModerWindow : Window
    {
        public ModerWindow()
        {
            InitializeComponent();
            ClientsReqPage clientsReqPage = new ClientsReqPage();
            clientsReqPage.Change.Visibility = Visibility.Collapsed;
            Frame.Content = clientsReqPage;
        }

        private void Client_Click(object sender, RoutedEventArgs e)
        {
            ClientsReqPage clientsReqPage = new ClientsReqPage();
            clientsReqPage.Change.Visibility = Visibility.Collapsed;
            Frame.Content = clientsReqPage;
        }

        private void Analytics_Click(object sender, RoutedEventArgs e)
        {
            AnalyticsPage analyticsPage = new AnalyticsPage();
            Frame.Content = analyticsPage;
        }
    }
}
