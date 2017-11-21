using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ManPowerManagement.Models
{
    [Table("SolderPersonalInfos")]
    public class SoldierPersonalInfo
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public int GenderId { get; set; }
        public DateTime DoB { get; set; }
        public int BloodGroupId { get; set; }
        public string PresentAddress { get; set; }
        public string PermanentAddress { get; set; }
        public string ContactNumber { get; set; }
        public string EmailAddress { get; set; }
        public Byte SoldierImage { get; set; }
        public int DistrictId { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public string SpouseName { get; set; }
        public string FatherContactNumber { get; set; }
        public string MotherContactNumber { get; set; }
        public string SpouseContactNumber { get; set; }
        public int MaritalStatus { get; set; }
        public int HaveChildren { get; set; }
        public int NoOfSon { get; set; }
        public int NoOfDaughter { get; set; }
    }

    public enum Gender
    {
        Male = 1,
        Female
    }

    public enum EnumBloodGroup
    {
        [Description("A+")]
        APos,
        [Description("A-")]
        ANeg,
        [Description("B+")]
        BPos,
        [Description("B-")]
        BNeg,
        [Description("O+")]
        OPos,
        [Description("O-")]
        ONeg,
        [Description("AB+")]
        ABPos,
        [Description("AB-")]
        ABNeg,
    }
}
