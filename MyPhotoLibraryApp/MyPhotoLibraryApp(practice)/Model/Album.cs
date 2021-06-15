using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPhotoLibraryApp_practice_.Model
{
    public enum AlbumCategories
    {
        Animals,
        People,
        Scenery,
        Misc,
    }
    class Album
    {
        public string AlbumName { get; set; }
        public string AlbumCoverImage { get; set; }
        public AlbumCategories AlbumCategory { get; set; }
        public Album(string name, AlbumCategories category)
        {
            AlbumName = name;
            AlbumCategory = category;
        }
    }
}
