using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CorePersonelTakibiApp.Models
{
    public class Person
    {
        public int PersonID { get; set; }
        [Required(ErrorMessage ="Doldurulması zorunlu alandır!")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Doldurulması zorunlu alandır!")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Doldurulması zorunlu alandır!")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Doldurulması zorunlu alandır!")]
        public string Mail { get; set; }
        [Required(ErrorMessage = "Doldurulması zorunlu alandır!")]
        public Gender Gender { get; set; }
        public string Address { get; set; }
        [Required(ErrorMessage = "Doldurulması zorunlu alandır!")]
        public Departman Departman { get; set; }
        [Required(ErrorMessage = "Doldurulması zorunlu alandır!")]
        public string ImageUrl { get; set; }
    }
}
