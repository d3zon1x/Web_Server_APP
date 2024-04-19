using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web_Server.Core.Entity
{
    public class CategoryEntity
    {
        [Key]
        public int Id { get; set; }
        [Required, StringLength(225)]
        public string Name { get; set; }
        [StringLength(4000)]
        public string Description { get; set; }
        [StringLength(225)]
        public string? ImagePath { get; set; }
    }
}
