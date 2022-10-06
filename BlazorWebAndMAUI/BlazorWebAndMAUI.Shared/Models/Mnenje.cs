using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorWebAndMAUI.Shared.Models
{
    public class Mnenje
    {
        public Guid ID { get; set; }

        [Required(ErrorMessage = "Polje 'ime' je obvezno."), MinLength(3, ErrorMessage = "Minimalna dolžina imena je 3 znake."), MaxLength(100, ErrorMessage = "Maksimalna dolžina imena je 100 znakov.")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Polje 'Moj TOP Blazor' je obvezno.")]
        public string? MojBlazor { get; set; }
    }
}
