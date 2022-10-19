using System.Linq;
using System.Collections.Generic;


namespace Biblioteca.Models
{

public class UsuarioService
{

    public List<Usuario> Listar()
    {

        using (BibliotecaContext bc = new BibliotecaContext())
        {
            return bc.Usuarios.ToList();
        }

    }

// INSERIR

    public void incluirUsuario (Usuario user)
    {

        using (BibliotecaContext bc = new BibliotecaContext())
        {
            bc.Usuarios.Add(user);
            bc.SaveChanges();
        }

    }

// EDITAR

    public void editarUsuario (Usuario userEditado)
    {

        using (BibliotecaContext bc = new BibliotecaContext())
        {
            Usuario u = bc.Usuarios.Find(userEditado.Id);
            
            u.Nome = userEditado.Nome;
            u.Login = userEditado.Login;

            if(u.Senha != userEditado.Senha)
            {
               u.Senha = Criptografo.TextoCriptografado(userEditado.Senha); 
            }
            else
            {
                u.Senha = userEditado.Senha;
            }

            u.Tipo = userEditado.Tipo;
            bc.SaveChanges();
        }
        
    }

// EXCLUIR
    public void excluirUsuario (int id)
    {
        using (BibliotecaContext bc = new BibliotecaContext())
        {
           bc.Usuarios.Remove(bc.Usuarios.Find(id));
           bc.SaveChanges();
        }
    }

// BUSCAR POR ID
    public Usuario buscarPorId (int id)
    {
        using (BibliotecaContext bc = new BibliotecaContext())
        {
            return bc.Usuarios.Find(id);
        }
    }

}
}