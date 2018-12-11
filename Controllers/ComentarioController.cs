using System;
using System.Collections.Generic;
using checkpoint.Interfaces;
using checkpoint.Models;
using checkpoint.Repositorios;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace checkpoint.Controllers{
    public class ComentarioController : Controller {
        public IComentario ComentarioRepositorio {get; set;}

        public ComentarioController()
        {
            ComentarioRepositorio = new ComentarioRepositorioCSV();
        }

        [HttpGet]
         public ActionResult adm(){
             List<ComentarioModel> lsComentarios = ComentarioRepositorio.ComentarioCSV(HttpContext.Session.GetString("idNome"));
             ViewBag.lista = lsComentarios;
            return View();
        }

        [HttpPost]
        public ActionResult adm (IFormCollection form) {
            ComentarioModel comentarioModel = new ComentarioModel(
            nome: HttpContext.Session.GetString("idNome"),
            texto: form["texto"],
            dataCriacao: DateTime.Now,
            status: false
            );

            ComentarioRepositorio.CadastrarComentario (comentarioModel);

            List<ComentarioModel> lsComentarios = ComentarioRepositorio.ComentarioCSV(HttpContext.Session.GetString("idNome"));

            ViewBag.lista = lsComentarios;
            return View();
        }

        public ActionResult Cadastro(){
            List<ComentarioModel> lsComentarios = ComentarioRepositorio.ComentarioCSV(HttpContext.Session.GetString("idNome"));
            ViewBag.lista = lsComentarios;
            return View();
        }

        [HttpPost]
        public ActionResult Cadastro(IFormCollection form) {
            ComentarioModel comentarioModel = new ComentarioModel(
                nome:  HttpContext.Session.GetString ("idNome"),
                texto: form["texto"],
                dataCriacao: DateTime.Now,
                status: false
            );

            ComentarioRepositorio.CadastrarComentario (comentarioModel);
            return View();
        }

        [HttpGet]
        public IActionResult Aprova(int id){
            ComentarioRepositorioCSV comentario = new ComentarioRepositorioCSV();
            comentario.Aprova(id);
            return RedirectToAction("Cadastro","Comentario");
        }

        [HttpGet]

        public IActionResult Rejeita(int id){
             ComentarioRepositorio.Rejeita(id);
            return RedirectToAction("Cadastro","Comentario");
        }
    }
}