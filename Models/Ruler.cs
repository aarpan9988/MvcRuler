using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcRuler.Models
{
    public class Ruler
    
        {
        public int Id { get; set; }
        public string Title { get; set; }

        public string Purpose { get; set; }
        public string Material { get; set; }

        public decimal Length { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }


    }
}

