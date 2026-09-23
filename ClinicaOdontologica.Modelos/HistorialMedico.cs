using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaOdontologica.Modelos
{
    [Table("historialesmedicos")]
    public class HistorialMedico
    {
        [Key]

        [Required]
        public int idHistorialMedico { get; set; }
        [Required]
        public string alergias { get; set; }
        public string enfermedadesPrevias { get; set; }
        public string tipoSangre { get; set; }
        [ForeignKey("")]
        [Column("id_paciente")]
       
        public int idPaciente { get; set; }
        public Paciente? paciente { get; set; }
    }
}
