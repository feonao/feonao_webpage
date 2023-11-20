using Microsoft.EntityFrameworkCore;

namespace feonao.Classes
{
    public class DataContext : DbContext
    {
        #region Contructor
        public DataContext(DbContextOptions<DataContext> options)
                : base(options)
        {

        }
        #endregion

        #region Public properties
        public DbSet<Sound> Sound { get; set; }
        public DbSet<Video> Video { get; set; }
        #endregion

        #region Overidden methods
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Sound>().HasData(GetSounds());
        //    base.OnModelCreating(modelBuilder);
        //}
        #endregion


        #region Private methods

        #endregion
    }
}
