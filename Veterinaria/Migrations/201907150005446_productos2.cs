namespace Veterinaria.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class productos2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Productos", "precio", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Productos", "precio");
        }
    }
}
