using NLog;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using turnosDashboard.Models.structures;

namespace turnosDashboard.Models
{
    static class turnosModel
    {
        private static Boolean turnoChanged = false;
        public static Boolean TurnoChanged
        {
            get { return turnosModel.turnoChanged; }
            set { 
                turnosModel.turnoChanged = value;
                if (value == true) {
                    Program.main.refreshControls();
                }
            }
        }

        private static turno turnoActual = new turno();
        public static turno TurnoActual
        {
            get { return turnosModel.turnoActual; }
            set { turnosModel.turnoActual = value; }
        }

        private static List<turno> turnosAtendiendo = new List<turno>();
        public static List<turno> TurnosAtendiendo
        {
            get { return turnosModel.turnosAtendiendo; }
            set { turnosModel.turnosAtendiendo = value; }
        }

        private static RestRequestAsyncHandle asyncHandle;
        public static Boolean turnoState(){
            try
            {
                string wsRESTFullRC = string.Format("{0}/{1}/", turnosDashboard.Properties.Settings.Default.ApiRestCitasRC, turnosDashboard.Properties.Settings.Default.VersionApiRestCitasRC);

                RestClient client = new RestClient(wsRESTFullRC);
                client.Timeout = 2000;

                // client.Authenticator = new HttpBasicAuthenticator(username, password);

                string method = string.Format("{0}?Oficina={1}","obtener/turno",turnosDashboard.Properties.Settings.Default.IdOficina.ToString().Trim());

                var request = new RestRequest(method, Method.GET);

                // easily add HTTP Headers
                request.AddHeader("Accept", "application/json");

                try
                {
                    asyncHandle.Abort();
                }
                catch (Exception){}
                
                asyncHandle = client.ExecuteAsync<strctTurno>(request, response =>
                {
                    if (response.ResponseStatus == ResponseStatus.Completed)
                    {
                        if (TurnoActual.Turno != response.Data.Turno)
                        {
                            turno item = new turno();
                            item.Turno = TurnoActual.Turno;
                            item.Ventanilla = TurnoActual.Ventanilla;
                            item.Tramite = TurnoActual.Tramite;
                            TurnosAtendiendo.Add(item);

                            TurnoActual.Turno = response.Data.Turno;
                            TurnoActual.Ventanilla = response.Data.NombreVentanilla;
                            TurnoActual.Tramite = response.Data.Tramite;

                            turnoChanged = true;
                        }
                        else
                        {
                            turnoChanged = false;
                        }
                    }
                });
            }
            catch (Exception ex)
            {
                Logger logger = LogManager.GetCurrentClassLogger();
                logger.Error(ex, ex.Message);
                return false; 
            }
            return true;
        }
    }

    class turno{
        private  int _turno;
        public  int Turno
        {
            get { return _turno; }
            set { _turno = value; }
        }

        private  string ventanilla;
        public  string Ventanilla
        {
            get { return ventanilla; }
            set { ventanilla = value; }
        }

        private string tramite;
        public string Tramite
        {
            get { return tramite; }
            set { tramite = value; }
        }
    }

}
