using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;


namespace WebApplication1.Pages  {

    public class Customer  {

        [Required]
        public string Name { get; set; }

        [Required]
        public string Courriel { get; set; }

        [Required, RegularExpression("^[0-9]*$")]
        public int Age { get; set; }

        [Required, StringLength(55, MinimumLength = 1, ErrorMessage = "Le nombre de caractère minimum est de 1 et le maximum est de 55")]
        public string Adresse { get; set; }

        [Required, RegularExpression("^[0-9]{5}$")]
        public string CodePost { get; set; }

        [Required]
        public string Couleur { get; set; }

        [Required]
        public DateTime DateNaiss { get; set; }

        [Required]
        public bool Celib { get; set; }

    }
}
