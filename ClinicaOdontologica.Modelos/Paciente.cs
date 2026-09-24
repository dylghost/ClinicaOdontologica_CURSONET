using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaOdontologica.Modelos
{
    [Table("pacientes")]
    public class Paciente
    {
        [Key]
        [Column("id_paciente",TypeName ="Serial")]
        public int idPaciente { get; set; }
        [MaxLength(10)]
        [Required]
        public string dni { get; set; }
        [MaxLength(100)]
        [Required]
        public string nombres { get; set; }
        [MaxLength(100)]
        [Required]
        public string apellidos { get; set; }
        [Column("fecha_nacimiento", TypeName = "date")]
        [Required]
        public DateOnly fechaNacimiento {  get; set; }
        [MaxLength(50)]
        [Required]
        public string email {  get; set; }
        [MaxLength(10)]
        [Required]
        public string telefono {  get; set; }
    }
}
