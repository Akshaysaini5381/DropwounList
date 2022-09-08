using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace DropwounList.Models
{
    public class Class1
    {
        [Required]
        public int id { get; set; }
        [Required]
        public string name { get; set; }
        [Required]
        public Nullable<int> roll { get; set; }
        [Required]
        public string city { get; set; }
    }
}