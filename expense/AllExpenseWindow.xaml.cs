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

namespace expense
{
    /// <summary>
    /// Логика взаимодействия для AllExpenseWindow.xaml
    /// </summary>
    public partial class AllExpenseWindow : Window
    {
        public AllExpenseWindow()
        {
            InitializeComponent();
            DataGrid.ItemsSource = ExpenseEntities.GetContext().ExpenseUser.ToList();
        }

        private void btnGetExpenseClick(object sender, RoutedEventArgs e)
        {

        }
    }
}
