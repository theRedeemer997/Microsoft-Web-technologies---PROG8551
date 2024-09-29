using AlbumsApp.Entities;

namespace AlbumsApp.Services
{
    public class AlbumManager:IAlbumManager
    {
        private List<string> _allGenres = new List<string>();
        private List<Album> _albums = new List<Album>();

        public AlbumManager() {

            //add the in memory collection in the database

            // Seed data, first genres:
            _allGenres.Add("Rock");
            _allGenres.Add("Folk");
            _allGenres.Add("Classical");
            _allGenres.Add("Country");
            _allGenres.Add("Hip hop");

            // And then some albums:
            _albums.Add(new Album() { Artist = "The Beatles", Title = "The White Album", Year = 1967, Genre = "Rock", ImagePath = "/images/white-album.jpg" });
            _albums.Add(new Album() { Artist = "The Beatles", Title = "Let It Be", Year = 1970, Genre = "Rock", ImagePath = "/images/let-it-be.jpg" });
            _albums.Add(new Album() { Artist = "The Rolling Stones", Title = "Let It Bleed", Year = 1969, Genre = "Rock", ImagePath = "/images/let-it-bleed.jpg" });
            _albums.Add(new Album() { Artist = "The Clash", Title = "London Calling", Year = 1979, Genre = "Rock", ImagePath = "/images/london-calling.jpg" });
            _albums.Add(new Album() { Artist = "Bob Dylan", Title = "Bringing It All Back Home", Year = 1965, Genre = "Folk", ImagePath = "/images/bringing-it-all-back-home.jpg" });
            _albums.Add(new Album() { Artist = "Glenn Gould", Title = "J. S. Bach: The Goldberg Variations", Year = 1955, Genre = "Classical", ImagePath = "/images/goldberg-variations.jpg" });
            _albums.Add(new Album() { Artist = "Johnny Cash", Title = "At Folsum Prison", Year = 1968, Genre = "Country", ImagePath = "/images/folsom-prison.jpg" });
        }

        public void AddAlbum(Album album)
        {
            _albums.Add(album);
        }

        public ICollection<Album> GetAlbumsByGenre(string genre)
        {
            //throw new NotImplementedException();
            return _albums.Where(a=>a.Genre == genre).ToList();
        }

        public ICollection<Album> GetAllAlbums()
        {
            return _albums.AsReadOnly(); 
        }

        public ICollection<string> GetAllGenres()
        {
            return _allGenres;
        }

        public Album GetRandomAlbum()
        {
            //throw new NotImplementedException();
            Random random = new Random();
            return _albums[random.Next(0, _albums.Count)];
        }
    }
}
