using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Asp_.NetCore.Models
{
    public class EscuelaContext : DbContext
    {
        public DbSet<Escuela> Escuelas { get; set; }

        public DbSet<Asignatura> Asignaturas { get; set; }

        public DbSet<Evaluacion> Evaluaciones { get; set; }

        public DbSet<Curso> Cursos { get; set; }

        public DbSet<Alumno> Alumnos { get; set; }

        public EscuelaContext(DbContextOptions<EscuelaContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var escuela = new Escuela();
            escuela.Id = Guid.NewGuid().ToString();
            escuela.Nombre = "Platzy School";
            escuela.AñoDeCreación = 2005;
            escuela.Pais = "Colombia";
            escuela.Ciudad = "Bogota";
            escuela.Dirección = "Calle falsa 123";
            escuela.TipoEscuela = TiposEscuela.Secundaria;

            //Cargar cursos de la Escuela
            var cursos = CargarCursos(escuela);
            //X cada curso cargar asignaturas
            var asignaturas = CargarAsignaturas(cursos);

            //X cada curso cargar alumnos

            var alumnos = CargarAlumnos(cursos);
            //Cargar evaluaciones

            modelBuilder.Entity<Escuela>().HasData(escuela);
            modelBuilder.Entity<Curso>().HasData(cursos.ToArray());
            modelBuilder.Entity<Asignatura>().HasData(asignaturas.ToArray());
            modelBuilder.Entity<Alumno>().HasData(alumnos.ToArray());
        }

        private static List<Asignatura> CargarAsignaturas(List<Curso> cursos)
        {
            var listaCompleta = new List<Asignatura>();
            foreach (var curso in cursos)
            {
                var tmpList = new List<Asignatura>{
                     new Asignatura{
                          Nombre = "Matemáticas",
                          CursoId = curso.Id,
                          Id = Guid.NewGuid().ToString()
                      },
                      new Asignatura{
                          Nombre = "Español",
                          CursoId = curso.Id,
                          Id = Guid.NewGuid().ToString()
                      },
                      new Asignatura{
                          Nombre = "Ingles",
                          CursoId = curso.Id,
                          Id = Guid.NewGuid().ToString()
                      },
                      new Asignatura
                      {
                          Nombre = "Educación Física",
                          CursoId = curso.Id,
                          Id = Guid.NewGuid().ToString()
                      },
                      new Asignatura
                      {
                          Nombre = "Programación",
                          CursoId = curso.Id,
                          Id = Guid.NewGuid().ToString()
                      }
                      };
                listaCompleta.AddRange(tmpList);
                //curso.Asignaturas = tmpList;
            }
            return listaCompleta;
        }

        private List<Alumno> GenerarAlumnosAlAzar(Curso curso, int cantidad)
        {
            string[] nombre1 = { "Juan", "Camilo", "Andres", "Andrea", "Karen", "Karla", "Ximena" };
            string[] apellido = { "Arciniegas", "Teeran", "Uribe", "Gacha", "Macri", "Quintero", "Lopez" };
            string[] nombre2 = { "Esteban", "Carlos", "Felipe", "Ana", "Lauren", "Bruno", "Catalina" };

            var listaAlumnos = from n1 in nombre1
                               from n2 in nombre2
                               from a1 in apellido
                               select new Alumno
                               {
                                   CursoId = curso.Id,
                                   Nombre = $"{n1} {n2} {a1}",
                                   Id = Guid.NewGuid().ToString()
                               };

            return listaAlumnos.OrderBy((al) => al.Id).Take(cantidad).ToList();

        }

        private List<Alumno> CargarAlumnos(List<Curso> cursos)
        {
            var listAlumnos = new List<Alumno>();
            Random rdn = new Random();
            foreach (var curso in cursos)
            {
                int cRandom = rdn.Next(1, 20);
                var tmpList = GenerarAlumnosAlAzar(curso, cRandom);
                listAlumnos.AddRange(tmpList);
            }
            return listAlumnos;
        }
        private static List<Curso> CargarCursos(Escuela escuela)
        {

            return new List<Curso>(){
            new Curso() {Id = Guid.NewGuid().ToString(),
                                          EscuelaId = escuela.Id,
                                          Nombre = "101",
                                          Jornada = TiposJornada.Mañana
                                           },
            new Curso() {Id = Guid.NewGuid().ToString(),
                                          EscuelaId = escuela.Id,
                                          Nombre = "201",
                                          Jornada = TiposJornada.Tarde
                                           },
            new Curso() {Id = Guid.NewGuid().ToString(),
                                          EscuelaId = escuela.Id,
                                          Nombre = "301",
                                          Jornada = TiposJornada.Noche
                                           },
            new Curso() {Id = Guid.NewGuid().ToString(),
                                          EscuelaId = escuela.Id,
                                          Nombre = "401",
                                          Jornada = TiposJornada.Mañana
                                           },
            new Curso() {Id = Guid.NewGuid().ToString(),
                                          EscuelaId = escuela.Id,
                                          Nombre = "501",
                                          Jornada = TiposJornada.Tarde
                                           },
                                           };
        }

    }
}