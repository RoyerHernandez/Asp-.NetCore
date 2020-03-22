

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

    public IActionResult Edit(string Id)
    {
        Curso curso = _context.Cursos.Find(Id);
        if(curso == null){
            return View(curso);
        }
        return View(curso);
    }

    [HttpPost, ActionName("Edit")]
     public IActionResult Edit(Curso curso, string Id)
    {
        ViewBag.fecha = DateTime.Now;
        if(ModelState.IsValid){
        var Curso = _context.Cursos.Find(Id);
        curso.Id = Curso.Id;
        ViewBag.MensajeExtra = "Curso Actualizado";;
        _context.SaveChanges();
            return View("Index",curso);
        }else
        {
            return View(curso);
        }
    }

    public IActionResult Delete(string Id)
    {
        Curso curso = _context.Cursos.Find(Id);
        if(curso == null){
            return View(curso);
        }
        return View(curso);
    }

    [HttpPost, ActionName("Delete")]
     public IActionResult DeleteConfirmed(string Id)
    {
        ViewBag.fecha = DateTime.Now;
        if(ModelState.IsValid){
        var Curso = _context.Cursos.Find(Id);
        _context.Cursos.Remove(Curso);
        ViewBag.MensajeExtra = "Curso Actualizado";;
        _context.SaveChanges();
            return RedirectToAction("MultiCurso");
        }else
        {
          return RedirectToAction("MultiCurso");
        }
    }

    private EscuelaContext _context;
    public CursoController(EscuelaContext context)
    {
        _context = context;
    }

}