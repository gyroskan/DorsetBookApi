using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DorsetBookApi.Models
{
    [Table("book_description")]
    public class Book_description
    {
        [Key]
        public int id { get; set; }
        public int book_id { get; set; }
        public string book_name { get; set; }
        public string book_description { get; set; }
    }
}
