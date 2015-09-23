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
        private static string wsRESTFullRC = string.Format("{0}/{1}/", turnosDashboard.Properties.Settings.Default.ApiRestCitasRC, turnosDashboard.Properties.Settings.Default.VersionApiRestCitasRC);
        private static RestClient client = new RestClient(wsRESTFullRC);

        private static Boolean turnoChanged = false;
        public static Boolean TurnoChanged
        {
            get { return turnosModel.turnoChanged; }
            set { 
                turnosModel.turnoChanged = value;
                /*if (value == true) {
                    Program.main.refreshControls();
                }*/
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
                client.Timeout = turnosDashboard.Properties.Settings.Default.RESTRequestTimeOut;
                // client.Authenticator = new HttpBasicAuthenticator(username, password);

                string method = string.Format("{0}?Oficina={1}","obtener/turno",turnosDashboard.Properties.Settings.Default.IdOficina.ToString().Trim());

                var request = new RestRequest(method, Method.GET);
                request.AddHeader("Accept", "application/json");

                try
                {
                    asyncHandle.Abort();
                }
                catch (Exception){}

                asyncHandle = client.ExecuteAsync<RESTTurno>(request, response =>
                {
                    if (response.ResponseStatus == ResponseStatus.Completed)
                    {
                        if (response.Data.REST_Service.Status_response.ToString().Trim().Equals("ok", StringComparison.CurrentCultureIgnoreCase) == true)
                        {
                            try
                            {
                                if (TurnoActual.Ventanilla.Equals(response.Data.response.SingleOrDefault().NombreVentanilla, StringComparison.CurrentCultureIgnoreCase) == false)
                                {
                                    changeTurno(response.Data.response.SingleOrDefault().Turno, response.Data.response.SingleOrDefault().NombreVentanilla, response.Data.response.SingleOrDefault().Tramite);
                                }
                                else if (TurnoActual.Turno.Equals(response.Data.response.SingleOrDefault().Turno) == false)
                                {
                                    changeTurno(response.Data.response.SingleOrDefault().Turno, response.Data.response.SingleOrDefault().NombreVentanilla, response.Data.response.SingleOrDefault().Tramite);
                                }
                            }
                            catch (Exception)
                            {
                                changeTurno(response.Data.response.SingleOrDefault().Turno, response.Data.response.SingleOrDefault().NombreVentanilla, response.Data.response.SingleOrDefault().Tramite);                                
                            }
                            
                        }
                        else
                        {
                            throw new Exception(response.Data.REST_Service.Message.ToString());
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

        private static RestRequestAsyncHandle asyncHandle3Turnos;
        private static void changeTurno(int turno, string ventanilla, string tramite) {
            
            TurnosAtendiendo.Clear();

            try
            {
                client.Timeout = turnosDashboard.Properties.Settings.Default.RESTRequestTimeOut;
                // client.Authenticator = new HttpBasicAuthenticator(username, password);

                string method = string.Format("{0}?Oficina={1}", "obtener/ultimos3turnos", turnosDashboard.Properties.Settings.Default.IdOficina.ToString().Trim());

                var request = new RestRequest(method, Method.GET);
                request.AddHeader("Accept", "application/json");

                try
                {
                    asyncHandle3Turnos.Abort();
                }
                catch (Exception) { }

                asyncHandle3Turnos = client.ExecuteAsync<RESTTurno>(request, response =>
                {
                    if (response.ResponseStatus == ResponseStatus.Completed)
                    {
                        if (response.Data.REST_Service.Status_response.ToString().Trim().Equals("ok", StringComparison.CurrentCultureIgnoreCase) == true)
                        {
                            short cont = 0;
                            foreach (strctTurno item in response.Data.response)
	                        {
                                if (cont > 0) {                
                                    turno _item = new turno();
                                    _item.Turno = item.Turno;
                                    _item.Ventanilla = item.NombreVentanilla;
                                    _item.Tramite = item.Tramite;
                                    TurnosAtendiendo.Add(_item);
                                }
                                cont++;
	                        }
                            Program.main.refreshControls();
                        }
                        else
                        {
                            throw new Exception(response.Data.REST_Service.Message.ToString());
                        }
                    }
                });
            }
            catch (Exception ex)
            {
                Logger logger = LogManager.GetCurrentClassLogger();
                logger.Error(ex, ex.Message);
            }

            TurnoActual.Turno = turno;
            TurnoActual.Ventanilla = ventanilla;
            TurnoActual.Tramite = tramite;

            TurnoChanged = true;
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
