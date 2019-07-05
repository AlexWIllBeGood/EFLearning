using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst20190705.Models
{
    public class Question
    {
        [Key]
        public int Id { get; set; }
        public string Head { get; set; }
        public string Content { get; set; }
        public DateTime CreateTime { get; set; }
        public int Status { get; set; }
        public ICollection<QuestionSelection> SelectionList { get; set; }
    }
    public class QuestionSelection
    {
        [Key]
        public int Id { get; set; }
        public int QuestionId { get; set; }
        public string Head { get; set; }
        public string Content { get; set; }
        public string Score { get; set; }
        public bool NeedAddInfo { get; set; }
        public string AdditionalInfo { get; set; }
        public int Status { get; set; }
    }
}
