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

namespace expense
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            AvtorizationBorder.Visibility = Visibility.Visible;
            RegistrationPanel.Visibility = Visibility.Visible;
        }


        private void btnOpenPanelRegistrationClick(object sender, RoutedEventArgs e)
        {
            RegistrationBorder.Visibility = Visibility.Hidden;
            AvtorizationPanel.Visibility = Visibility.Hidden;

            AvtorizationBorder.Visibility = Visibility.Visible;
            RegistrationPanel.Visibility = Visibility.Visible;
        }

        private void btnOpenPanelEnterClick(object sender, RoutedEventArgs e)
        {
            AvtorizationBorder.Visibility = Visibility.Hidden;
            RegistrationPanel.Visibility = Visibility.Hidden;

            RegistrationBorder.Visibility = Visibility.Visible;
            AvtorizationPanel.Visibility = Visibility.Visible;
        }

        private void btnRegistrationClick(object sender, RoutedEventArgs e)
        {
            AddIndentificationUser addIndentification = new AddIndentificationUser();

            if (string.IsNullOrWhiteSpace(tbNewLogin.Text) == true 
                || string.IsNullOrWhiteSpace(tbNewPassword.Text) == true)
                MessageBox.Show("Вы заполнили не все поля!", "Сообщение системы", MessageBoxButton.OK, MessageBoxImage.Error);

            string result = addIndentification.AddUserInSystem(tbNewLogin.Text, tbNewPassword.Text);

            if (result == "success")
                MessageBox.Show("Вы зарегистрированы!", "Сообщение системы", MessageBoxButton.OK, MessageBoxImage.Information);

            if (result != "success")
                MessageBox.Show(result, "Сообщение системы", MessageBoxButton.OK, MessageBoxImage.Error);
        }

        private void btnAvtorizationClick(object sender, RoutedEventArgs e)
        {
            AddIndentificationUser addIndentification = new AddIndentificationUser();

            if (string.IsNullOrWhiteSpace(tbLogin.Text) == true
                || string.IsNullOrWhiteSpace(tbPassword.Text) == true)
                MessageBox.Show("Вы заполнили не все поля!", "Сообщение системы", MessageBoxButton.OK, MessageBoxImage.Error);

            string result = addIndentification.AvtorizationInSystem(tbLogin.Text, tbPassword.Text);

            if (result == "success")
                MessageBox.Show("Вы авторизованы!", "Сообщение системы", MessageBoxButton.OK, MessageBoxImage.Information);
            AllExpenseWindow allExpenseWindow = new AllExpenseWindow();
            allExpenseWindow.Show();

            if (result != "success")
                MessageBox.Show(result, "Сообщение системы", MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }
}
