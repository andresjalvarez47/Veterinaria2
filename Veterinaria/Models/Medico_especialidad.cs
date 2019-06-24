using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Veterinaria.Models
{
    public partial class Medico_especialidad
    {
        public int IDEspecialidad { get; set; }
        public string nombre { get; set; }


        public ICollection<Medico_veterinario> Medico_veterinario { get; set; }
    }


    // metadata
    [MetadataType(typeof(especialidadMetadata))]
    public partial class Medico_especialidad
    {
        public class especialidadMetadata
        {
            [Key]
            public int IDEspecialidad { get; set; }


            [StringLength(200)]
            [Required]
            public string nombre { get; set; }



        }
    }

}