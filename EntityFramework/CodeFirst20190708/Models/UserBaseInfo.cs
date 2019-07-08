using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst20190708.Models
{
    public class UserBaseInfo
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Status { get; set; }
    }
}
