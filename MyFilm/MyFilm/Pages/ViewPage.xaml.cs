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
using System.Linq;

namespace MyFilm.Pages
{
    /// <summary>
    /// Interaction logic for ViewPage.xaml
    /// </summary>
    public partial class ViewPage : Page
    {
        private readonly FilmContext _сontext;
        public ViewPage()
        {
            _сontext = new FilmContext();
            InitializeComponent();
        }

        private void Label_MouseDown_Watch(object sender, MouseButtonEventArgs e)
        {
            NavigationService.Navigate(new Uri("Pages/MoviePage.xaml", UriKind.Relative));
        }

        private void Label_MouseDown_Watch1(object sender, MouseButtonEventArgs e)
        {
            NavigationService.Navigate(new Uri("Pages/MoviePage.xaml", UriKind.Relative));
        }

        private void Button_Click_AddFilm(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("Pages/AddFilmPage.xaml", UriKind.Relative));
        }

        private void Button_Click_Exit(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("Pages/StartPage.xaml", UriKind.Relative));
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            var muvies = _сontext.Movies.ToList();

            foreach (var item in muvies)
            {
                var grid = new Grid();
                grid = filmGrid;
                (grid.Parent as StackPanel).Children.Remove(grid);
                nameFilmLable.Content = item.FilmName;
                yearFilmLable.Content = item.FilmYear;
                countryFilmLable.Content = item.FilmYear;
                genreFilmLable.Content = item.FilmGenre;
                directorFilmLable.Content = item.FilmDirector;
                timeFilmLable.Content = item.FilmTime;
                actorFilmLable.Content = item.FilmActor;
                aboutFilmLable.Content = item.FilmAbout;

                mainFilmGrid.Children.Add(grid);
            }
        }
    }
}
