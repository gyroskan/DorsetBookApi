using System.ComponentModel.DataAnnotations;

namespace DorsetBookApi.Models
{
    public class User
    {
        [Key]
        public int id { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string username { get; set; }
        public string passwordhash { get; set; }
    }
}