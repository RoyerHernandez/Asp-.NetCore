

using System;
using System.Collections.Generic;
using System.Linq;
using Asp_.NetCore.Models;
using Microsoft.AspNetCore.Mvc;

public class CursoController : Controller
{

    public IActionResult Index(string Id)
    {

        if (!string.IsNullOrWhiteSpace(Id))
        {
            var Curso = from curs in _context.Cursos
                        where curs.Id == Id
                        select curs;
            return View(Curso.SingleOrDefault());
        }
        else
        {
            return View("MultiCurso", _context.Cursos);
        }
    }


    public IActionResult MultiCurso()
    {

        return View("MultiCurso", _context.Cursos);
    }

    public IActionResult Create()
    {
        ViewBag.fecha = DateTime.Now;
        return View();
    }

    [HttpPost]
     public IActionResult Create(Curso curso)
    {
        ViewBag.fecha = DateTime.Now;
        if(ModelState.IsValid){
        var Escuela = _context.Escuelas.FirstOrDefault();
        curso.EscuelaId = Escuela.Id;
        ViewBag.MensajeExtra = "Curso Creado";
        _context.Cursos.Add(curso);
        _context.SaveChanges();
            return View("Index",curso);
        }else
        {
            return View(curso);
        }
    }

    public IActionResult Edit(Curso curso)
    {
        ViewBag.fecha = DateTime.Now;
        if(ModelState.IsValid){
        var Escuela = _context.Escuelas.FirstOrDefault();
        curso.EscuelaId = Escuela.Id;
        ViewBag.MensajeExtra = "Curso Creado";
        _context.Cursos.Add(curso);
        _context.SaveChanges();
            return View("Index",curso);
        }else
        {
            return View(curso);
        }
    }

    private EscuelaContext _context;
    public CursoController(EscuelaContext context)
    {
        _context = context;
    }

}