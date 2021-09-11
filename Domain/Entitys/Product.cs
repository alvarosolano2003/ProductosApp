using Domain.Enums;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entitys
{
    [JsonObject(MemberSerialization.OptIn)]
    public class Product
    {
        [JsonProperty]
        public int Id { get; set; }
        [JsonProperty]
        public string Nombre { get; set; }
        [JsonProperty]
        public string Descripcion { get; set; }
        [JsonProperty]
        public int Existencia { get; set; }
        [JsonProperty]
        public decimal Precio { get; set; }
        [JsonProperty]
        public DateTime FechaDeVencimiento { get; set; }
        [JsonProperty]
        public UnidadDeMedida UnidadDeMedida { get; set; }
    }

    public class ProductPriceComparer : IComparer<Product>
    {
        public int Compare(Product e1, Product e2)
        {
            if (e1 == null || e2 == null)
            {
                throw new ArgumentException("Los elementos no pueden ser nulos");
            }

            if (e1.Precio > e2.Precio)
            {
                return 1;
            }
            else if (e1.Precio < e2.Precio)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}
