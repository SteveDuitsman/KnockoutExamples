using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public interface IAlbumRepository
    {
        IEnumerable<Album> All();
        IEnumerable<Album> Where(Predicate<Album> filter);
        Album FirstOrDefault(Predicate<Album> filter);
    }

    public class AlbumRepository : RepositoryBase<Album>, IAlbumRepository
    {
        public AlbumRepository()
        {
            data = new List<Album> { 
                new Album {
                    Id = 1, 
                    ArtistId = 1,
                    GenreId = 1
                },
                new Album {
                    Id = 2, 
                    ArtistId = 2,
                    GenreId = 2
                }
            };
        }
    }

    public interface IGenreRepository
    {
        IEnumerable<Genre> All();
        IEnumerable<Genre> Where(Predicate<Genre> filter);
        Genre FirstOrDefault(Predicate<Genre> filter);
    }

    public class GenreRepository : RepositoryBase<Genre>, IGenreRepository
    {
        public GenreRepository()
        {
            data = new List<Genre> { 
                new Genre {
                    Id = 1, 
                    Name = "Alternative Rock"
                },
                new Genre {
                    Id = 2, 
                    Name = "Jazz"
                }
            };
        }
    }
}
