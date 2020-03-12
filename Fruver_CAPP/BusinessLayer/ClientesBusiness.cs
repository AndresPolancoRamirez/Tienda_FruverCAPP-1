using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using DataLayer;

namespace BusinessLayer
{
    public class ClientesBusiness
    {
        public static bool GuardarCliente(Clientes_Entity cliente)
        {
            return ClientesData.GuardarCliente(cliente);
        }
    public static List<Clientes_Entity> ObtenerClientes()
    {
        return ClientesData.ObtenerClientes();
    }
    
    }



}
