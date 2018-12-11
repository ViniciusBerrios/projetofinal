using System;

namespace checkpoint.Models
{
    public class ComentarioModel{
        public UsuarioModel Usuario {get; set;}

        public string Texto {get; set;}

        public DateTime DataCriacao {get; set;}

        public int ID {get; set;}

        public bool Status {get; set;}

        public string Nome {get; set;}

        public ComentarioModel (string nome,string texto, DateTime dataCriacao,bool status)
        {
            this.Nome = nome;
            this.Texto = texto;
            this.DataCriacao = dataCriacao;
            this.Status = status;
        }

        public ComentarioModel (int id, string nome,string texto, DateTime dataCriacao,bool status)
        {
            this.ID = id;
            this.Nome = nome;
            this.Texto = texto;
            this.DataCriacao = dataCriacao;
            this.Status = status;
        }
}
}