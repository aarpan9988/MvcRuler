using System;
using System.ComponentModel.DataAnnotations;

namespace MvcRuler.Models
{
    public class Ruler
    
        {
        public int Id { get; set; }
        public string Title { get; set; }

        public string Purpose { get; set; }
        public string Material { get; set; }

        public decimal Length { get; set; }
        public decimal Price { get; set; }
    }
}

