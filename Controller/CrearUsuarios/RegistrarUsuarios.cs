using Punto_de_venta.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_de_venta.Controller.CrearUsuarios
{
    public class RegistrarUsuarios
    {
        private string usuario;
        private string nombre;
        private string apellido;
        private string password;
        private PuntoVentaProyectoFinalEntities db = PuntoVentaProyectoFinalEntitiesInstance.getInstance;

        public RegistrarUsuarios()
        {

        }

        public RegistrarUsuarios(string usuario, string nombre, string apellido, string password)
        {
            this.usuario = usuario;
            this.nombre = nombre;
            this.apellido = apellido;
            this.password = password;

        }

        public Boolean validarUsuarioExiste()
        {        
            return db.Usuarios.Any(x => x.usuario == this.usuario);
        }

        public void registrar()
        {
            db.crearUsuarios(this.usuario, this.nombre, this.apellido, this.password);
            db.SaveChanges();         
        }

    }
}
