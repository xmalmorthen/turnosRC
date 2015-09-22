using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace turnosAdministrator.Models.structures
{
    class RESTTurno {
        private RESTService rEST_Service = new RESTService();
        public RESTService REST_Service
        {
            get { return rEST_Service; }
            set { rEST_Service = value; }
        }

        private List<strctTurno> _response = new List<strctTurno>();
        public List<strctTurno> response
        {
            get { return _response; }
            set { _response = value; }
        }

    }

    class strctTurno
    {
        int turno;
        public int Turno
        {
            get { return turno; }
            set { turno = value; }
        }

        string folio;
        public string Folio
        {
            get { return folio; }
            set { folio = value; }
        }

        short idVentanilla;
        public short IdVentanilla
        {
            get { return idVentanilla; }
            set { idVentanilla = value; }
        }

        string nombreVentanilla;
        public string NombreVentanilla
        {
            get { return nombreVentanilla; }
            set { nombreVentanilla = value; }
        }

        string fechaCita;
        public string FechaCita
        {
            get { return fechaCita; }
            set { fechaCita = value; }
        }

        string horario;
        public string Horario
        {
            get { return horario; }
            set { horario = value; }
        }

        string fechaRegistro;
        public string FechaRegistro
        {
            get { return fechaRegistro; }
            set { fechaRegistro = value; }
        }

        string horaRegistro;
        public string HoraRegistro
        {
            get { return horaRegistro; }
            set { horaRegistro = value; }
        }

        short idTramite;
        public short IdTramite
        {
            get { return idTramite; }
            set { idTramite = value; }
        }

        string tramite;
        public string Tramite
        {
            get { return tramite; }
            set { tramite = value; }
        }

        string cURP;
        public string CURP
        {
            get { return cURP; }
            set { cURP = value; }
        }
    }
}
