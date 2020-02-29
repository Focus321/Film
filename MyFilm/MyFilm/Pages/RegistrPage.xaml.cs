using MyFilm.Context;
using MyFilm.Models;
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

namespace MyFilm.Pages
{
    /// <summary>
    /// Interaction logic for RegistrPage.xaml
    /// </summary>
    public partial class RegistrPage : Page
    {
        private readonly FilmContext _сontext;
        public RegistrPage()
        {
            _сontext = new FilmContext();
            InitializeComponent();
        }

        private async void Button_Click_Next(object sender, RoutedEventArgs e)
        {
            var user = _сontext.Users.Add(new User() {Login = logintext.Text, Number = phonenumbertext.Text,Password = passwordtext.Text});
           await _сontext.SaveChangesAsync();
            NavigationService.Navigate(new Uri("Pages/StartPage.xaml", UriKind.Relative));
        }

        private void Button_Click_Back(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("Pages/StartPage.xaml", UriKind.Relative));
        }
    }
}
