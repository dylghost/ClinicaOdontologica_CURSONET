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
        [Column("id_factura",TypeName ="Serial")]
        [Required]

        public int idFactura { get; set; }
        [Column("fecha_emision",TypeName ="Time Zone")]
        [Required]
        public DateTime fechaEmision { get; set; }
        [Column("subtotal", TypeName = "Decimal(10,2)")]
        [Required]
        public decimal subTotal { get; set; }
        
        [Column(TypeName = "Decimal(10,2)")]
        [Required]
        public decimal impuestos { get; set; }
        [Column(TypeName = "Decimal(10,2)")]
        [Required]
        public decimal total { get; set; }
        [Column("estado_pago")]
        public string estadoPago { get; set; }
        [ForeignKey("Cita")]
        [Column("id_cita")]
        public int idCita { get; set; } 
        public Cita cita { get; set; }
    }
}
