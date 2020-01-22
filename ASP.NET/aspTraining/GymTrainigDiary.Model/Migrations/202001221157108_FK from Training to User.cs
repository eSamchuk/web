namespace GymTrainingDiary.Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FKfromTrainingtoUser : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Trainings", "UserId", c => c.Decimal(nullable: false, precision: 18, scale: 0));
            CreateIndex("dbo.Trainings", "UserId");
            AddForeignKey("dbo.Trainings", "UserId", "dbo.Users", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Trainings", "UserId", "dbo.Users");
            DropIndex("dbo.Trainings", new[] { "UserId" });
            DropColumn("dbo.Trainings", "UserId");
        }
    }
}
