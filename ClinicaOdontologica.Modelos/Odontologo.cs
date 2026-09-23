using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaOdontologica.Modelos
{
    public class Odontologo
    {
        [Key]
        public int id_odontologo {  get; set; }
        [MaxLength(100)]
        [Required]
        public string nombres {  get; set; }
        [MaxLength(100)]
        [Required]
        public string apellidos {  get; set; }
        [Column("registro_medico")]
        [MaxLength(100)]
        [Required]
        public string registroMedico {  get; set; }
        [ForeignKey("especialidades")]
        public int IdPaciente { get; set; }

    }
}
