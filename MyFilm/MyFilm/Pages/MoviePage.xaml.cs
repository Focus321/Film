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
    /// Interaction logic for MoviePage.xaml
    /// </summary>
    public partial class MoviePage : Page
    {
        public MoviePage()
        {
            InitializeComponent();
        }

        private void Image_MouseDown_Play(object sender, MouseButtonEventArgs e)
        {
            player.Source = new Uri("http://www.onirikal.com/videos/mp4/audi_a7.mp4");
            player.LoadedBehavior = MediaState.Manual;
            player.Play();


        }

        private void Button_Click_Back(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("Pages/ViewPage.xaml", UriKind.Relative));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //  player.Source = new Uri("http://www.onirikal.com/videos/mp4/audi_a7.mp4");


            //fullViewMedia.Source = new Uri("http://www.onirikal.com/videos/mp4/audi_a7.mp4");

            //fullViewMedia.Visibility = Visibility.Visible;
        }
    }
}