using System;
using SistemaGestionData;
using SistemaGestionData.Context;
using SistemaGestionEntities;

namespace SistemaGestionData.DataAccess;

public class UsuarioDataAccess
{
    private SistemaGestionContext _context;

    public UsuarioDataAccess(SistemaGestionContext context)
    {
        _context = context;
    }

    public List<Usuario> GetUsuarios()
    {
        return _context.Usuario.ToList();
    }

    public List<Usuario> GetUsuariosBy(string filtro)
    {
        return _context.Usuario
            .Where(Usuario => Usuario.NombreUsuario.Contains(filtro))
            .ToList();
    }

    public Usuario? GetOneUsuario(int id)
    {
        return _context.Usuario.FirstOrDefault(Usuario => Usuario.Id == id);
    }

    public void UpdateUsuario(int id, Usuario Usuario)
    {
        Usuario? usuarioAEditar = GetOneUsuario(id);
        if (usuarioAEditar != null)
        {
            usuarioAEditar.Nombre = Usuario.Nombre ;
            usuarioAEditar.Apellido = Usuario.Apellido ;
            usuarioAEditar.NombreUsuario = Usuario.NombreUsuario ;
            usuarioAEditar.Contraseña = Usuario.Contraseña ;
            usuarioAEditar.Email = Usuario.Email;

            _context.SaveChanges();
        }
    }

    public void InsertUsuario(Usuario Usuario)
    {
        _context.Usuario.Add(Usuario);
        _context.SaveChanges();
    }

    public void DeleteUsuario(int id)
    {
        Usuario? usuarioAEliminar = GetOneUsuario(id);
        if (usuarioAEliminar != null)
        {
            _context.Usuario.Remove(usuarioAEliminar);
            _context.SaveChanges();
        }
    }

}
