using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaOdontologica.Modelos
{
    [Table("odontologos")]
    public class Odontologo
    {
        [Key]
        [Column("id_odontologo")]
        [Required]
        public int idOdontologo {  get; set; }
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
        [ForeignKey("especialidad")]
        [Column("id_especialidad")]
        public int idEspecialidad { get; set; }
        public Especialidad? especialidad { get; set; }

    }
}
