using AlbumsApp.Entities;

namespace AlbumsApp.Services
{
    public interface IAlbumManager
    {
        //AddAlbum, GetAllAlbums, GetAlbumsByGenre, GetRandomAlbum, and GetAllGenres
        public void AddAlbum(Album album);

        public ICollection<Album> GetAllAlbums();

        public ICollection<Album> GetAlbumsByGenre(string genre);

        public Album GetRandomAlbum();

        public ICollection<string> GetAllGenres();
    }
}
