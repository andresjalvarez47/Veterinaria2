using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Veterinaria.Models
{
    public class Identity : DbContext
    {

        public DbSet<Clientes> Clientes { get; set; }
        public DbSet<Mascota> Mascota { get; set; }
        public DbSet<Tipo_Animal> Tipo_Animal { get; set; }
        public DbSet<Medico_especialidad> Medico_especialidad { get; set; }
        public DbSet<Medico_veterinario> Medico_veterinario { get; set; }
        public DbSet<Salas> Salas { get; set; }
        public DbSet<Reserva_Turnos> Reserva_Turnos { get; set; }
        public DbSet<Medio_de_Pago> Medio_de_Pago { get; set; }
        public DbSet<Facturas> Facturas { get; set; }
        public DbSet<Detalle_Facturas> Detalle_Facturas { get; set; }
        public DbSet<Productos> Productos { get; set; }
        public DbSet<Categoria_Productos> Categoria_Productos { get; set; }
    }
}