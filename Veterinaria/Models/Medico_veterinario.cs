using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Veterinaria.Models
{
    public partial class Medico_veterinario
    {

        public int IDMedico { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public int edad { get; set; }

        public ICollection<Reserva_Turnos> Reserva_Turnos { get; set; }


        //foreign key
        public Medico_especialidad Medico_especialidad { get; set; }
        public int IDEspecialidad { get; set; }

       // public Salas Salas { get; set; }
      //  public int IDSalas { get; set; }


    }




    // metadata
    [MetadataType(typeof(medicoMetadata))]
    public partial class Medico_veterinario
    {
        public class medicoMetadata
        {
            [Key]
            public int IDMedico { get; set; }


            [StringLength(200)]
            [Required]
            public string nombre { get; set; }
            [StringLength(200)]
            [Required]
            public string apellido { get; set; }
            
            [Required]
            public int edad { get; set; }

        }
    }

}