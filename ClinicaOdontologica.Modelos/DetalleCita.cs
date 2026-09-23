using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaOdontologica.Modelos
{
    [Table("detallescita")]
    public class DetalleCita
    {
        [Key]
        [Column("id_detalle_cita", TypeName = "Serial")]
        [Required]
        public int idDetalleCita { get; set; }
        [ForeignKey("Cita")]
        [Column("id_cita")]
        [Required]
        public int idCita { get; set; }
        [ForeignKey("Tratamiento")]
        [Column("id_tratamiento")]
        [Required]
        public int idTratamiento { get; set; }
        [Column("costo_aplicado", TypeName = "Decimal(10,2)")]
        [Required]
        public decimal costoAplicado { get; set; }
        [Required]
        [MaxLength(100)]
        public string observaciones { get; set; }

        //Objetos de navegacion
        public Cita? cita { get; set; }
        public Tratamiento tratamiento { get; set; }
    }
}
