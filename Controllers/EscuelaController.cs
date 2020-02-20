

using System;
using System.Linq;
using Asp_.NetCore.Models;
using Microsoft.AspNetCore.Mvc;

public class EscuelaController: Controller{

    private EscuelaContext _context;
    public IActionResult index(){  
        
        ViewBag.cosaDinamica = "Bienvenidos";

        var escuela = _context.Escuelas.FirstOrDefault();
        
        return View(escuela);
    }

    public EscuelaController(EscuelaContext context)
    {
        _context = context;
    }

}