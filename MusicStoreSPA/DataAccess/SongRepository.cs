using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public interface ISongRepository
    {
        IQueryable<Song> Where(Predicate<Song> filter);
        Song FirstOrDefault(Predicate<Song> filter);
    }

    public class SongRepository : RepositoryBase<Song>, ISongRepository
    {
        public SongRepository()
        {
            data = new List<Song> { 
                new Song{
                    Id = 1,
                    Title = "Bridge Burning",
                    AlbumId = 1
                },
                new Song{
                    Id = 2,
                    Title = "Rope",
                    AlbumId = 1
                },
                new Song{
                    Id = 3,
                    Title = "Dear Rosemary",
                    AlbumId = 1
                },
                new Song{
                    Id = 4,
                    Title = "White Limo",
                    AlbumId = 1
                },
                new Song{
                    Id = 5,
                    Title = "Arlandria",
                    AlbumId = 1
                },
                new Song{
                    Id = 6,
                    Title = "These Days",
                    AlbumId = 1
                },
                new Song{
                    Id = 7,
                    Title = "Back & Forth",
                    AlbumId = 1
                },
                new Song{
                    Id = 8,
                    Title = "A Matter Of Time",
                    AlbumId = 1
                },
                new Song{
                    Id = 9,
                    Title = "Miss the Misery",
                    AlbumId = 1
                },
                new Song{
                    Id = 10,
                    Title = "I Should Have Known",
                    AlbumId = 1
                },
                new Song{
                    Id = 11,
                    Title = "Walk",
                    AlbumId = 1
                },
                new Song{
                    Id = 1,
                    Title = "So What",
                    AlbumId = 2
                },
                new Song{
                    Id = 2,
                    Title = "Freddie Freeloader",
                    AlbumId = 2
                },
                new Song{
                    Id = 3,
                    Title = "Blue In Green",
                    AlbumId = 2
                },
                new Song{
                    Id = 4,
                    Title = "All Blues",
                    AlbumId = 2
                },
                new Song{
                    Id = 5,
                    Title = "Flamenco Sketches",
                    AlbumId = 2
                }
            };
        }
    }
}
