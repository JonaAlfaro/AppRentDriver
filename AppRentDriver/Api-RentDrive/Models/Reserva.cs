using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Api_RentDrive.Models
{
    public class Reserva
    {
        public int Id { get; set; }
        public int IdCliente { get; set; }
        public int IdAutomovil { get; set; }
        public int IdSucursal { get; set; }
        public DateTime FechaReserva { get; set; }
        public Decimal Monto { get; set; }

        public virtual Sucursal Sucursal { get; set; }
        public virtual Cliente Cliente { get; set; }
        public virtual Automovil Automovil { get; set; }
    }
}