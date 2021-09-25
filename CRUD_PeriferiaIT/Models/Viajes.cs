using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD_PeriferiaIT.Models
{
    public class Viajes
    {
        [Key]
        public int ViajesID { get; set; }
        public int EmpleadosID { get; set; }
        [Column(TypeName = "varchar(100)")]
        public string Origen { get; set; }
        [Column(TypeName = "varchar(100)")]
        public string Destino { get; set; }
        [Column(TypeName = "float(1)")]
        public float TiempoViaje { get; set; }
        [Column(TypeName = "varchar(100)")]
        public string NombrePasajero { get; set; }
        [Column(TypeName = "int")]
        public int Vehiculo { get; set; }
        [Column(TypeName = "varchar(100)")]
        public string HoraViaje { get; set; }

        [ForeignKey("EmpleadosID")]
        public virtual Empleados Empleados { get; set; }
    }
}
