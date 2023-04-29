using System.ComponentModel.DataAnnotations;

namespace Sales.Shared.Entities
{
    public class Country
    {
      

        public int Id { get; set; }
        public DateTime? FechaDeUso { get; set; }
        public bool FueUsada { get; set; }
        public string Porteria { get; set; }

    }
}
