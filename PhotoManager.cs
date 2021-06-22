using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPhotoLibraryApp_practice_.Model
{
    public enum PhotoCategory
    {
        Animals,
        People,
        Scenery,
        Food,
        New,
    }
    public class Photo
    {
        public string PhotoName { get; set; }
        public string PhotoFile { get; set; }
        public PhotoCategory Category { get; set; }
        public string PhotoThumbnail { get; set; }
        public string PhotoAlbum { get; set; }

        public Photo(string name, PhotoCategory category)
        {
            Category = category;
            PhotoName = name;
            PhotoFile = $"/Assets/PhotoApp/{Category}/{name}.jpg";
            PhotoAlbum = $"/Assets/PhotoApp/{Category}/Icon.jpg";
            PhotoThumbnail = $"C:/Users/mrsro/source/repos/MyPhotoLibraryApp/MyPhotoLibraryApp(practice)/Assets/PhotoApp/{Category}/Icon.jpg";
        }



    }
    public class PhotoManager
    {


        public static void GetAllPhotos(ObservableCollection<Photo> photos)
        {
            var allphotos = GetPhotos();
            photos.Clear();
            allphotos.ForEach(photo => photos.Add(photo));
        }
         public static void GetPhotosByCategory(ObservableCollection<Photo> photos, PhotoCategory category)
        {
            var allPhotos = GetPhotos();
            var filteredPhotos = allPhotos.Where(photo => photo.Category == category).ToList();
            photos.Clear();
            filteredPhotos.ForEach(photo => photos.Add(photo));
        }
         public static List<Photo> GetPhotos()
        {
            var photos = new List<Photo>();
            photos.Add(new Photo("Ant", PhotoCategory.Animals));
            photos.Add(new Photo("Dog", PhotoCategory.Animals));
            photos.Add(new Photo("Fish", PhotoCategory.Animals));
            photos.Add(new Photo("Snake", PhotoCategory.Animals));
            photos.Add(new Photo("Worm", PhotoCategory.Animals));
            photos.Add(new Photo("Canned", PhotoCategory.Food));
            photos.Add(new Photo("Fastfood", PhotoCategory.Food));
            photos.Add(new Photo("Healthy", PhotoCategory.Food));
            photos.Add(new Photo("Spices", PhotoCategory.Food));
            photos.Add(new Photo("Thai", PhotoCategory.Food));
            photos.Add(new Photo("Hands", PhotoCategory.People));
            photos.Add(new Photo("Hikers", PhotoCategory.People));
            photos.Add(new Photo("Picnic", PhotoCategory.People));
            photos.Add(new Photo("Standing", PhotoCategory.People));
            photos.Add(new Photo("WorkGroup", PhotoCategory.People));
            photos.Add(new Photo("Clouds", PhotoCategory.Scenery));
            photos.Add(new Photo("Dock", PhotoCategory.Scenery));
            photos.Add(new Photo("Field", PhotoCategory.Scenery));
            photos.Add(new Photo("Mountain", PhotoCategory.Scenery));
            photos.Add(new Photo("Ocean", PhotoCategory.Scenery));
            
            return photos;
        }
    }
}
