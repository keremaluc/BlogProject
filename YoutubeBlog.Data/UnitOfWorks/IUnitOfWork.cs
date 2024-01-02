using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeBlog.Core.Entities;
using YoutubeBlog.Data.Repositories.Abstraction;

namespace YoutubeBlog.Data.UnitOfWorks
{
    public interface IUnitOfWork : IAsyncDisposable
    {
        IRepostitory<T> GetRepostitory<T>() where T : class, IEntityBase, new();
        Task<int> SaveAsync();
        int Save();
        object GetRepository<T>();
    }
}
