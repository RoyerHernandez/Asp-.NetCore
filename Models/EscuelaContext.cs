using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Asp_.NetCore.Models
{
    public class EscuelaContext :DbContext
    {
        public DbSet<Escuela> Escuelas { get; set; }

        public DbSet<Asignatura> Asignaturas { get; set; }

        public DbSet<Evaluacion> Evaluaciones { get; set; }

        public DbSet<Curso> Cursos { get; set; }

        public DbSet<Alumno> Alumnos {get; set;}

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

                  modelBuilder.Entity<Escuela>().HasData(escuela);

                  modelBuilder.Entity<Asignatura>().HasData(
                            new Asignatura{Nombre="Matemáticas",
                                Id= Guid.NewGuid().ToString()
                            } ,
                            new Asignatura{Nombre="Educación Física",
                                Id= Guid.NewGuid().ToString()
                            },
                            new Asignatura{Nombre="Castellano",
                                Id= Guid.NewGuid().ToString()
                            },
                            new Asignatura{Nombre="Ciencias Naturales",
                                Id= Guid.NewGuid().ToString()
                            }
                            ,
                            new Asignatura{Nombre="Programación",
                                Id= Guid.NewGuid().ToString()
                            }
                  );

                   modelBuilder.Entity<Alumno>().HasData(GenerarAlumnosAlAzar().ToArray());

         }

          private List<Alumno> GenerarAlumnosAlAzar()
        {
            string[] nombre1 = { "Juan", "Camilo", "Andres", "Andrea", "Karen", "Karla", "Ximena" };
            string[] apellido = { "Arciniegas", "Teeran", "Uribe", "Gacha", "Macri", "Quintero", "Lopez" };
            string[] nombre2 = { "Esteban", "Carlos", "Felipe", "Ana", "Lauren", "Bruno", "Catalina" };

            var listaAlumnos = from n1 in nombre1
                               from n2 in nombre2
                               from a1 in apellido
                               select new Alumno { Nombre = $"{n1} {n2} {a1}",
                                                    Id = Guid.NewGuid().ToString() };

            return listaAlumnos.OrderBy((al) => al.Id).ToList();

        }

    }
}