using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dominio
{
    public class Vouchers
    {
        public string Id { get; set; }

        public int IdCliente { get; set; }

        public DateTime FechaCanje { get; set; }

        public int IdArticulo { get; set; }


    }
}