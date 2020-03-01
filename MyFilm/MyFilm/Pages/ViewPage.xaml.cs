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
                var grid = new Grid() { Margin  = new Thickness(0,20,0,0) };

                grid.RowDefinitions.Add(new RowDefinition());
                grid.RowDefinitions.Add(new RowDefinition());
                grid.RowDefinitions.Add(new RowDefinition());
                grid.RowDefinitions.Add(new RowDefinition());
                grid.RowDefinitions.Add(new RowDefinition());
                grid.RowDefinitions.Add(new RowDefinition());
                grid.RowDefinitions.Add(new RowDefinition());
                grid.RowDefinitions.Add(new RowDefinition());

                grid.ColumnDefinitions.Add(new ColumnDefinition() { Width =new GridLength(0.5, GridUnitType.Star) });
                grid.ColumnDefinitions.Add(new ColumnDefinition());

                var backgraung = ((Brush)(new BrushConverter()).ConvertFrom("#FF292929"));
                var foregraung = ((Brush)(new BrushConverter()).ConvertFrom("#FFC0C0C5"));

                var nameLable = new Label() {Content = "Название Фильма:", Background = backgraung, HorizontalAlignment = HorizontalAlignment.Left, Foreground = foregraung };
                var yearLable = new Label() {Content = "Год:", Background = backgraung, HorizontalAlignment = HorizontalAlignment.Left, Foreground = foregraung };
                var countryLable = new Label() {Content = "Страна:", Background = backgraung, HorizontalAlignment = HorizontalAlignment.Left, Foreground = foregraung };
                var genreLable = new Label() {Content = "Жанр:", Background = backgraung, HorizontalAlignment = HorizontalAlignment.Left, Foreground = foregraung };
                var directorLable = new Label() {Content = "Режисер:", Background = backgraung, HorizontalAlignment = HorizontalAlignment.Left, Foreground = foregraung };
                var actorsLable = new Label() {Content = "В ролях:", Background = backgraung, HorizontalAlignment = HorizontalAlignment.Left, Foreground = foregraung };
                var timesLable = new Label() {Content = "Длительность:", Background = backgraung, HorizontalAlignment = HorizontalAlignment.Left, Foreground = foregraung };
                var aboutLable = new Label() {Content = "Про фильм:", Background = backgraung, HorizontalAlignment = HorizontalAlignment.Left, Foreground = foregraung };


                grid.Children.Add(nameLable);
                grid.Children.Add(yearLable);
                grid.Children.Add(countryLable);
                grid.Children.Add(genreLable);
                grid.Children.Add(directorLable);
                grid.Children.Add(actorsLable);
                grid.Children.Add(timesLable);
                grid.Children.Add(aboutLable);

                Grid.SetRow(nameLable,0);
                Grid.SetRow(yearLable, 1);
                Grid.SetRow(countryLable, 2);
                Grid.SetRow(genreLable, 3);
                Grid.SetRow(directorLable, 4);
                Grid.SetRow(actorsLable, 5);
                Grid.SetRow(timesLable, 6);
                Grid.SetRow(aboutLable, 7);


                var nameLableСonclusion = new Label() { Content = item.FilmName, Background = backgraung, HorizontalAlignment = HorizontalAlignment.Left, Foreground = foregraung };
                var yearLableСonclusion = new Label() { Content = item.FilmYear, Background = backgraung, HorizontalAlignment = HorizontalAlignment.Left, Foreground = foregraung };
                var countryLableСonclusion = new Label() { Content = item.FilmCountry, Background = backgraung, HorizontalAlignment = HorizontalAlignment.Left, Foreground = foregraung };
                var genreLableСonclusion = new Label() { Content = item.FilmGenre, Background = backgraung, HorizontalAlignment = HorizontalAlignment.Left, Foreground = foregraung };
                var directorLableСonclusion = new Label() { Content = item.FilmDirector, Background = backgraung, HorizontalAlignment = HorizontalAlignment.Left, Foreground = foregraung };
                var actorsLableСonclusion = new Label() { Content = item.FilmActor, Background = backgraung, HorizontalAlignment = HorizontalAlignment.Left, Foreground = foregraung };
                var timesLableСonclusion = new Label() { Content = item.FilmTime, Background = backgraung, HorizontalAlignment = HorizontalAlignment.Left, Foreground = foregraung };
                var aboutLableСonclusion = new Label() { Content = item.FilmAbout, Background = backgraung, HorizontalAlignment = HorizontalAlignment.Left, Foreground = foregraung };


                grid.Children.Add(nameLableСonclusion);
                grid.Children.Add(yearLableСonclusion);
                grid.Children.Add(countryLableСonclusion);
                grid.Children.Add(genreLableСonclusion);
                grid.Children.Add(directorLableСonclusion);
                grid.Children.Add(actorsLableСonclusion);
                grid.Children.Add(timesLableСonclusion);
                grid.Children.Add(aboutLableСonclusion);

                Grid.SetRow(nameLableСonclusion, 0);
                Grid.SetColumn(nameLableСonclusion, 1);

                Grid.SetRow(yearLableСonclusion, 1);
                Grid.SetColumn(yearLableСonclusion, 1);

                Grid.SetRow(countryLableСonclusion, 2);
                Grid.SetColumn(countryLableСonclusion, 1);

                Grid.SetRow(genreLableСonclusion, 3);
                Grid.SetColumn(genreLableСonclusion, 1);

                Grid.SetRow(directorLableСonclusion, 4);
                Grid.SetColumn(directorLableСonclusion, 1);

                Grid.SetRow(actorsLableСonclusion, 5);
                Grid.SetColumn(actorsLableСonclusion, 1);

                Grid.SetRow(timesLableСonclusion, 6);
                Grid.SetColumn(timesLableСonclusion, 1);

                Grid.SetRow(aboutLableСonclusion, 7);
                Grid.SetColumn(aboutLableСonclusion, 1);

                mainFilmGrid.Children.Add(grid);
            }
        }
    }
}
