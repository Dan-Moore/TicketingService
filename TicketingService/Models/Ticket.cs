using System.ComponentModel.DataAnnotations.Schema;

namespace TicketingService.Models
{
    [Table("tickets")]
    public class Ticket
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("created")]
        public DateTime Created { get; set; }

        [Column("updated")]
        public DateTime Updated { get; set; }

        [Column("summary")]
        public String? Summary { get; set; }

        [Column("component")]
        public String? Component { get; set; }

        [Column("version")]
        public String? Version { get; set; }

        [Column("milestone")]
        public String? Milestone { get; set; }

        [Column("description")]
        public String? Description { get; set; }

        [Column("type")]
        public String? Type { get; set; }

        [Column("severity")]
        public String? severity { get; set; }

        [Column("status")]
        public String? Status { get; set; }

        [Column("owner_id")]
        public int Owner_id { get; set; }

        [Column("comments")]
        public ICollection<Comments>? Comments { get; set; }
    }
}
