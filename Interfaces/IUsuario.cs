using System.Collections.Generic;
using checkpoint.Models;

namespace checkpoint.Interfaces{
    public interface IUsuario
    {
        UsuarioModel Cadastrar(UsuarioModel usuario);

        List<UsuarioModel> Listar();

        UsuarioModel BuscarPorEmailESenha(string email, string senha);

        UsuarioModel BuscarPorID(int id);
    }
}