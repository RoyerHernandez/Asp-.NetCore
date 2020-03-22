using System;
using System.ComponentModel.DataAnnotations;

namespace Asp_.NetCore.Models
{
    public class Evaluacion:ObjetoEscuelaBase
    {
        [Required]
        public Alumno Alumno { get; set; }
        [Required]
        public string AlumnoId { get; set; }
        public Asignatura Asignatura  { get; set; }
        [Required]
        public string AsignaturaId { get; set; }
        public float Nota { get; set; }

        public override string ToString()
        {
            return $"{Nota}, {Alumno.Nombre}, {Asignatura.Nombre}";
        }
    }
}