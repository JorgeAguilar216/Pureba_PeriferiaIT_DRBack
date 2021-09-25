using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD_PeriferiaIT.Models
{
    public class Empleados
    {
        [Key]
        public int EmpleadosID { get; set; }
        [Column(TypeName = "varchar(100)")]
        public string Nombre { get; set; }
        [Column(TypeName = "varchar(100)")]
        public string Apellido { get; set; }
        [Column(TypeName = "bigint")]
        public int Identificacion { get; set; }
    }
}
