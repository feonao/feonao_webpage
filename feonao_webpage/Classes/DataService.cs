using Microsoft.EntityFrameworkCore;

namespace feonao.Classes
{
    public class DataService
    {
        #region Private members
        private DataContext dbContext;
        #endregion

        #region Constructor
        public DataService(DataContext dbContext)
        {
            this.dbContext = dbContext;
        }
        #endregion

        #region Public methods
        /// <summary>
        /// This method returns the list of sound
        /// </summary>
        /// <returns></returns>
        public async Task<List<Sound>> GetSoundAsync()
        {
            return await dbContext.Sound.ToListAsync();
        }

        /// <summary>
        /// This method returns the list of video
        /// </summary>
        /// <returns></returns>
        public async Task<List<Video>> GetVideoAsync()
        {
            return await dbContext.Video.ToListAsync();
        }

        /// <summary>
        /// This method add a new sound to the DbContext and saves it
        /// </summary>
        /// <param name="sound"></param>
        /// <returns></returns>
        public async Task<Sound> AddSoundAsync(Sound sound)
        {
            try
            {
                dbContext.Sound.Add(sound);
                await dbContext.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }
            return sound;
        }

        /// <summary>
        /// This method add a new video to the DbContext and saves it
        /// </summary>
        /// <param name="video"></param>
        /// <returns></returns>
        public async Task<Video> AddVideoAsync(Video video)
        {
            try
            {
                dbContext.Video.Add(video);
                await dbContext.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }
            return video;
        }

        /// <summary>
        /// This method update and existing sound and saves the changes
        /// </summary>
        /// <param name="sound"></param>
        /// <returns></returns>
        public async Task<Sound> UpdateSoundAsync(Sound sound)
        {
            try
            {
                var soundExist = dbContext.Sound.FirstOrDefault(p => p.Id == sound.Id);
                if (soundExist != null)
                {
                    dbContext.Update(sound);
                    await dbContext.SaveChangesAsync();
                }
            }
            catch (Exception)
            {
                throw;
            }
            return sound;
        }

        /// <summary>
        /// This method update and existing video and saves the changes
        /// </summary>
        /// <param name="sound"></param>
        /// <returns></returns>
        public async Task<Video> UpdateVideoAsync(Video video)
        {
            try
            {
                var soundExist = dbContext.Video.FirstOrDefault(p => p.Id == video.Id);
                if (soundExist != null)
                {
                    dbContext.Update(video);
                    await dbContext.SaveChangesAsync();
                }
            }
            catch (Exception)
            {
                throw;
            }
            return video;
        }

        /// <summary>
        /// This method removes and existing sound from the DbContext and saves it
        /// </summary>
        /// <param name="sound"></param>
        /// <returns></returns>
        public async Task DeleteSoundAsync(Sound sound)
        {
            try
            {
                dbContext.Sound.Remove(sound);
                await dbContext.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// This method removes and existing video from the DbContext and saves it
        /// </summary>
        /// <param name="sound"></param>
        /// <returns></returns>
        public async Task DeleteVideoAsync(Video video)
        {
            try
            {
                dbContext.Video.Remove(video);
                await dbContext.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion
    }
}
