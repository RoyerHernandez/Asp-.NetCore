

using System;
using System.Collections.Generic;
using System.Linq;
using Asp_.NetCore.Models;
using Microsoft.AspNetCore.Mvc;

public class AlumnoController: Controller{
    
    public IActionResult Index(){  
    
    return View(new Alumno{Nombre="Juan Perez", Id= Guid.NewGuid().ToString()} );
    }
    
    
    public IActionResult MultiAlumno(){  

       var listaAlumnos = GenerarAlumnosAlAzar();
        ViewBag.cosaDinamica = "Bienvenidos";
        ViewBag.fecha = DateTime.Now;
        return View("MultiAlumno",listaAlumnos);
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