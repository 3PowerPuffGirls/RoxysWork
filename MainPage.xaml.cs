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
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;
using static Album;

namespace MyPhotoLibraryApp_practice_
{    public sealed partial class MainPage : Page
    {

        public MainPage()
        {
            this.InitializeComponent();
            MainFrame.Content = new UploadImages();
            BackItm.Visibility = Visibility.Collapsed;
        }
        public bool CanGoBack { get; }
        private void BackItm_Tapped(object sender, TappedRoutedEventArgs e)
        {
            MainFrame.Content = new UploadImages();
        }

        private void AlbumsItm_Tapped(object sender, TappedRoutedEventArgs e)
        {
            MainFrame.Content = new AlbumPage();
            BackItm.Visibility = Visibility.Visible;
        }

        private void EditItm_Tapped(object sender, TappedRoutedEventArgs e)
        {
            BackItm.Visibility = Visibility.Visible;

        }

        private void AlbumsNewFlyout_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AlbumsEditFlyout_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
