﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyBlog.Entities.Dtos
{
    public class CategoryUpdateDto
    {
        [Required]
        public int Id { get; set; }


        [DisplayName("Kategori Adı")]
        [Required(ErrorMessage = "{0} Boş Geçilmemelidir.")]
        [MaxLength(70, ErrorMessage = "{0} {1} Karakterden Büyük Olmamalıdır.")]
        [MinLength(3, ErrorMessage = "{0}{1} Karakterden Az Olmamalıdır.")]
        public string Name { get; set; }


        [DisplayName("Kategori Açıklaması")]
        [MaxLength(500, ErrorMessage = "{0} {1} Karakterden Büyük Olmamalıdır.")]
        [MinLength(3, ErrorMessage = "{0}{1} Karakterden Az Olmamalıdır.")]
        public string Description { get; set; }


        [DisplayName("Kategori Özel Not Alanı")]
        [MaxLength(500, ErrorMessage = "{0} {1} Karakterden Büyük Olmamalıdır.")]
        [MinLength(3, ErrorMessage = "{0}{1} Karakterden Az Olmamalıdır.")]
        public string Note { get; set; }


        [DisplayName("Kategori Durumu(P/A)")]
        [Required(ErrorMessage = "{0} Boş Geçilmemelidir.")]
        public bool IsActive { get; set; }


        [DisplayName("Kategori Durumu(Silindi Mi?)")]
        [Required(ErrorMessage = "{0} Boş Geçilmemelidir.")]
        public bool IsDeleted { get; set; }
    }
}
