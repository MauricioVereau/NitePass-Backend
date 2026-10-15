using System.ComponentModel.DataAnnotations.Schema;

namespace NitePass.Domain.Models
{
    public class City
    {
        [Column("Id")]
        public short Id { get; set; }
        [Column("Ciudad")]
        public string Ciudad { get; set; } = string.Empty;
    }
}
