using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ManPowerManagement.Models
{
    [Table("Districts")]
    public class District
    {
        [Key]
        public int Id { get; set; }
        public string DistrictCode { get; set; }
        public string DistrictName { get; set; }
    }
}
