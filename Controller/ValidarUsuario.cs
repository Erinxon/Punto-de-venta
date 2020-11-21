using Punto_de_venta.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_de_venta.Controller
{
    public class ValidarUsuario
    {
        private string usuario;
        private string password;
        private PuntoVentaProyectoFinalEntities db = PuntoVentaProyectoFinalEntitiesInstance.getInstance;

        public ValidarUsuario()
        {

        }

        public ValidarUsuario(string usuario, string password)
        {
            this.usuario = usuario;
            this.password = password;
        }

        public Boolean validarUser()
        {
            return db.Usuarios.Any(x => x.usuario == this.usuario);
        }

        public Boolean validarPassword()
        {
            return db.Usuarios.Any(x => x.usuario == this.usuario && x.pass == this.password);
        }


    }
}
