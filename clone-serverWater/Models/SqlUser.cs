using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace clone_serverWater.Models
{
    [Table("User")]
    public class SqlUser
    {
        [Key]
        public long Id { get; set; }

        public string user { get;set; }
        public string username { get; set; }
        public string password { get; set; }
    }
}
