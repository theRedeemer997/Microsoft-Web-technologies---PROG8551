﻿using AlbumsApp.Entities;

namespace AlbumsApp.Models
{
    public class AlbumViewModel
    {
        public ICollection<string>? Genres  { get; set; }

        public string? activeGenre { get; set; }

        public ICollection<Album>? Albums { get; set; }

        
        public Album? RandomAlbum { get; set; }

    }
}
