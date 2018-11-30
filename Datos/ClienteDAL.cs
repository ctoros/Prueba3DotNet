using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class ClienteDAL
    {
        public ResultadoDTO Crear(Cliente dto)
        {
            ResultadoDTO r = new ResultadoDTO();
            try
            {
                using (PompeyoCarrasco3Entities dbo = new PompeyoCarrasco3Entities())
                {
                    dbo.Cliente.Add(dto);
                    dbo.SaveChanges();
                    r.error = false;
                    r.id = dto.idCliente;
                }
            }
            catch (Exception e)
            {
                r.error = true;
                r.mensaje = e.Message;
            }
            return r;
        }

    }
}
