using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PlantShop.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Icon")]
        public string Icon { get; set; }
        [Display(Name = "Name")]
        public string Description { get; set; }

        //RELATIONS
        public List<Plant_Category> Plants_Categories { get; set; }
    }
}
