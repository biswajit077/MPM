using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ManPowerManagement.Models
{
    [Table("Ranks")]
    public class Rank
    {
        [Key]
        public int Id { get; set; }
        public string RankCode { get; set; }
        public string RankName { get; set; }
    }
}
