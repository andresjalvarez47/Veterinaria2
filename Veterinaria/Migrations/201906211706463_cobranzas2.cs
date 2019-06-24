namespace Veterinaria.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class cobranzas2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Cobranzas", "IDReserva", "dbo.Reserva_Turnos");
            DropIndex("dbo.Cobranzas", new[] { "IDReserva" });
            DropColumn("dbo.Cobranzas", "IDReserva");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Cobranzas", "IDReserva", c => c.Int(nullable: false));
            CreateIndex("dbo.Cobranzas", "IDReserva");
            AddForeignKey("dbo.Cobranzas", "IDReserva", "dbo.Reserva_Turnos", "IDReserva", cascadeDelete: true);
        }
    }
}
