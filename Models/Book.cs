using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DorsetBookApi.Models
{
    [Table("book")]
    public class Book
    {
        [Key]
        public int id { get; set; }
        public decimal price { get; set; }
        public string isbn { get; set; }
    }
}