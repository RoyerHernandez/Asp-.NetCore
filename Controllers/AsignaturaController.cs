

using System;
using System.Linq;
using System.Collections.Generic;
using Asp_.NetCore.Models;
using Microsoft.AspNetCore.Mvc;

public class AsignaturaController: Controller{
    
    public IActionResult Index(){  
            return View(_context.Asignaturas.FirstOrDefault());
    }
    
    
    public IActionResult MultiAsignatura(){  

        ViewBag.cosaDinamica = "Bienvenidos";
        ViewBag.fecha = DateTime.Now;
        return View("MultiAsignatura",_context.Asignaturas);
    }
    private EscuelaContext _context;
    public AsignaturaController(EscuelaContext context)
    {
        _context = context;
    }

}