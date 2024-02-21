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
    /// Логика взаимодействия для ClientWindow.xaml
    /// </summary>
    public partial class ClientWindow : Window
    {
        int id;
        /// <summary>
        /// Конструктор окна клиента, устанавливающий отображение контента и удаляющий из него кнопки удаления и изменения.
        /// </summary>
        /// <param name="client_id">Собственный id, полученный из окна авторизации</param>
        public ClientWindow(int client_id)
        {
            InitializeComponent();
            ClientsReqPage clientsReqPage = new ClientsReqPage();
            clientsReqPage.Change.Visibility = Visibility.Collapsed;
            clientsReqPage.Delete.Visibility = Visibility.Collapsed;
            Frame.Content = clientsReqPage;
            id = client_id;
        }
        /// <summary>
        /// Меняет отображение на страницу запросов и удаляет из нее кнопки удаления и изменения.
        /// </summary>
        /// <param name="sender">Объект, откуда вызывался метод</param>
        /// <param name="e">Событие, которое вызвало метод</param>
        private void Client_Click(object sender, RoutedEventArgs e)
        {
            ClientsReqPage clientsReqPage = new ClientsReqPage();
            clientsReqPage.Change.Visibility = Visibility.Collapsed;
            clientsReqPage.Delete.Visibility = Visibility.Collapsed;
            Frame.Content = clientsReqPage;
        }
        /// <summary>
        /// Меняет отображение на страницу запросов и удаляет из нее кнопки удаления и изменения.
        /// </summary>        
        /// <param name="sender">Объект, откуда вызывался метод</param>
        /// <param name="e">Событие, которое вызвало метод</param>
        private void History_Click(object sender, RoutedEventArgs e)
        {
            HistoryPage historyPage = new HistoryPage(id);
            Frame.Content = historyPage;
        }
    }
}
