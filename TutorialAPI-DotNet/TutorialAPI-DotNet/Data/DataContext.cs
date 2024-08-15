using Microsoft.EntityFrameworkCore;
using TutorialAPI_DotNet.Entities;

namespace TutorialAPI_DotNet.Data
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }

        public DbSet<Student> Students { get; set; }
    }
}
