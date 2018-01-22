using ShopOnline.Infrastructure.Interfaces;

namespace ShopOnline.Data.EF
{
    public class EFUnitOfWork : IUnitOfWork
    {
        private readonly ShopOnlineDbContext _context;

        public EFUnitOfWork(ShopOnlineDbContext context)
        {
            _context = context;
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}