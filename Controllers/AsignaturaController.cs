

using System;
using System.Linq;
using System.Collections.Generic;
using Asp_.NetCore.Models;
using Microsoft.AspNetCore.Mvc;

public class AsignaturaController: Controller{
    
   /* public IActionResult Index(){  
            return View(_context.Asignaturas.FirstOrDefault());
    }*/
    [Route("Asignatura/Index/{asignaturaId?}")]
    public IActionResult Index(string asignaturaId){ 

            if(!string.IsNullOrWhiteSpace(asignaturaId)){
            var asignatura = from asig in _context.Asignaturas
                                where  asig.Id == asignaturaId
                                select asig;
            return View(asignatura.SingleOrDefault());
            }
            else{
            return View("MultiAsignatura",_context.Asignaturas);        
            }
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