using System;
using System.Collections.Generic;
using System.Data;
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
using NidzhatUP.nidzhatDataSetTableAdapters;

namespace NidzhatUP
{
    /// <summary>
    /// Логика взаимодействия для ClientsReqPage.xaml
    /// </summary>
    public partial class ClientsReqPage : Page
    {
        client_requestTableAdapter crta = new client_requestTableAdapter();
        request_statusTableAdapter rsta = new request_statusTableAdapter();
        request_historyTableAdapter rhta = new request_historyTableAdapter();
        public ClientsReqPage()
        {
            InitializeComponent();
            Table.ItemsSource = crta.GetData();
            Status.ItemsSource = rsta.GetData();
            Status.DisplayMemberPath = "request_status";
        }

        private void Clear_Click_Text(object sender, RoutedEventArgs e)
        {
            Text.Clear();
        }

        private void Clear_Click_Client(object sender, RoutedEventArgs e)
        {
            Client.Clear();
        }

        private void Change_Click(object sender, RoutedEventArgs e)
        {
            if (Table.SelectedIndex != -1)
            {
                try
                {
                    crta.UpdateQuery(Convert.ToInt32(Client.Text), Convert.ToInt32((Status.SelectedItem as DataRowView).Row[0]), Text.Text, Convert.ToInt32(Moderator.Text), Convert.ToInt32((Table.SelectedItem as DataRowView).Row[4]));
                    Refresh();
                }
                catch (Exception)
                {
                    MessageBox.Show("Неверно введены данные! Данные должны быть другого типа.");
                }
            }
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (Table.SelectedIndex != -1)
                {
                    crta.DeleteQuery(Convert.ToInt32((Table.SelectedItem as DataRowView).Row[4]));
                    Refresh();
                }
            }
            catch (Exception)
            {
                MessageBox.Show($"Непредиденная ошибка!");
                throw;
            }
        }
        private void Add_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int statusId = 0;
                if (Status.SelectedItem != null)
                {
                    DataRowView selectedStatus = (DataRowView)Status.SelectedItem;
                    statusId = Convert.ToInt32(selectedStatus.Row[0]);
                }
                crta.InsertQuery(Convert.ToInt32(Client.Text), statusId, Text.Text, Convert.ToInt32(Moderator.Text));
                rhta.InsertQuery(Convert.ToInt32(Client.Text), (int)crta.GetMaxId());
                Refresh();
            }
            catch (Exception)
            {
                MessageBox.Show("Неверно введены данные! Данные должны быть другого типа.");
            }
        }

        private void Clear_Click_Moderator(object sender, RoutedEventArgs e)
        {
            Moderator.Clear();
        }

        private void Table_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Table.SelectedIndex != -1)
            {
                try
                {
                    Client.Text = Convert.ToString((Table.SelectedItem as DataRowView).Row[0]);
                    int statusId = Convert.ToInt32((Table.SelectedItem as DataRowView).Row[1]); 
                    foreach (DataRowView item in Status.Items)
                    {
                        if (Convert.ToInt32(item.Row[0]) == statusId)
                        {
                            Status.SelectedItem = item;
                            break;
                        }
                    }
                    Text.Text = Convert.ToString((Table.SelectedItem as DataRowView).Row[2]);
                    Moderator.Text = Convert.ToString((Table.SelectedItem as DataRowView).Row[3]);
                }
                catch (Exception)
                {
                    MessageBox.Show("Выбран неверный элемент!");
                }
            }
        }
        private void Refresh()
        {
            Table.ItemsSource = null;
            Table.ItemsSource = crta.GetData();
        }
    }
}
