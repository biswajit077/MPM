namespace ManPowerManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedEntity : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Branches",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BranchCode = c.String(),
                        BranchName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Districts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DistrictCode = c.String(),
                        DistrictName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Ranks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RankCode = c.String(),
                        RankName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RoleName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SoldierOfficalInfos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SPID = c.Int(nullable: false),
                        SNO = c.String(),
                        SPICODE = c.String(),
                        TradeId = c.Int(nullable: false),
                        RankId = c.Int(nullable: false),
                        UnitName = c.String(),
                        SubUnitName = c.String(),
                        LastServedUnitName = c.String(),
                        JoiningDateOfUnit = c.DateTime(nullable: false),
                        JoiningDateOfArmy = c.DateTime(nullable: false),
                        RetirementDate = c.DateTime(nullable: false),
                        MedicalCategory = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Ranks", t => t.RankId, cascadeDelete: true)
                .ForeignKey("dbo.SolderPersonalInfos", t => t.SPID, cascadeDelete: true)
                .ForeignKey("dbo.Trades", t => t.TradeId, cascadeDelete: true)
                .Index(t => t.SPID)
                .Index(t => t.TradeId)
                .Index(t => t.RankId);
            
            CreateTable(
                "dbo.SolderPersonalInfos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        MiddleName = c.String(),
                        LastName = c.String(),
                        GenderId = c.Int(nullable: false),
                        DoB = c.DateTime(nullable: false),
                        BloodGroupId = c.Int(nullable: false),
                        PresentAddress = c.String(),
                        PermanentAddress = c.String(),
                        ContactNumber = c.String(),
                        EmailAddress = c.String(),
                        SoldierImage = c.Byte(nullable: false),
                        DistrictId = c.Int(nullable: false),
                        FatherName = c.String(),
                        MotherName = c.String(),
                        SpouseName = c.String(),
                        FatherContactNumber = c.String(),
                        MotherContactNumber = c.String(),
                        SpouseContactNumber = c.String(),
                        MaritalStatus = c.Int(nullable: false),
                        HaveChildren = c.Int(nullable: false),
                        NoOfSon = c.Int(nullable: false),
                        NoOfDaughter = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Trades",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TradeCode = c.String(),
                        TradeName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Uers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        UserPassword = c.String(),
                        RoleId = c.Int(nullable: false),
                        Status = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Roles", t => t.RoleId, cascadeDelete: true)
                .Index(t => t.RoleId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Uers", "RoleId", "dbo.Roles");
            DropForeignKey("dbo.SoldierOfficalInfos", "TradeId", "dbo.Trades");
            DropForeignKey("dbo.SoldierOfficalInfos", "SPID", "dbo.SolderPersonalInfos");
            DropForeignKey("dbo.SoldierOfficalInfos", "RankId", "dbo.Ranks");
            DropIndex("dbo.Uers", new[] { "RoleId" });
            DropIndex("dbo.SoldierOfficalInfos", new[] { "RankId" });
            DropIndex("dbo.SoldierOfficalInfos", new[] { "TradeId" });
            DropIndex("dbo.SoldierOfficalInfos", new[] { "SPID" });
            DropTable("dbo.Uers");
            DropTable("dbo.Trades");
            DropTable("dbo.SolderPersonalInfos");
            DropTable("dbo.SoldierOfficalInfos");
            DropTable("dbo.Roles");
            DropTable("dbo.Ranks");
            DropTable("dbo.Districts");
            DropTable("dbo.Branches");
        }
    }
}
