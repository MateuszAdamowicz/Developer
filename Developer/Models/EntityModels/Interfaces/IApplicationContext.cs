using System.Data.Entity;

namespace Developer.Models.EntityModels.Interfaces
{
    public interface IApplicationContext
    {
        IDbSet<Worker> Workers { get; set; }
        IDbSet<Flat> Flats { get; set; }
        IDbSet<House> Houses { get; set; }
        IDbSet<Land> Lands { get; set; }
        IDbSet<Photo> Photos { get; set; }
        IDbSet<Offer> Offers { get; set; }
        IDbSet<Mail> Mails { get; set; }
        new void SaveChanges();
    }
}