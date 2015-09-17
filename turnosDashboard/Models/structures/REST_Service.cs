using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace turnosDashboard.Models.structures
{
    class RESTService
    {
        string status_response;
        public string Status_response
        {
            get { return status_response; }
            set { status_response = value; }
        }

        string message;
        public string Message
        {
            get { return message; }
            set { message = value; }
        }

        string fecha;
        public string Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

        string hora;
        public string Hora
        {
            get { return hora; }
            set { hora = value; }
        }

        string response_key;
        public string Response_key
        {
            get { return response_key; }
            set { response_key = value; }
        }

        string response_time;
        public string Response_time
        {
            get { return response_time; }
            set { response_time = value; }
        }

    }
}
