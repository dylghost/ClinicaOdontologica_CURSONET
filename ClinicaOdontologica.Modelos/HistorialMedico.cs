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
        [Column("id_historial", TypeName ="Serial")]
        [Required]
        public int idHistorialMedico { get; set; }
        [MaxLength(50)]
        [Required]
        public string alergias { get; set; }
        [Column("enfermedades_previas")]
        [MaxLength(100)]
        [Required]
        public string enfermedadesPrevias { get; set; }
        [Column("tipo_sangre")]
        [MaxLength(3)]
        public string tipoSangre { get; set; }
        [ForeignKey("paciente")]
        [Column("id_paciente")]
        public int idPaciente { get; set; }
        public Paciente? paciente { get; set; }
    }
}
