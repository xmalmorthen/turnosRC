using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace turnosAdministrator.Models.structures
{
    class RESTVentanilla {
        private RESTService rEST_Service = new RESTService();
        public RESTService REST_Service
        {
            get { return rEST_Service; }
            set { rEST_Service = value; }
        }

        private List<strctVentanilla> _response = new List<strctVentanilla>();
        public List<strctVentanilla> response
        {
            get { return _response; }
            set { _response = value; }
        }

    }

    public class strctVentanilla
    {
        int iD_Ventanilla;
        public int ID_Ventanilla
        {
            get { return iD_Ventanilla; }
            set { iD_Ventanilla = value; }
        }

        string descripcion;
        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        Boolean activa;
        public Boolean Activa
        {
            get { return activa; }
            set { activa = value; }
        }

    }
}
