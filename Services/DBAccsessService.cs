using System;
using System.Linq;
using MusicStore.DBModels;
using MusicStore.Models;

namespace MusicStore.Services
{
    public class DBAccsessService
    {
        private readonly MUSIC_STOREContext _dbContext;
        public DBAccsessService(MUSIC_STOREContext dbContext)
        {
            _dbContext = dbContext;
        }
        public bool SaveCDToDB(CD entity)
        {
            var existingCD = _dbContext.Cd.Any(x=>x.AlbumName.ToLower() == entity.CD_album_name.CD_album_name.ToLower());
            var cdDBEntity = new Cd
            {
                AlbumName = entity.CD_album_name.CD_album_name,
                NumberSongs = entity.CD_album_name.number_songs,
                ArtistName = entity.CD_artist_name.CD_artist_name,
                Autograph = entity.CD_artist_name.autograph,
                LabelName = entity.CD_label_name,
                ReleaseDate = entity.CD_release_date,
                Price = entity.CD_price,
                CoverImage = entity.CD_image,
            };
            if (!existingCD)
            {
                _dbContext.Add(cdDBEntity);
            }

            return existingCD;
        }

        public bool SaveDVDToDB(DVD entity)
        {
            var existingDVD = _dbContext.Dvd.Any(x => x.AlbumName.ToLower() == entity.DVD_album_name.DVD_albumName.ToLower());
            var dvdDBEntity = new Dvd
            {
                AlbumName = entity.DVD_album_name.DVD_albumName,
                NumberSongs = entity.DVD_album_name.number_songs,
                ArtistName = entity.DVD_artist_name.DVD_artist_name,
                Autograph = entity.DVD_artist_name.autograph,
                LabelName = entity.DVD_label_name,
                Price = entity.DVD_price,
                CoverImage = entity.DVD_image,
                ReleaseDate = entity.DVD_release_date,
            };

            if (!existingDVD)
            {
                _dbContext.Add(dvdDBEntity);
            }

            return existingDVD;
        }

        public bool SaveVinylToDB(VinylModel entity)
        {
            var existingVinyl = _dbContext.Vinyl.Any(x => x.AlbumName.ToLower() == entity.Vinyl_album_name.Vinyl_album_name.ToLower());
            var vinylDBEntity = new Vinyl
            {
                AlbumName = entity.Vinyl_album_name.Vinyl_album_name,
                NumberSongs = entity.Vinyl_album_name.number_songs,
                ArtistName = entity.Vinyl_artist_name.Vinyl_artist_name,
                Autograph = entity.Vinyl_artist_name.autograph,
                LabelName = entity.Vinyl_label_name,
                Price = entity.Vinyl_price,
                CoverImage = entity.Vinyl_image,
                ReleaseDate = entity.Vinyl_release_date,
            };
            if (!existingVinyl)
            {
                _dbContext.Add(vinylDBEntity);
            }

            return existingVinyl;
        }

        public bool SaveDeluxeToDB(Deluxe entity)
        {
            var existingDeluxe = _dbContext.DeluxeEdition.Any(x => x.AlbumName.ToLower() == entity.Deluxe_album_name.Deluxe_album_name.ToLower());
            var deluxeDBEntity = new DeluxeEdition
            {
                AlbumName = entity.Deluxe_album_name.Deluxe_album_name,
                NumberSongs = entity.Deluxe_album_name.number_songs,
                ArtistName = entity.Deluxe_artist_name.Deluxe_artist_name,
                Autograph = entity.Deluxe_artist_name.autograph,
                LabelName = entity.Deluxe_label_name,
                Price = entity.Deluxe_price,
                CoverImage = entity.Deluxe_image,
                ReleaseDate = entity.Deluxe_release_date,
            };

            if (!existingDeluxe)
            {
                _dbContext.Add(deluxeDBEntity);
            }

            return existingDeluxe;
        }

        public bool SaveTShirtToDB(T_Shirt entity)
        {
            var existingTShirt = _dbContext.TShirt.Any(x => x.TShirtImage.ToLower() == entity.T_shirt_image.ToLower());
            var tshirtDBEntity = new TShirt
            {
                ArtistName = entity.TShirt_ArtistName.T_shirt_artist_name,
                Color = entity.TShirt_ArtistName.color,
                Size = entity.TShirt_ArtistName.size,
                Price = entity.T_shirt_price,
                TShirtImage = entity.T_shirt_image,
            };

            if (!existingTShirt)
            {
                _dbContext.Add(tshirtDBEntity);
            }

            return existingTShirt;
        }

        public bool SaveChanges()
        {
            try{
                _dbContext.SaveChanges();
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
           
        }
    }
}

