using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class UsuarioDAL
    {


        public ResultadoDTO Crear(Usuario dto)
    {
        ResultadoDTO r = new ResultadoDTO();
        try
        {
            using (PompeyoCarrasco3Entities dbo = new PompeyoCarrasco3Entities())
            {
                dbo.Usuario.Add(dto);
                dbo.SaveChanges();
                r.error = false;
                r.id = dto.idUsuario;
            }
        }
        catch (Exception e)
        {
            r.error = true;
            r.mensaje = e.Message;
        }
        return r;
    }

    public Usuario Buscar(Usuario user)
    {
        Usuario usuario = new Usuario();
        using (PompeyoCarrasco3Entities dbo = new PompeyoCarrasco3Entities())
        {
            usuario = dbo.Usuario.FirstOrDefault(u => u.nombreUsuario == user.nombreUsuario
                && u.contrasena == user.contrasena);
        }
        return usuario;

    }

    public Usuario Buscar(string user, string clave)
    {
        Usuario usuario = new Usuario();
        using (PompeyoCarrasco3Entities dbo = new PompeyoCarrasco3Entities())
        {
            usuario = dbo.Usuario.FirstOrDefault(u => u.nombreUsuario == user
                && u.contrasena == clave);
        }
        return usuario;

    }

    public List<Lista> Listar()
    {
        List<Lista> lista = new List<Lista>();
        using (PompeyoCarrasco3Entities dbo = new PompeyoCarrasco3Entities())
        {
            lista = (from l in dbo.Usuario
                     select
                     new Lista { id = l.idUsuario, texto = l.nombreUsuario }).ToList();
        }
        return lista;
    }
}
}