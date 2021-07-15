namespace _1811062489_PhamCongMinh_Tuan3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAttendance : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Attendances",
                c => new
                {
                    CoursedId = c.Int(nullable: false),
                    AttendeeId = c.String(nullable: false, maxLength: 128),
                    Course_Id = c.Int(nullable: false),
                })
                .PrimaryKey(t => new { t.CoursedId, t.AttendeeId })
                .ForeignKey("dbo.AspNetUsers", t => t.AttendeeId, cascadeDelete: true)
                .ForeignKey("dbo.Courses", t => t.Course_Id)
                .Index(t => t.AttendeeId)
                .Index(t => t.Course_Id);

        }

        public override void Down()
        {
            DropForeignKey("dbo.Attendances", "Course_Id", "dbo.Courses");
            DropForeignKey("dbo.Attendances", "AttendeeId", "dbo.AspNetUsers");
            DropIndex("dbo.Attendances", new[] { "Course_Id" });
            DropIndex("dbo.Attendances", new[] { "AttendeeId" });
            DropTable("dbo.Attendances");
        }
    }
}
