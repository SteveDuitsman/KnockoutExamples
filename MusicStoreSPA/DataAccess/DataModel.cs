using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class Song
    {
        public int Id { get; set; }
        public int AlbumId { get; set; }
        public string Title { get; set; }
    }

    public class Album
    {
        public int Id { get; set; }
        public int ArtistId { get; set; }
        public int GenreId { get; set; }

        public string CoverArtUrl { get; set; }

        public string Title { get; set; }
        public double Cost { get; set; }

        public IEnumerable<Song> Songs { get; set; }
    }

    public class Artist
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Notes { get; set; }
        public IEnumerable<Album> Albums { get; set; }
    }

    public class Genre
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
