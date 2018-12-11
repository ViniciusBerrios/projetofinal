using System.Collections.Generic;
using checkpoint.Models;

namespace checkpoint.Interfaces
{
    public interface IComentario
    {
         void CadastrarComentario (ComentarioModel comentario);

         List<ComentarioModel> ComentarioCSV(string idNome);

         void Aprova(int id);

         void Rejeita(int id);
    }
}