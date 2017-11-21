using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ManPowerManagement.Models
{
    [Table("SoldierOfficalInfos")]
    public class SoldierOfficialInfo
    {
        [Key]
        public int Id { get; set; }
        public int SPID { get; set; }
        public string SNO { get; set; }
        public string SPICODE { get; set; }
        public int TradeId { get; set; }
        public int RankId { get; set; }
        public string UnitName { get; set; }
        public string SubUnitName { get; set; }
        public string LastServedUnitName { get; set; }
        public DateTime JoiningDateOfUnit { get; set; }
        public DateTime JoiningDateOfArmy { get; set; }
        public DateTime RetirementDate { get; set; }
        public string MedicalCategory { get; set; }
        [ForeignKey("TradeId")]
        public virtual Trade Trade { get; set; }
        [ForeignKey("RankId")]
        public virtual Rank Rank { get; set; }
        [ForeignKey("SPID")]
        public virtual SoldierPersonalInfo SoldierPersonalInfo { get; set; }
    }
}
