using Microsoft.AspNetCore.Http.HttpResults;
using System.ComponentModel.DataAnnotations.Schema;

namespace TicketingService.Models
{
    [Table("users")]
    public class User
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("first_name")]
        public string firstName { get; set; }

        [Column("last_name")]
        public string lastName { get; set; }

        [Column("email")]
        public string email { get; set; }

        [Column("slack")]
        public string slack { get; set; }

        [Column("created")]
        public DateTime created { get; set; }

        [Column("updated")]
        public DateTime updated { get; set; }
    }
}