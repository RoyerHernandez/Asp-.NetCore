

using System;
using System.Collections.Generic;
using System.Linq;
using Asp_.NetCore.Models;
using Microsoft.AspNetCore.Mvc;

public class EvaluacionController: Controller{
    
    public IActionResult Index(){  
    
    return View(_context.Evaluaciones.FirstOrDefault());
    }
    
    
    public IActionResult MultiEvaluacion(){  

        return View("MultiEvaluacion",_context.Evaluaciones);
    }

    private EscuelaContext _context;
    public EvaluacionController(EscuelaContext context)
    {
        _context = context;
    }

}