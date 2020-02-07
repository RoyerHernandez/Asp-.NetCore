

using System;
using Asp_.NetCore.Models;
using Microsoft.AspNetCore.Mvc;

public class EscuelaController: Controller{
    public IActionResult index(){  

        var escuela = new Escuela();
        escuela.UniqueId = Guid.NewGuid().ToString();
        escuela.Nombre = "Platzy School";
        escuela.AñoDeCreación = 2005;
        escuela.Pais = "Colombia";
        escuela.Ciudad = "Bogota";
        escuela.Dirección = "Calle falsa 123";
        escuela.TipoEscuela = TiposEscuela.Secundaria;
        
        ViewBag.cosaDinamica = "Bienvenidos";

        
        return View(escuela);
    }

}