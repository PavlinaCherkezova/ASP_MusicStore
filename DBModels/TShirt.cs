using System;
using System.Collections.Generic;

namespace MusicStore.DBModels
{
    public partial class TShirt
    {
        public int Id { get; set; }
        public string ArtistName { get; set; }
        public string Color { get; set; }
        public int Size { get; set; }
        public bool? Autograph { get; set; }
        public double Price { get; set; }
        public string TShirtImage { get; set; }
    }
}
