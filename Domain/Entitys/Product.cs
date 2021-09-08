using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entitys
{
    public class Product
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int Existencia { get; set; }
        public decimal Precio { get; set; }
        public DateTime FechaDeVencimiento { get; set; }
        public UnidadDeMedida UnidadDeMedida { get; set; }

    }
}
