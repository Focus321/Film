using MyFilm.Context;
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

namespace MyFilm
{
    /// <summary>
    /// Interaction logic for StartPage.xaml
    /// </summary>
    public partial class StartPage : Page
    {
        private readonly FilmContext _context;
        public StartPage()
        {
            _context = new FilmContext();
            InitializeComponent();
        }

        private void Button_Click_Start(object sender, RoutedEventArgs e)
        {
            var user = _context.Users.Where(x => x.Login == logintext.Text && x.Password == passwordtext.Text).FirstOrDefault();
            if (user != null)
            {
                NavigationService.Navigate(new Uri("Pages/ViewPage.xaml", UriKind.Relative));
            }
            else
            {
                MessageBox.Show("User Not Found");
            }

        }

        private void Label_MouseDown_Registr(object sender, MouseButtonEventArgs e)
        {
            NavigationService.Navigate(new Uri("Pages/RegistrPage.xaml", UriKind.Relative));
        }

        private void Label_MouseDown_Recovery(object sender, MouseButtonEventArgs e)
        {
            NavigationService.Navigate(new Uri("Pages/RecoveryPage.xaml", UriKind.Relative));
        }
    }
}
