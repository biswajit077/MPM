using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ManPowerManagement.Models
{
    [Table("Trades")]
    public class Trade
    {
        [Key]
        public int Id { get; set; }
        public string TradeCode { get; set; }
        public string TradeName { get; set; }
    }
}
