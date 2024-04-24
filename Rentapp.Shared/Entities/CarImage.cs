using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rentapp.Shared.Entities
{
    public class CarImage
    {
        public int Id { get; set; }

        public Car Car { get; set; } = null!;

        public int CarId { get; set; }

        [Display(Name = "Imagen")]
        public string Image { get; set; } = null!;
    }
}
