using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace turnosAdministrator.Models.structures
{
    class RESTSession {
        private RESTService rEST_Service = new RESTService();
        public RESTService REST_Service
        {
            get { return rEST_Service; }
            set { rEST_Service = value; }
        }

        private List<strctSession> _response = new List<strctSession>();
        public List<strctSession> response
        {
            get { return _response; }
            set { _response = value; }
        }

    }

    class strctSession
    {
        string success;
        public string Success
        {
            get { return success; }
            set { success = value; }
        }

        string mensaje;
        public string Mensaje
        {
            get { return mensaje; }
            set { mensaje = value; }
        }

        string nombre_Completo;
        public string Nombre_Completo
        {
            get { return nombre_Completo; }
            set { nombre_Completo = value; }
        }

        string correo;
        public string Correo
        {
            get { return correo; }
            set { correo = value; }
        }

        string fecha;
        public string Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

        string oficina;
        public string Oficina
        {
            get { return oficina; }
            set { oficina = value; }
        }

    }
}
