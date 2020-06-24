using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
        public void SaveCDToDB(CD entity)
        {
            var cdDBEntity = new Cd
            {
                AlbumName = entity.CD_album_name.CD_album_name,
                NumberSongs = entity.CD_album_name.number_songs,
                ArtistName = entity.CD_artist_name.CD_artist_name,
                Autograph = entity.CD_artist_name.autograph,
                LabelName = entity.CD_label_name,
                Price = entity.CD_price,
                CoverImage = entity.CD_image,
            };

            _dbContext.Add(cdDBEntity);
        }
        public bool saveChanges()
        {
            try{
                _dbContext.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
           
        }
        //public void foo()
        //{
        //    var entity = _dbContext.Cd.Where(x => x.Id == 1).Select(x=>new CD { })
        //}

    }
}

