using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyBlog.Data.Abstract
{
    public interface IUnitOfWork : IAsyncDisposable
    {
        IArticleRepository Articles { get; } //unitofwork.Articles
        ICategoryRepository Categories { get; }
        ICommentRepository Comments { get; }
        IRoleRepository Roles { get; }
        IUserRepository User { get; } // _unitofwork.Categories.AddAsync();

        // _unitofwork.Categories.AddAsync();
        // _unitofwork.Users.AddAsync();
        // _unitofwork.SaveAsync();
        Task<int> SaveAsync();

    }
}
