using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MusicStoreSPA.Services
{
    public interface IMusicLibraryService
    {
        IEnumerable<Artist> GetArtists();
        IEnumerable<Album> GetAlbums();
        IEnumerable<Album> GetAlbums(int artistId);
        Song GetSong(int songId);
        IEnumerable<Song> GetSongs(int albumId);
        IEnumerable<Genre> GetGenres();
    }

    public class MusicLibraryService : IMusicLibraryService
    {
        protected IArtistRepository Artists;
        protected IAlbumRepository Albums;
        protected ISongRepository Songs;
        protected IGenreRepository Genres;

        public MusicLibraryService(IArtistRepository artists, IAlbumRepository albums, ISongRepository songs, IGenreRepository genres)
        {
            Artists = artists;
            Albums = albums;
            Songs = songs;
            Genres = genres;
        }

        public IEnumerable<Artist> GetArtists()
        {
            return Artists.All();
        }

        public IEnumerable<Album> GetAlbums()
        {
            return Albums.All();
        }

        public IEnumerable<Album> GetAlbums(int artistId)
        {
            return Albums.Where(a => a.ArtistId == artistId);
        }

        public Song GetSong(int songId)
        {
            return Songs.FirstOrDefault(s => s.Id == songId);
        }

        public IEnumerable<Song> GetSongs(int albumId)
        {
            return Songs.Where(s => s.AlbumId == albumId);
        }

        public IEnumerable<Genre> GetGenres()
        {
            return Genres.All();
        }
    }
}