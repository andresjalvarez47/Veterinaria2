using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Veterinaria.Models
{
    public partial class Mascota
    {

        public int IDMascota { get; set; }
        public string Nombre { get; set; }
        public int edad { get; set; }
        public int peso { get; set; }

        public Clientes Clientes { get; set; }
        public int IDCliente { get; set; }

         public ICollection<Reserva_Turnos> Reserva_Turnos { get; set; }
        

        //forein key
        public Tipo_Animal Tipo_Animal { get; set; }
         public int IDtipoanimal { get; set; }

    }



    // metadata
    [MetadataType(typeof(MascotaMetadata))]
    public partial class Mascota
    {
        public class MascotaMetadata
        {
            [Key]
            public int IDMascota { get; set; }


            [StringLength(200)]
            [Required]
            public string Nombre { get; set; }

            [Required]
            public int edad { get; set; }
            [Required]
            public int peso { get; set; }

        }
    }




}