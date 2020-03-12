

using System;
using System.Collections.Generic;
using System.Linq;
using Asp_.NetCore.Models;
using Microsoft.AspNetCore.Mvc;

public class EvaluacionController: Controller{
    
    public IActionResult Index(string Id){ 

            if(!string.IsNullOrWhiteSpace(Id)){
            var Evaluac = from eval in _context.Evaluaciones
                                where  eval.Id == Id
                                select eval;
            return View(Evaluac.SingleOrDefault());
            }
            else{
            return View("MultiEvaluacion",_context.Evaluaciones);        
            }
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