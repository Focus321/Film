using Microsoft.Win32;
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
    /// Interaction logic for AddFilmPage.xaml
    /// </summary>
    public partial class AddFilmPage : Page
    {
        private readonly FilmContext _context;
        public AddFilmPage()
        {
            _context = new FilmContext();
            InitializeComponent();
        }
        string imagePath;

        private async void Button_Click_Next(object sender, RoutedEventArgs e)
        {
            var movie = _context.Movies.Add(new Movie() { FilmName = namefilmtext.Text, FilmYear = yearfilmtext.Text, FilmCountry = countryfilmtext.Text, FilmGenre = genrefilmtext.Text, FilmDirector = directorfilmtext.Text, FilmActor = actorfilmtext.Text, FilmTime = timefilmtext.Text, FilmAbout = aboutfilmtext.Text });
            await _context.SaveChangesAsync();
            NavigationService.Navigate(new Uri("Pages/ViewPage.xaml", UriKind.Relative));
        }

        private void Button_Click_Back(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("Pages/ViewPage.xaml", UriKind.Relative));
        }

        private void Button_Click_AddImage(object sender, RoutedEventArgs e)
        {
            User user = new User();
            OpenFileDialog fileDialog = new OpenFileDialog();
            if (fileDialog.ShowDialog() == true)
            {
                var path = fileDialog.FileName;
                imagePath = path;
            }

        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            var muvie = new Movie();
            muvie.FilmAbout = aboutfilmtext.Text;
            muvie.FilmActor = actorfilmtext.Text;
            muvie.FilmCountry = countryfilmtext.Text;
            muvie.FilmDirector = directorfilmtext.Text;
            muvie.FilmGenre = genrefilmtext.Text;
            muvie.FilmImage = imagePath;
            muvie.FilmPath = pathfilmtext.Text;
            muvie.FilmTime = timefilmtext.Text;
            muvie.FilmYear = yearfilmtext.Text;

            _context.Movies.Add(muvie);
            _context.SaveChanges();
        }
    }
}
