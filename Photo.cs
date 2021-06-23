using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;

namespace MyPhotoLibraryApp_practice_.Model
{
    public class Photo
    {
        public string PhotoName { get; set; }
        public string PhotoFile { get; set; }
        public ImageSource PhotoThumbnail { get; set; }
        public ImageSource image { get; set; }
        public StorageFile storagefile { get; set; }

        public BitmapImage thumbnailbitmap { get; set; }

    }

}
