using ProkatSQl.Pages.Cars;
using ProkatSQl.Pages.Clients;
using ProkatSQl.Pages.PriceList;
using ProkatSQl.Pages.Rentals;
using ProkatSQl.Pages.Statistics;
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

namespace ProkatSQl
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // Метод для закрытия окна
        private void CloseWindow(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        // Метод для сворачивания окна
        private void MinimizeWindow(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }


    
        // Метод для перехода на страницу "Клиенты"
        private void NavigateToClients(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new ClientsPage()); // Предполагается, что у вас есть страница ClientsPage
        }

        // Метод для перехода на страницу "Автомобили"
        private void NavigateToCars(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new CarsPage()); // Убедитесь, что название класса совпадает
        }

        // Метод для перехода на страницу "Прокат"
        private void NavigateToRentals(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new RentalsPage()); // Предполагается, что у вас есть страница RentalsPage
        }

        // Метод для перехода на страницу "Прайс-лист"
        private void NavigateToPriceList(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new PriceListPage()); // Предполагается, что у вас есть страница PriceListPage
        }

        // Метод для перехода на страницу "Статистика"
        private void NavigateToStatistics(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new StatisticsPage()); // Предполагается, что у вас есть страница StatisticsPage
        }
    }
}
