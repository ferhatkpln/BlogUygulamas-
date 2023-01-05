using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyBlog.Entities.Concrete;
using UdemyBlog.Entities.Dtos;
using UdemyBlog.Shared.Utilities.Results.Abstract;

namespace UdemyBlog.Services.Abstract
{
    public interface IArticleService
    {
        Task<IDataResult<ArticleDto>> Get(int articleId);
        Task<IDataResult<ArticleListDto>> GetAll();       
        Task<IDataResult<ArticleListDto>> GetAllByNonDeleted();
        Task<IDataResult<ArticleListDto>> GetAllByNonDeletedAndActiveted();
        Task<IDataResult<ArticleListDto>> GetAllByCategory(int categoryId);
        Task<IResult> Add(ArticleAddDto articleAddDto, string createdByName);
        Task<IResult> Update(ArticleUpdateDto articleUpdateDto, string modifiedByName);
        Task<IResult> Delete(int articleId, string modifiedByName);
        Task<IResult> HardDelete(int articleId);
    }
}
