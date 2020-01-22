namespace GymTrainingDiary.Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Excersises",
                c => new
                    {
                        Id = c.Decimal(nullable: false, precision: 18, scale: 0, identity: true),
                        ExcersiseTypeId = c.Decimal(nullable: false, precision: 18, scale: 0),
                        Training_Id = c.Decimal(precision: 18, scale: 0),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.PARAMs", t => t.ExcersiseTypeId, cascadeDelete: true)
                .ForeignKey("dbo.Trainings", t => t.Training_Id)
                .Index(t => t.ExcersiseTypeId)
                .Index(t => t.Training_Id);
            
            CreateTable(
                "dbo.PARAMs",
                c => new
                    {
                        Id = c.Decimal(nullable: false, precision: 18, scale: 0, identity: true),
                        Lable = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.RepeatSets",
                c => new
                    {
                        Id = c.Decimal(nullable: false, precision: 18, scale: 0, identity: true),
                        RepeatCount = c.Int(nullable: false),
                        Weight = c.Decimal(nullable: false, precision: 18, scale: 2),
                        WeightUnitId = c.Decimal(nullable: false, precision: 18, scale: 0),
                        Excersise_Id = c.Decimal(precision: 18, scale: 0),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.PARAMs", t => t.WeightUnitId, cascadeDelete: true)
                .ForeignKey("dbo.Excersises", t => t.Excersise_Id)
                .Index(t => t.WeightUnitId)
                .Index(t => t.Excersise_Id);
            
            CreateTable(
                "dbo.Permissions",
                c => new
                    {
                        Id = c.Decimal(nullable: false, precision: 18, scale: 0, identity: true),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Trainings",
                c => new
                    {
                        Id = c.Decimal(nullable: false, precision: 18, scale: 0, identity: true),
                        StartTime = c.DateTime(nullable: false),
                        FinishTime = c.DateTime(nullable: false),
                        TrainingDuration = c.Time(nullable: false, precision: 7),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.UserPermisssions",
                c => new
                    {
                        Id = c.Decimal(nullable: false, precision: 18, scale: 0, identity: true),
                        PermissionId = c.Decimal(nullable: false, precision: 18, scale: 0),
                        UserId = c.Decimal(nullable: false, precision: 18, scale: 0),
                        InsertTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Permissions", t => t.PermissionId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.PermissionId)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Decimal(nullable: false, precision: 18, scale: 0, identity: true),
                        DisplayName = c.String(),
                        Login = c.String(),
                        PasswordHash = c.String(),
                        Photo = c.Binary(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserPermisssions", "UserId", "dbo.Users");
            DropForeignKey("dbo.UserPermisssions", "PermissionId", "dbo.Permissions");
            DropForeignKey("dbo.Excersises", "Training_Id", "dbo.Trainings");
            DropForeignKey("dbo.RepeatSets", "Excersise_Id", "dbo.Excersises");
            DropForeignKey("dbo.RepeatSets", "WeightUnitId", "dbo.PARAMs");
            DropForeignKey("dbo.Excersises", "ExcersiseTypeId", "dbo.PARAMs");
            DropIndex("dbo.UserPermisssions", new[] { "UserId" });
            DropIndex("dbo.UserPermisssions", new[] { "PermissionId" });
            DropIndex("dbo.RepeatSets", new[] { "Excersise_Id" });
            DropIndex("dbo.RepeatSets", new[] { "WeightUnitId" });
            DropIndex("dbo.Excersises", new[] { "Training_Id" });
            DropIndex("dbo.Excersises", new[] { "ExcersiseTypeId" });
            DropTable("dbo.Users");
            DropTable("dbo.UserPermisssions");
            DropTable("dbo.Trainings");
            DropTable("dbo.Permissions");
            DropTable("dbo.RepeatSets");
            DropTable("dbo.PARAMs");
            DropTable("dbo.Excersises");
        }
    }
}
