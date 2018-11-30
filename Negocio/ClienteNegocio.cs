using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class ClienteNegocio
    {
        private ClienteDAL clienteDAL = new ClienteDAL();
        public ResultadoDTO CrearCliente(Cliente dto)
        {
            return clienteDAL.Crear(dto);
        }
    }
}
