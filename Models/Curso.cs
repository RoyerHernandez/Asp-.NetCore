using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Asp_.NetCore.Models
{
    public class Curso: ObjetoEscuelaBase
    {
        [Required(ErrorMessage="Se requiere el nombre del curso")]
        [StringLength(5)]
        public override string Nombre {get; set;}
        public TiposJornada Jornada { get; set; }
        public List<Asignatura> Asignaturas{ get; set; }
        public List<Alumno> Alumnos{ get; set; }
        [Display(Prompt="Dirección de Correspondencia")]
        [Required(ErrorMessage="Se requiere una dirección")]
        [MinLength(10)]
        public override string Dirección { get; set; }
        public string EscuelaId { get; set; }
        public Escuela Escuela { get; set; }

    }
}