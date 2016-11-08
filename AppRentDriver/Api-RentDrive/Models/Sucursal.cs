using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Api_RentDrive.Models
{
    public class Sucursal
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Calle { get; set; }
        public string Colonia { get; set; }
        public string Ciudad { get; set; }

        public virtual ICollection<Reserva> Reserva { get; set; }
        public virtual ICollection<Automovil> Automovil { get; set; }
    }
}