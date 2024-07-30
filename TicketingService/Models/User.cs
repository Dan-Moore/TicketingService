using System.ComponentModel.DataAnnotations.Schema;

namespace TicketingService.Models
{
    [Table("users")]
    public class User
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("firstname")]
        public string firstName { get; set; }

        [Column("lastname")]
        public string lastName { get; set; }

        [Column("email")]
        public string email { get; set; }

        [Column("slack")]
        public string slack { get; set; }
    }
}