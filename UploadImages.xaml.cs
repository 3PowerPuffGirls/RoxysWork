using MyPhotoLibraryApp_practice_.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.Storage.Pickers;
using Windows.Storage.Streams;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;


namespace MyPhotoLibraryApp_practice_
{

    public sealed partial class UploadImages : Page
    {
        public ObservableCollection<Photo> photos { get; set; }
        public UploadImages()
        {
            this.InitializeComponent();
            photos = new ObservableCollection<Photo>();
            this.Loaded += UploadImages_Loaded;

        }

        private async void UploadImages_Loaded(object sender, RoutedEventArgs e)
        {
            await PhotoManager.GetAllPhotos(photos);
        }
    }

}
