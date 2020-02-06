

using System;
using Asp_.NetCore.Models;
using Microsoft.AspNetCore.Mvc;

public class EscuelaController: Controller{
    public IActionResult index(){  

        var escuela = new Escuela();
        escuela.IdEscuela = Guid.NewGuid().ToString();
        escuela.Nombre = "Platzy School";
        escuela.AñoFundacion = 2005;
        ViewBag.cosaDinamica = "Bienvenidos";
        
        return View(escuela);
    }

}