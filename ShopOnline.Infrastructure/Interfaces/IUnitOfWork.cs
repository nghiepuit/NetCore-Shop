using System;

namespace ShopOnline.Infrastructure.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        /// <summary>
        /// Call save change in DbContext : Đảm bảo transaction
        /// </summary>
        void Commit();
    }
}