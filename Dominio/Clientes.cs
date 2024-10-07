using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dominio
{
    public class Clientes
    {
        public int Id { get; set; }
        public string Documento { get; set; }

        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public string Email { get; set; }
        //{
        //    get { return Email; }
        //    set
        //    {
        //        if (value != "")
        //            Email = value;
        //        else
        //            throw new Exception("email vacío en el dominio...");
        //    }
        //}
        public string Direccion { get; set; }
        public string Ciudad { get; set; }

        public int CP { get; set; }

 
    }
}