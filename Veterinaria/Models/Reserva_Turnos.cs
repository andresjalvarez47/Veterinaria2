using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Veterinaria.Models
{
    public partial class Reserva_Turnos
    {
        public int IDReserva { get; set; }
        public DateTime fecha { get; set; }

        


        //foreign key
     
        public Mascota Mascota { get; set; }
        public int IDMascota { get; set; }

        public Medico_veterinario Medico_veterinario { get; set; }
        public int IDMedico { get; set; }

        public Salas Salas { get; set; }
        public int IDSalas { get; set; }



       // public Mascota Mascota { get; set; }
      //  public int IDMascota { get; set; }

    }


    // metadata
    [MetadataType(typeof(reservaMetadata))]
    public partial class Reserva_Turnos
    {
        public class reservaMetadata
        {
            [Key]
            public int IDReserva { get; set; }


         



        }
    }

}