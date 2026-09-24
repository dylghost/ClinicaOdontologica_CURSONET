using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaOdontologica.Modelos
{
    [Table("citas")]
    public  class Cita
    {
        [Key]
        [Column("id_cita", TypeName = "Serial")]
        [Required]
        public int idCita { get; set; }
        [Required]
        public DateTime fechaCita { get; set; }
        [Required]
        [MaxLength(100)]
        public string motivo { get; set; }
        [Required]
        [MaxLength(50)]
        public string estadoCita { get; set; }
        [ForeignKey("paciente")]
        [Required]
        public int idPaciente { get; set; }
        [ForeignKey("odontologo")]
        [Required]
        public int idOdontologo { get; set; }
        [ForeignKey("consultorio")]
        [Required]
        public int idConsultorio { get; set; }

        //Obj de navegacion

        public Paciente? paciente { get; set; }
        public Odontologo? odontologo { get; set; }
        public Consultorio? consultorio { get; set; }

        //Relaciones
        List<DetalleCita> DetallesCita { get; set; }= new List<DetalleCita>();
        List<Receta> Recetas { get; set; } = new List<Receta>();

    }
}
