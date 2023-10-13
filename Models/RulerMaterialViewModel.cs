using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace MvcRuler.Models
{
    public class RulerMaterialViewModel
    {
        public List<Ruler> Rulers { get; set; }
        public SelectList Materials { get; set; }
        public string RulerMaterial { get; set; }
        public string SearchString { get; set; }
    }
}