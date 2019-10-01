namespace QuanLyNhanVien.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreatetableEmployeSalary : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        IDE = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                        Adress = c.String(nullable: false, maxLength: 100),
                        Email = c.String(nullable: false, maxLength: 200, unicode: false),
                        PassWord = c.String(nullable: false, maxLength: 20, unicode: false),
                        Position = c.String(maxLength: 50),
                        Education = c.String(maxLength: 50),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.IDE);
            
            CreateTable(
                "dbo.Salaries",
                c => new
                    {
                        IDS = c.Int(nullable: false, identity: true),
                        NgayDiLam = c.DateTime(nullable: false),
                        TongSoNgayDiLam = c.Int(nullable: false),
                        NgayNghiViec = c.Int(nullable: false),
                        LuongCoBan = c.Int(nullable: false),
                        TongSoLuong = c.Int(nullable: false),
                        IDE = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IDS);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Salaries");
            DropTable("dbo.Employees");
        }
    }
}
