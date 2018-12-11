using System;
using System.Collections.Generic;
using System.IO;
using checkpoint.Interfaces;
using checkpoint.Models;

namespace checkpoint.Repositorios {
    public class ComentarioRepositorioCSV :  IComentario
    {
               public void CadastrarComentario(ComentarioModel comentarioModel)
        {
            if(File.Exists("comentarios.csv")){
                comentarioModel.ID = System.IO.File.ReadAllLines("comentarios.csv").Length +1;
            } else{
                comentarioModel.ID = 1;
            }

            using (StreamWriter sw = new StreamWriter ("comentarios.csv", true)) {
                sw.WriteLine ($"{comentarioModel.ID}; {comentarioModel.Nome}; {comentarioModel.Texto}; {comentarioModel.DataCriacao}; {comentarioModel.Status}");
            }

            // return comentarioModel;
        }

        public List<ComentarioModel> ComentarioCSV (string idNome){
            List<ComentarioModel> lsComentarios = new List<ComentarioModel> ();

            string[] linhas = File.ReadAllLines ("comentarios.csv");

            for (int i = linhas.Length - 1; i >= 0; i--)
            {
                string[] dadosDaLinha = linhas[i].Split(";");
                if(string.IsNullOrEmpty(linhas[i])) {
                    continue;
                }

                ComentarioModel comentario = new ComentarioModel(
                    id: int.Parse(dadosDaLinha[0]),
                    nome: dadosDaLinha[1],
                    texto: dadosDaLinha[2],
                    dataCriacao: DateTime.Parse(dadosDaLinha[3]),
                    status: bool.Parse(dadosDaLinha[4])
                );

                lsComentarios.Add(comentario);
            }
            
            return lsComentarios;
        }

        public void Aprova(int id) {
            string[] linhas = File.ReadAllLines("comentarios.csv");

            for (int i = 0; i < linhas.Length; i++)
            {
                string[] dadosDaLinha = linhas[i].Split (";");
                
                if(id.ToString () == dadosDaLinha[0]) {
                    linhas[i] = ($"{dadosDaLinha[0]};{dadosDaLinha[1]};{dadosDaLinha[2]};{dadosDaLinha[3]};{true}");
                    break;
                }
            }
            File.WriteAllLines("comentarios.csv",linhas);
        }

        public void Rejeita(int id){
            string[] linhas = File.ReadAllLines("comentarios.csv");

            for (int i = 0; i < linhas.Length; i++)
            {
                string[] dadosDaLinha = linhas[i].Split(";");

                if(id.ToString() == dadosDaLinha[0])
                {
                    linhas[i] = "";
                    break;
                }
            }

            File.WriteAllLines("comentarios.csv", linhas);
        }
    }
}