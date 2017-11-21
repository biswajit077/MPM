using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ManPowerManagement.Models
{
    [Table("Uers")]
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public int RoleId { get; set; }
        private UserStatus Status { get; set; }
        [Column("Status")]
        public virtual string StatusString
        {
            get { return Status.ToString(); }
            set
            {
                UserStatus newValue;
                if (Enum.TryParse(value, out newValue))
                { Status = newValue; }
            }
        }
        [ForeignKey("RoleId")]
        public virtual Role Role { get; set; } 
    }
    [Table("Roles")]
    public class Role
    {
        [Key]
        public int Id { get; set; }
        public string RoleName { get; set; }
    }

    public enum UserStatus { Active = 'A', Inactive = 'I'}
}
