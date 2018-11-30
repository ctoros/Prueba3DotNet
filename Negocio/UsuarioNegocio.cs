using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class UsuarioNegocio
    {
        private UsuarioDAL userDal = new UsuarioDAL();
        public Usuario Buscar(Usuario user)
        {
            return userDal.Buscar(user);
        }

        public Usuario Buscar(string user, string clave)
        {
            return userDal.Buscar(user, clave);
        }
    }
}
