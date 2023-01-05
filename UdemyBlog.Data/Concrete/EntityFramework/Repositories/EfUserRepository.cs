using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyBlog.Data.Abstract;
using UdemyBlog.Entities.Concrete;
using UdemyBlog.Shared.Data.Concrete.EntityFramework;

namespace UdemyBlog.Data.Concrete.EntityFramework.Repositories
{
    public class EfUserRepository : EfEntityRepositoryBase<User>, IUserRepository
    {
        public EfUserRepository(DbContext dbContext) : base(dbContext)
        {
        }
    }
}
