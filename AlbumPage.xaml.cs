using MyPhotoLibraryApp_practice_.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;


namespace MyPhotoLibraryApp_practice_
{
    public sealed partial class AlbumPage : Page
    {

        private ObservableCollection<Photo> Photos;
        public List<Album> AlbumCover;

        public AlbumPage()
        {
            this.InitializeComponent();

            AlbumCover = new List<Album>
            {
                new Album
                {
                    AlbumName = PhotoCategory.Animals,
                    AlbumIcon = "/Assets/PhotoApp/Animals/Icon.png"
                },
                new Album
                {
                    AlbumName = PhotoCategory.Food,
                    AlbumIcon = "/Assets/PhotoApp/Food/Icon.png"
                },
                new Album
                {
                    AlbumName = PhotoCategory.People,
                    AlbumIcon = "/Assets/PhotoApp/People/Icon.png"
                },
                new Album
                {
                    AlbumName = PhotoCategory.Scenery,
                    AlbumIcon = "/Assets/PhotoApp/Scenery/Icon.png"
                }
            };
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }

        MainPage MainPage = new MainPage();
        List<Album> album = new List<Album>();

        private void AlbumsListView_ItemClick(object sender, ItemClickEventArgs e)
        {

        }
    }
}
