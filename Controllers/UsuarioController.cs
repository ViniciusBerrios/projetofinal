using System;
using checkpoint.Interfaces;
using checkpoint.Models;
using checkpoint.Repositorios;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace checkpoint.Controllers {

    public class UsuarioController : Controller {
        public IUsuario UsuarioRepositorio { get; set; }

        public UsuarioController () {
            UsuarioRepositorio = new UsuarioRepositorioCSV ();
        }

        [HttpGet]
        public ActionResult cadastra () {

            return View ();
        }

        public ActionResult carfel () {
            return View ();
        }

        public ActionResult cadastro () {
            return View ();
        }

        [HttpPost]

        public ActionResult cadastra (IFormCollection form) {
            UsuarioModel usuarioModel = new UsuarioModel (
                form["nome"],
                form["email"],
                form["senha"]
            );

            UsuarioRepositorio.Cadastrar (usuarioModel);

            ViewBag.Mensagem = "Cadastrado";

            return RedirectToAction ("Login", "Usuario");
        }

        [HttpGet]

        public IActionResult Login () => View ();

        [HttpPost]
        public IActionResult Login (IFormCollection form) {
            UsuarioModel usuario = new UsuarioModel (email: form["email"], senha: form["senha"]);

            UsuarioModel usuarioModel = UsuarioRepositorio.BuscarPorEmailESenha (usuario.Email, usuario.Senha);

            if (usuarioModel != null) {
                HttpContext.Session.SetString ("idNome", usuarioModel.Nome.ToString ());
                HttpContext.Session.SetString ("idEmail", usuarioModel.Email.ToString ());

                ViewBag.Mensagem = "Login Feito Com Sucesso!";

                return RedirectToAction ("cadastro", "comentario");
                
            }

            return View ();
        }
    }
}