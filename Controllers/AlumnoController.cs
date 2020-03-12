

using System;
using System.Collections.Generic;
using System.Linq;
using Asp_.NetCore.Models;
using Microsoft.AspNetCore.Mvc;

public class AlumnoController: Controller{
    
    public IActionResult Index(string Id){ 

            if(!string.IsNullOrWhiteSpace(Id)){
            var Alumno = from alumn in _context.Alumnos
                                where  alumn.Id == Id
                                select alumn;
            return View(Alumno.SingleOrDefault());
            }
            else{
            return View("MultiAlumno",_context.Alumnos);        
            }
    }
    
    
    public IActionResult MultiAlumno(){  

        return View("MultiAlumno",_context.Alumnos);
    }

    private EscuelaContext _context;
    public AlumnoController(EscuelaContext context)
    {
        _context = context;
    }

}