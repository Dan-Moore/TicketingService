using System.ComponentModel.DataAnnotations.Schema;

namespace TicketingService.Models
{
    [Table("ticket_comments")]
    public class Comments
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("created")]
        public DateTime Created { get; set; }

        [Column("updated")]
        public DateTime Updated { get; set; }

        [Column("ticket_id")]
        public int Ticket_id { get; set; }

        [Column("owner_id")]
        public int Owner_id { get; set; }

        public Ticket? Ticket { get; set; }
    }
}
