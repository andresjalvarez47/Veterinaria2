using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Veterinaria.Models
{
    public partial class Salas
    {

        public int IDSalas { get; set; }
        public string nombre { get; set; }

       // public ICollection<Medico_veterinario> Medico_veterinario { get; set; }
        public ICollection<Reserva_Turnos> Reserva_Turnos { get; set; }
    }


    // metadata
    [MetadataType(typeof(salasMetadata))]
    public partial class Salas
    {
        public class salasMetadata
        {
            [Key]
            public int IDSalas { get; set; }


            [StringLength(200)]
            [Required]
            public string nombre { get; set; }

           

        }
    }

}