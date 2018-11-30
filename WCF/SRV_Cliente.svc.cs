using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Entidades;

namespace WCF
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "SRV_Cliente" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione SRV_Cliente.svc o SRV_Cliente.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class SRV_Cliente : ISRV_Cliente
    {
        public ResultadoDTO CrearCliente(string rut, string nombre, string direccion, string giro)
        {
            throw new NotImplementedException();
        }
    }
}
