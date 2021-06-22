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
        private ObservableCollection<Photo> Photos;
        


        public MainPage()
        {
            this.InitializeComponent();
            Photos = new ObservableCollection<Photo>();
            PhotoManager.GetAllPhotos(Photos);
            AllImagesButton.Visibility = Visibility.Collapsed;

            
        }

   
        private void AllImagesButton_Click(object sender, RoutedEventArgs e)
        {
            PhotoManager.GetAllPhotos(Photos);
            AllImagesButton.Visibility = Visibility.Collapsed;
            TitleTextBlock.Text = "All Images";

        }

        private void AnimalsButton_Click(object sender, RoutedEventArgs e)
        {
            PhotoManager.GetPhotosByCategory(Photos, PhotoCategory.Animals);
            AllImagesButton.Visibility = Visibility;
            TitleTextBlock.Text = "Animals";
        }

        private void FoodButton_Click(object sender, RoutedEventArgs e)
        {
            PhotoManager.GetPhotosByCategory(Photos, PhotoCategory.Food);
            AllImagesButton.Visibility = Visibility;
            TitleTextBlock.Text = "Food";

        }

        private void PeopleButton_Click(object sender, RoutedEventArgs e)
        {
            PhotoManager.GetPhotosByCategory(Photos, PhotoCategory.People);
            AllImagesButton.Visibility = Visibility;
            TitleTextBlock.Text = "People";

        }

        private void ImageGridView_ItemClick(object sender, ItemClickEventArgs e)
        {
            //var photo = (Photo)e.ClickedItem;

        }

        private void SceneryButton_Click(object sender, RoutedEventArgs e)
        {
            PhotoManager.GetPhotosByCategory(Photos, PhotoCategory.Scenery);
            AllImagesButton.Visibility = Visibility;
            TitleTextBlock.Text = "Scenery";

        }

        private void AlbumsButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(AlbumPage));
        }

        private void PlusButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(UploadImages));
        }

        private void NewAlbumButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
