using System.Data.Entity;
using System.Linq;

namespace WebApplication1.Db
{
    public interface IDataModel
    {
        DbSet<Book> Books { get; set; }
        DbSet<Blurb> Blurbs { get; set; }
        void Dispose();
    }
}