using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;
using Windows.Storage.FileProperties;
using Windows.Storage.Streams;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;

namespace MyPhotoLibraryApp_practice_.Model
{

    public class PhotoManager
    {
        private static bool initialised = false;
        public static List<Photo> PhotoCollection = new List<Photo>();
        public static List<Photo> selectedPhotos;
        public ImageSource PhotoThumbnail;


        public static async Task GetAllPhotos(ObservableCollection<Photo> photos)
        {
            photos.Clear();
            if (!initialised)
            {

                StorageFolder picturesFolder = KnownFolders.PicturesLibrary;
                IReadOnlyList<StorageFile> fileList = await picturesFolder.GetFilesAsync();

                foreach (StorageFile file in fileList)
                {
                    Photo newphoto = new Photo { PhotoFile = file.Path };

                    IRandomAccessStream fileStream = await file.OpenAsync(FileAccessMode.Read);
                    BitmapImage bitmapImage = new BitmapImage();
                    bitmapImage.SetSource(fileStream);

                    newphoto.image = bitmapImage;
                    


                    var thumbnail = await file.GetThumbnailAsync(ThumbnailMode.SingleItem);

                    BitmapImage thumbnailimage = new BitmapImage();
                    await thumbnailimage.SetSourceAsync(thumbnail);
                    newphoto.PhotoThumbnail = thumbnailimage;
                    newphoto.storagefile = file;
                    PhotoCollection.Add(newphoto);
                   
                }
                initialised = true;
            }
            PhotoCollection.ForEach(elem => photos.Add(elem));
            return;
        }
        public static void GetSelectedPhotos(ObservableCollection<Photo> selphotos)
        {
            selphotos.Clear();
            if (selectedPhotos != null)
            {
                selectedPhotos.ForEach(photo => selphotos.Add(photo));
            }
        }
    }
}
