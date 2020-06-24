using System;
using System.Collections.Generic;

namespace MusicStore.DBModels
{
    public partial class Dvd
    {
        public int Id { get; set; }
        public string AlbumName { get; set; }
        public int? NumberSongs { get; set; }
        public string ArtistName { get; set; }
        public bool? Autograph { get; set; }
        public string LabelName { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public double Price { get; set; }
        public string CoverImage { get; set; }
    }
}
