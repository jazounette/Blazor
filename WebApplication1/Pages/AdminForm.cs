using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Pages  {
    public class AdminForm   {

        public (string nom, string ingré, double prix)[] PizzaTable = new []  {
              ("Végétarienne", "champignon, roquette, artichaut, aubergine", 10.00),
              ("Pepperoni", "mozzarella, pepperoni, tomates", 11.50),
              ("Reine", "jambon, champignons, mozzarella", 10.50),
              ("Mexicaine", "bœuf, mozzarella, maïs, tomates, oignon, coriandre", 12.00),
              ("Margherita", "sauce tomate, mozzarella, basilic", 11.88),
              ("4 Fromages", "cantal, mozzarella, fromage de chèvre, gruyère", 11.00)
        };

        [Required]
        public string Nom { get; set; }

        [Required]
        public string Ingrédient { get; set; }

        [Required]
        public double Prix { get; set; }

    }
}
