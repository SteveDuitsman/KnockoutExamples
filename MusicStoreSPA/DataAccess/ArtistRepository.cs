using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public interface IArtistRepository
    {
        IEnumerable<Artist> All();
        IEnumerable<Artist> Where(Predicate<Artist> filter);
        Artist FirstOrDefault(Predicate<Artist> filter);
    }

    public class ArtistRepository : RepositoryBase<Artist>, IArtistRepository
    {
        public ArtistRepository()
        {
            data = new List<Artist> { 
                new Artist {
                    Id = 1, 
                    Name = "Foo Fighters",
                    Notes = "Dave Grohl, Taylor Hawkins, Nate Mendel, Chris Shiflett, Pat Smear"
                },
                new Artist {
                    Id = 2, 
                    Name = "Miles Davis",
                    Notes = ""
                }
            };
        }
    }
}
