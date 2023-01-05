using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyBlog.Shared.Entities.Abstract;

namespace UdemyBlog.Entities.Concrete
{
    public class Role : EntityBase,IEntity
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public ICollection<User>? Users { get; set; }
    }
}
