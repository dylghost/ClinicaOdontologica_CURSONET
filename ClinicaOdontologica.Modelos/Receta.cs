using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaOdontologica.Modelos
{
    [Table("recetas")]
    public class Receta
    {
        [Key]
        [Column("id_receta")]
        [Required]
        public int idReceta { get; set; }
        [Column("fecha_emision")]
        [Required]
        public DateTime fechaEmision { get; set; }
        [Required]
        public string indicaciones { get; set; }
        [ForeignKey("cita")]
        [Column("id_cita")]
        [Required]
        public int idCita { get; set; }
        public Cita? cita { get; set; } 
        

    }
}
