namespace Veterinaria.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class cobranzas : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clientes",
                c => new
                    {
                        IDCliente = c.Int(nullable: false, identity: true),
                        Dni = c.Int(nullable: false),
                        Nombre = c.String(nullable: false, maxLength: 200),
                        Apellido = c.String(nullable: false, maxLength: 200),
                        Direccion = c.String(nullable: false, maxLength: 200),
                        Ciudad = c.String(nullable: false, maxLength: 200),
                        Provincia = c.String(nullable: false, maxLength: 200),
                        Codigo_postal = c.Int(nullable: false),
                        email = c.String(maxLength: 200),
                    })
                .PrimaryKey(t => t.IDCliente);
            
            CreateTable(
                "dbo.Cobranzas",
                c => new
                    {
                        IDFacturacion = c.Int(nullable: false, identity: true),
                        Cuit = c.Int(nullable: false),
                        Razon_Social = c.String(maxLength: 200),
                        Importe = c.Int(nullable: false),
                        IDCliente = c.Int(nullable: false),
                        IDReserva = c.Int(nullable: false),
                        IDMediopago = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IDFacturacion)
                .ForeignKey("dbo.Clientes", t => t.IDCliente, cascadeDelete: false)
                .ForeignKey("dbo.Medio_de_Pago", t => t.IDMediopago, cascadeDelete: false)
                .ForeignKey("dbo.Reserva_Turnos", t => t.IDReserva, cascadeDelete: false)
                .Index(t => t.IDCliente)
                .Index(t => t.IDReserva)
                .Index(t => t.IDMediopago);
            
            CreateTable(
                "dbo.Medio_de_Pago",
                c => new
                    {
                        IDMediopago = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 200),
                    })
                .PrimaryKey(t => t.IDMediopago);
            
            CreateTable(
                "dbo.Reserva_Turnos",
                c => new
                    {
                        IDReserva = c.Int(nullable: false, identity: true),
                        fecha = c.DateTime(nullable: false),
                        IDMascota = c.Int(nullable: false),
                        IDMedico = c.Int(nullable: false),
                        IDSalas = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IDReserva)
                .ForeignKey("dbo.Mascotas", t => t.IDMascota, cascadeDelete: true)
                .ForeignKey("dbo.Medico_veterinario", t => t.IDMedico, cascadeDelete: true)
                .ForeignKey("dbo.Salas", t => t.IDSalas, cascadeDelete: true)
                .Index(t => t.IDMascota)
                .Index(t => t.IDMedico)
                .Index(t => t.IDSalas);
            
            CreateTable(
                "dbo.Mascotas",
                c => new
                    {
                        IDMascota = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 200),
                        edad = c.Int(nullable: false),
                        peso = c.Int(nullable: false),
                        IDCliente = c.Int(nullable: false),
                        IDtipoanimal = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IDMascota)
                .ForeignKey("dbo.Clientes", t => t.IDCliente, cascadeDelete: true)
                .ForeignKey("dbo.Tipo_Animal", t => t.IDtipoanimal, cascadeDelete: true)
                .Index(t => t.IDCliente)
                .Index(t => t.IDtipoanimal);
            
            CreateTable(
                "dbo.Tipo_Animal",
                c => new
                    {
                        IDtipoanimal = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 200),
                    })
                .PrimaryKey(t => t.IDtipoanimal);
            
            CreateTable(
                "dbo.Medico_veterinario",
                c => new
                    {
                        IDMedico = c.Int(nullable: false, identity: true),
                        nombre = c.String(nullable: false, maxLength: 200),
                        apellido = c.String(nullable: false, maxLength: 200),
                        edad = c.Int(nullable: false),
                        IDEspecialidad = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IDMedico)
                .ForeignKey("dbo.Medico_especialidad", t => t.IDEspecialidad, cascadeDelete: true)
                .Index(t => t.IDEspecialidad);
            
            CreateTable(
                "dbo.Medico_especialidad",
                c => new
                    {
                        IDEspecialidad = c.Int(nullable: false, identity: true),
                        nombre = c.String(nullable: false, maxLength: 200),
                    })
                .PrimaryKey(t => t.IDEspecialidad);
            
            CreateTable(
                "dbo.Salas",
                c => new
                    {
                        IDSalas = c.Int(nullable: false, identity: true),
                        nombre = c.String(nullable: false, maxLength: 200),
                    })
                .PrimaryKey(t => t.IDSalas);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Reserva_Turnos", "IDSalas", "dbo.Salas");
            DropForeignKey("dbo.Reserva_Turnos", "IDMedico", "dbo.Medico_veterinario");
            DropForeignKey("dbo.Medico_veterinario", "IDEspecialidad", "dbo.Medico_especialidad");
            DropForeignKey("dbo.Mascotas", "IDtipoanimal", "dbo.Tipo_Animal");
            DropForeignKey("dbo.Reserva_Turnos", "IDMascota", "dbo.Mascotas");
            DropForeignKey("dbo.Mascotas", "IDCliente", "dbo.Clientes");
            DropForeignKey("dbo.Cobranzas", "IDReserva", "dbo.Reserva_Turnos");
            DropForeignKey("dbo.Cobranzas", "IDMediopago", "dbo.Medio_de_Pago");
            DropForeignKey("dbo.Cobranzas", "IDCliente", "dbo.Clientes");
            DropIndex("dbo.Medico_veterinario", new[] { "IDEspecialidad" });
            DropIndex("dbo.Mascotas", new[] { "IDtipoanimal" });
            DropIndex("dbo.Mascotas", new[] { "IDCliente" });
            DropIndex("dbo.Reserva_Turnos", new[] { "IDSalas" });
            DropIndex("dbo.Reserva_Turnos", new[] { "IDMedico" });
            DropIndex("dbo.Reserva_Turnos", new[] { "IDMascota" });
            DropIndex("dbo.Cobranzas", new[] { "IDMediopago" });
            DropIndex("dbo.Cobranzas", new[] { "IDReserva" });
            DropIndex("dbo.Cobranzas", new[] { "IDCliente" });
            DropTable("dbo.Salas");
            DropTable("dbo.Medico_especialidad");
            DropTable("dbo.Medico_veterinario");
            DropTable("dbo.Tipo_Animal");
            DropTable("dbo.Mascotas");
            DropTable("dbo.Reserva_Turnos");
            DropTable("dbo.Medio_de_Pago");
            DropTable("dbo.Cobranzas");
            DropTable("dbo.Clientes");
        }
    }
}
