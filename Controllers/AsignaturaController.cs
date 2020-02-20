

using System;
using System.Collections.Generic;
using Asp_.NetCore.Models;
using Microsoft.AspNetCore.Mvc;

public class AsignaturaController: Controller{
    
    public IActionResult Index(){  
    
    return View(new Asignatura{Nombre="Matemáticas", Id= Guid.NewGuid().ToString()} );
    }
    
    
    public IActionResult MultiAsignatura(){  

       var listaAsignaturas = new List<Asignatura>(){
           
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
                };
        ViewBag.cosaDinamica = "Bienvenidos";
        ViewBag.fecha = DateTime.Now;
        return View("MultiAsignatura",listaAsignaturas);
    }

}