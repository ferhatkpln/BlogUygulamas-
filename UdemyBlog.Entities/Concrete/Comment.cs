﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyBlog.Shared.Entities.Abstract;

namespace UdemyBlog.Entities.Concrete
{
    public class Comment:EntityBase,IEntity
    {
        public string? Text { get; set; }
        public int ArticleId { get; set; }
        public Article? Article { get; set; }

    }
}
