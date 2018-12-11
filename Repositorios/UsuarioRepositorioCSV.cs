using System;
using System.Collections.Generic;
using System.IO;
using checkpoint.Interfaces;
using checkpoint.Models;

namespace checkpoint.Repositorios {
    public class UsuarioRepositorioCSV : IUsuario
    {
        public UsuarioModel BuscarPorEmailESenha(string email, string senha)
        {
            List<UsuarioModel> usuariosCadastrados = CarregarDoCSV();

            foreach (UsuarioModel usuario in usuariosCadastrados)
            {
                if(usuario.Email == email && usuario.Senha == senha) {
                    return usuario;
                }
            }
            return null;
        }

        private List<UsuarioModel> CarregarDoCSV()
        {
            List<UsuarioModel> lsUsuarios = new List<UsuarioModel> ();

            string[] linhas = File.ReadAllLines ("usuarios.csv");

            foreach (string linha in linhas) {
                if(string.IsNullOrEmpty (linha)) {
                    continue;
                }

                string[] dadosDaLinha = linha.Split(';');

                UsuarioModel usuario = new UsuarioModel (
                    id: int.Parse(dadosDaLinha[0]),
                    nome: dadosDaLinha[1],
                    email: dadosDaLinha[2],
                    senha: dadosDaLinha[3]
                );

                lsUsuarios.Add(usuario);
            }
            return lsUsuarios;
        }

        public UsuarioModel BuscarPorID(int id)
        {
            string[] linhas = System.IO.File.ReadAllLines ("usuarios.csv");

            for (int i = 0; i < linhas.Length; i++)
            {
                if (string.IsNullOrEmpty (linhas[i])) {
                    continue;
                }

                string[] dados = linhas[i].Split (';');

                if(dados[0] == id.ToString()) {
                    UsuarioModel usuario = new UsuarioModel
                    (
                        id: int.Parse (dados[0]),
                        nome: dados[1],
                        email: dados[2],
                        senha: dados[3]
                    );

                    return usuario;
                }
            }
            return null;
        }

        public UsuarioModel Cadastrar(UsuarioModel usuarioModel)
        {
            if(File.Exists ("usuarios.csv")) {
                usuarioModel.ID = System.IO.File.ReadAllLines("usuarios.csv").Length +1;
            } else {
                usuarioModel.ID = 1;
            }

            if (usuarioModel.Nome == "Administrador" && usuarioModel.Email == "admin@carfel.com" && usuarioModel.Senha == "Admin")
            {
                usuarioModel.Administrador = true;
            } else {
                usuarioModel.Administrador = false;
            }

            using (StreamWriter sw =  new StreamWriter ("usuarios.csv", true)) {
                sw.WriteLine ($"{usuarioModel.ID};{usuarioModel.Nome};{usuarioModel.Email};{usuarioModel.Senha};{usuarioModel.Administrador}");
            }

            return usuarioModel;
        }

        public List<UsuarioModel> Listar()
        {
            throw new NotImplementedException();
        }
    }
}