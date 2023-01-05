using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyBlog.Entities.Concrete;
using UdemyBlog.Shared.Data.Abstract;

namespace UdemyBlog.Data.Abstract
{
    public interface IArticleRepository:IEntityRepository<Article>
    {
    }
}
