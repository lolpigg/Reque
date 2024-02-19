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
    /// Логика взаимодействия для AnalyticsPage.xaml
    /// </summary>
    public partial class AnalyticsPage : Page
    {
        client_requestTableAdapter clientRequestTableAdapter = new client_requestTableAdapter();
        public AnalyticsPage()
        {
            InitializeComponent();
            DoneTable.ItemsSource = clientRequestTableAdapter.GetDataByStatus1();
            NotDoneTable.ItemsSource = clientRequestTableAdapter.GetDataByStatus2();
            DoneText.Text = $"Решено: {DoneTable.Items.Count-1}";
            NotDoneText.Text = $"Не решено: {NotDoneTable.Items.Count-1}";
        }
    }
}
