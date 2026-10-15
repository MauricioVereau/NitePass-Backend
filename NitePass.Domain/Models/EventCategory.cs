using System.ComponentModel.DataAnnotations.Schema;

namespace NitePass.Domain.Models
{
    public class EventCategory
    {
        [Column("Id")]
        public short Id { get; set; }
        [Column("TipoEvento")]
        public string TipoEvento { get; set; } = string.Empty;
    }
}
