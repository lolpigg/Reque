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
        /// <summary>
        /// Конструктор окна модератора, устанавливающий отображение контента и удаляющий из него кнопку изменения.
        /// </summary>
        public ModerWindow()
        {
            InitializeComponent();
            ClientsReqPage clientsReqPage = new ClientsReqPage();
            clientsReqPage.Add.Visibility = Visibility.Collapsed;
            clientsReqPage.Text.Visibility = Visibility.Collapsed;
            clientsReqPage.TextClear.Visibility = Visibility.Collapsed;
            clientsReqPage.TextText.Visibility = Visibility.Collapsed;
            clientsReqPage.Moderator.Visibility = Visibility.Collapsed;
            clientsReqPage.ModeratorClear.Visibility = Visibility.Collapsed;
            clientsReqPage.ModeratorText.Visibility = Visibility.Collapsed;
            clientsReqPage.Client.Visibility = Visibility.Collapsed;
            clientsReqPage.ClientClear.Visibility = Visibility.Collapsed;
            clientsReqPage.ClientText.Visibility = Visibility.Collapsed;
            Frame.Content = clientsReqPage;
        }
        /// <summary>
        /// Меняет отображение на страницу запросов и удаляет из нее кнопку изменения.
        /// </summary>        
        /// <param name="sender">Объект, откуда вызывался метод</param>
        /// <param name="e">Событие, которое вызвало метод</param>
        private void Client_Click(object sender, RoutedEventArgs e)
        {
            ClientsReqPage clientsReqPage = new ClientsReqPage();
            clientsReqPage.Add.Visibility = Visibility.Collapsed;
            clientsReqPage.Text.Visibility = Visibility.Collapsed;
            clientsReqPage.TextClear.Visibility = Visibility.Collapsed;
            clientsReqPage.TextText.Visibility = Visibility.Collapsed;
            clientsReqPage.Moderator.Visibility = Visibility.Collapsed;
            clientsReqPage.ModeratorClear.Visibility = Visibility.Collapsed;
            clientsReqPage.ModeratorText.Visibility = Visibility.Collapsed;
            clientsReqPage.Client.Visibility = Visibility.Collapsed;
            clientsReqPage.ClientClear.Visibility = Visibility.Collapsed;
            clientsReqPage.ClientText.Visibility = Visibility.Collapsed;
            Frame.Content = clientsReqPage;
        }
        /// <summary>
        /// Меняет отображение на страницу аналитики запросов.
        /// </summary>        
        /// <param name="sender">Объект, откуда вызывался метод</param>
        /// <param name="e">Событие, которое вызвало метод</param>
        private void Analytics_Click(object sender, RoutedEventArgs e)
        {
            AnalyticsPage analyticsPage = new AnalyticsPage();
            Frame.Content = analyticsPage;
        }
    }
}
