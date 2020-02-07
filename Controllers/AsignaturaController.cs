

using System;
using Asp_.NetCore.Models;
using Microsoft.AspNetCore.Mvc;

public class AsignaturaController: Controller{
    public IActionResult index(){  

        var asignatura = new Asignatura{
            UniqueId = Guid.NewGuid().ToString(),
            Nombre = "Programación"
        };
        ViewBag.cosaDinamica = "Bienvenidos";
        ViewBag.fecha = DateTime.Now;
        return View(asignatura);
    }

}