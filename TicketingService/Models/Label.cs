using System.ComponentModel.DataAnnotations.Schema;

namespace TicketingService.Models
{
    [Table("labels")]
    public class Label
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("created")]
        public DateTime created { get; set; }

        [Column("updated")]
        public DateTime updated { get; set; }
    }
}
