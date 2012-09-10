using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MusicStoreSPA.Models
{
    public class SongModel
    {
        public int Id { get; set; }
        public int AlbumId { get; set; }
        public string Title { get; set; }
    }

    public class AlbumModel
    {
        public int Id { get; set; }
        public int ArtistId { get; set; }
        public int GenreId { get; set; }

        public string CoverArtUrl { get; set; }

        public string Title { get; set; }
        public double Cost { get; set; }

        public IEnumerable<SongModel> Songs { get; set; }
    }

    public class ArtistModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Notes { get; set; }
        public IEnumerable<AlbumModel> Albums { get; set; }
    }

    public class GenreModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
