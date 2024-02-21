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
using NidzhatUP.nidzhatDataSetTableAdapters;

namespace NidzhatUP
{
    /// <summary>
    /// Логика взаимодействия для HistoryPage.xaml
    /// </summary>
    public partial class HistoryPage : Page
    {
        request_historyTableAdapter requestHistoryTableAdapter = new request_historyTableAdapter();
        /// <summary>
        /// Конструктор, получающий данные из БД и устанавливающий их отображение в таблице.
        /// </summary>
        /// <param name="id"></param>
        public HistoryPage(int id)
        {
            InitializeComponent();
            Table.ItemsSource = requestHistoryTableAdapter.GetDataBy1(id);
        }
    }
}
