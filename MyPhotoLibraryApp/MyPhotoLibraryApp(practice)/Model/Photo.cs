using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPhotoLibraryApp_practice_
{
    public enum PhotoCategory
    {
        Animals,
        People,
        Scenery,
        Misc,
    }
    class Photo
    {
        public string PhotoName { get; set; }
        public int PhotoSize { get; set; }
        public string PhotoFile { get; set; }
        public PhotoCategory Category { get; set; }

        public Photo(string name, PhotoCategory category)
        {
            PhotoName = name;
            Category = category;
        }
        public void GetUserPhoto(string name, string file)
        {
            PhotoFile = file;
            PhotoName = name;
        }
    }
}
