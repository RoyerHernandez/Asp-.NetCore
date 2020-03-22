using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Asp_.NetCore.Models
{
    public class Asignatura:ObjetoEscuelaBase
    {
        [Required]
        public string CursoId { get; set; }
        [Required]
        [Display(Prompt="Nombre del Curso")]
        public Curso Curso { get; set; }
        public List<Evaluacion> Evaluaciones { get; set; } //= new List<Evaluacion>()
    }
}