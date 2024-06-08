namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Vehicles", "EmpID", c => c.Int());
            CreateIndex("dbo.Vehicles", "EmpID");
            AddForeignKey("dbo.Vehicles", "EmpID", "dbo.Employees", "EmpID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Vehicles", "EmpID", "dbo.Employees");
            DropIndex("dbo.Vehicles", new[] { "EmpID" });
            DropColumn("dbo.Vehicles", "EmpID");
        }
    }
}
