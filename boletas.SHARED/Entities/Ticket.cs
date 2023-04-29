﻿using System.ComponentModel.DataAnnotations;

namespace Boletas.Shared.Entities
{
    public class Ticket
    {
      
        [Display(Name = "Boleta")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public int Id { get; set; }
        public DateTime FechaDeUso { get; set; }
        public bool FueUsada { get; set; }
        public string Porteria { get; set; } = null!;

    }
}
