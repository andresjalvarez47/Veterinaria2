namespace Veterinaria.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Veterinaria.Models.Identity>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Veterinaria.Models.Identity context)
        {


            // MEDIO DE PAGO
            context.Medio_de_Pago.AddOrUpdate(

               p => p.IDMediopago,

                new Models.Medio_de_Pago { IDMediopago = 0, Nombre = "Tarjeta" },
                new Models.Medio_de_Pago { IDMediopago = 1, Nombre = "Efectivo" },
                new Models.Medio_de_Pago { IDMediopago = 2, Nombre = "Transferencia" });


            // SALAS
            context.Salas.AddOrUpdate(

             p => p.IDSalas,

              new Models.Salas { IDSalas = 0, nombre = "consultorio1" },
              new Models.Salas { IDSalas = 1, nombre = "consultorio2" },
              new Models.Salas { IDSalas = 2, nombre = "Sala Cirugia" });


            // CLIENTES
            context.Clientes.AddOrUpdate(

            p => p.IDCliente,

             new Models.Clientes { IDCliente = 0, Dni = 33254458, Nombre = "Juan", Apellido = "Rodriguez", Direccion = "alberdi 542", Ciudad = "San Miguel", Codigo_postal = 1663, Provincia = "Buenos Aires", email = "juan.rodri@hotmail.com" },
             new Models.Clientes { IDCliente = 1, Dni = 32254759, Nombre = "Alberto", Apellido = "Santillan", Direccion = "Conesa 772", Ciudad = "San Miguel", Codigo_postal = 1663, Provincia = "Buenos Aires", email = "Alberto.santi@hotmail.com" },
             new Models.Clientes { IDCliente = 2, Dni = 34554621, Nombre = "Nicolas", Apellido = "Diorio", Direccion = "Paunero 111", Ciudad = "San Miguel", Codigo_postal = 1663, Provincia = "Buenos Aires", email = "n.diorio@gmail.com" },
             new Models.Clientes { IDCliente = 3, Dni = 31015468, Nombre = "Ruben", Apellido = "Giglio", Direccion = "San Martin 745", Ciudad = "Bella Vista", Codigo_postal = 1663, Provincia = "Buenos Aires", email = "rub.giglio@gmail.com" }
             );


            // TIPO ANIMAL
            context.Tipo_Animal.AddOrUpdate(

             p => p.IDtipoanimal,

              new Models.Tipo_Animal { IDtipoanimal = 0, Nombre = "Perro" },
              new Models.Tipo_Animal { IDtipoanimal = 1, Nombre = "Gato" },
              new Models.Tipo_Animal { IDtipoanimal = 2, Nombre = "Hamster" },
              new Models.Tipo_Animal { IDtipoanimal = 3, Nombre = "Aves" }
              );



            // MASCOTA
            context.Mascota.AddOrUpdate(

             p => p.IDMascota,

              new Models.Mascota { IDMascota = 0, Nombre = "Tyson", edad = 8, peso = 3, IDtipoanimal = 0,IDCliente = 0 },
              new Models.Mascota { IDMascota = 1, Nombre = "Jason", edad = 6, peso = 2, IDtipoanimal = 0, IDCliente = 1 },
              new Models.Mascota { IDMascota = 2, Nombre = "Julian", edad = 2, peso = 2, IDtipoanimal = 1, IDCliente = 2 },
              new Models.Mascota { IDMascota = 3, Nombre = "Mauro", edad = 3, peso = 1, IDtipoanimal = 3, IDCliente = 3 },
              new Models.Mascota { IDMascota = 4, Nombre = "Jack", edad = 2, peso = 1, IDtipoanimal = 2, IDCliente = 3 }
              );


            // MEDICO_ESPECIALIDAD
            context.Medico_especialidad.AddOrUpdate(

             p => p.IDEspecialidad,

             new Models.Medico_especialidad { IDEspecialidad = 0, nombre = "Clinico" },
             new Models.Medico_especialidad { IDEspecialidad = 1, nombre = "Cirujano" });


            // MEDICO_VETERINARIOS
            context.Medico_veterinario.AddOrUpdate(

             p => p.IDMedico,

              new Models.Medico_veterinario { IDMedico = 0, nombre = "Marcelo", apellido = "Rodriguez", edad = 50, IDEspecialidad = 0 },
              new Models.Medico_veterinario { IDMedico = 1, nombre = "Alberto", apellido = "Sandoval", edad = 53, IDEspecialidad = 0 },
              new Models.Medico_veterinario { IDMedico = 2, nombre = "Ricardo", apellido = "Martinez", edad = 44, IDEspecialidad = 1 }
              );


            // RESERVA_TURNOS
            context.Reserva_Turnos.AddOrUpdate(

             p => p.IDReserva,

              new Models.Reserva_Turnos { IDReserva = 0, fecha = DateTime.Parse("2019-11-01T19:35:00.0000000Z"), IDMedico = 0, IDSalas = 0, IDMascota = 0, },
              new Models.Reserva_Turnos { IDReserva = 1, fecha = DateTime.Parse("2019-11-02T15:20:00.0000000Z"), IDMedico = 1, IDSalas = 1, IDMascota = 1, },
              new Models.Reserva_Turnos { IDReserva = 2, fecha = DateTime.Parse("2019-11-03T18:40:00.0000000Z"), IDMedico = 1, IDSalas = 1, IDMascota = 2, },
              new Models.Reserva_Turnos { IDReserva = 3, fecha = DateTime.Parse("2019-11-03T17:20:00.0000000Z"), IDMedico = 2, IDSalas = 2, IDMascota = 3, },
              new Models.Reserva_Turnos { IDReserva = 4, fecha = DateTime.Parse("2019-11-04T17:00:00.0000000Z"), IDMedico = 2, IDSalas = 2, IDMascota = 4, }
              );


            // FACTURAS
           context.Facturas.AddOrUpdate(

            p => p.IDFacturacion,

              new Models.Facturas { IDFacturacion = 0, Cuit = 2033254710, Razon_Social = "Juan SA", Importe = 2000, IDCliente = 0, IDMediopago = 2  },
              new Models.Facturas { IDFacturacion = 1, Cuit = 2025487940, Razon_Social = "Imprenta SA", Importe = 1500, IDCliente = 1, IDMediopago = 1 },
              new Models.Facturas { IDFacturacion = 2, Importe = 700, IDCliente = 2, IDMediopago = 0 },
              new Models.Facturas { IDFacturacion = 3, Importe = 2500, IDCliente = 3, IDMediopago = 0 }
              );






            // CATEGORIA_PRODUCTOS
            context.Categoria_Productos.AddOrUpdate(

             p => p.IDCategoriaproductos,

             new Models.Categoria_Productos { IDCategoriaproductos = 0, nombre = "Articulos" },
             new Models.Categoria_Productos { IDCategoriaproductos = 1, nombre = "Servicios" });



            // PRODUCTOS
            context.Productos.AddOrUpdate(

             p => p.IDProductos,

             new Models.Productos { IDProductos= 0,IDCategoriaproductos = 1,nombre = "Cirujia",precio=5000 },
             new Models.Productos { IDProductos = 1, IDCategoriaproductos = 1, nombre = "Baño",precio=1200 },
             new Models.Productos { IDProductos = 2, IDCategoriaproductos = 1, nombre = "Consulta_Medica",precio=600 },
             new Models.Productos { IDProductos = 3, IDCategoriaproductos = 0, nombre = "Vacuna",precio=1000 },
             new Models.Productos { IDProductos = 4, IDCategoriaproductos = 0, nombre = "Colchoneta",precio=500 },
             new Models.Productos { IDProductos = 5, IDCategoriaproductos = 0, nombre = "Collar",precio=350 },
             new Models.Productos { IDProductos = 6, IDCategoriaproductos = 0, nombre = "Correa",precio=200 },
             new Models.Productos { IDProductos = 7, IDCategoriaproductos = 0, nombre = "Antiparasitario",precio=530 },
             new Models.Productos { IDProductos = 8, IDCategoriaproductos = 0, nombre = "Alimento_balanceado",precio=230 }
            );



            // DETALLE_FACTURAS
            context.Detalle_Facturas.AddOrUpdate(

             p => p.IDdetallefacturas,

             new Models.Detalle_Facturas { IDdetallefacturas = 0, IDFacturacion = 0, IDProductos=0 },
             new Models.Detalle_Facturas { IDdetallefacturas = 0, IDFacturacion = 0, IDProductos = 4 });





            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
