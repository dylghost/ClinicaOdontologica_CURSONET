using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaOdontologica.Modelos
{
    [Table("facturas")]
    public class Factura
    {
        [Key]
        [Column("id_factura")]
        [Required]

        public int idFactura { get; set; }
        [Column("fecha_emision",TypeName ="date")]
        [Required]
        public DateTime fechaEmision { get; set; }
        [Column("subtotal")]
        [Required]
        public decimal subTotal { get; set; }
        
        [Required]
        public decimal impuestos { get; set; }
        [Required]
        public decimal total { get; set; }
        [Column("estado_pago")]
        public string estadoPago { get; set; }
        [ForeignKey("cita")]
        [Column("id_cita")]
        public int idCita { get; set; } 
        public Cita? cita { get; set; }

        //Relaciones

        List<Cita> citas { get; set; } = new List<Cita>();
    }
}
