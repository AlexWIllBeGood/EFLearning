using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirst20190906.Models
{
    public class ArrangeCourse
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int Id { get; set; }
        public string Name { get; set; }
        public int StudentId { get; set; }
        public int TeacherId { get; set; }

        //public virtual Student student { get; set; }
        //public virtual Teacher teacher { get; set; }
    }
}
