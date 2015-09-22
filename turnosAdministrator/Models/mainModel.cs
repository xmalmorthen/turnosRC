using NLog;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using turnosAdministrator.Models.structures;

namespace turnosAdministrator.Models
{
    static class mainModel
    {
        private static string wsRESTFullRC = string.Format("{0}/{1}/", turnosAdministrator.Properties.Settings.Default.ApiRestCitasRC, turnosAdministrator.Properties.Settings.Default.VersionApiRestCitasRC);
        private static RestClient client = new RestClient(wsRESTFullRC);

        public static List<strctVentanilla> ventanillas()
        {
            List<strctVentanilla> response = null;
            try
            {                
                client.Timeout = turnosAdministrator.Properties.Settings.Default.RESTRequestTimeOut;
                // client.Authenticator = new HttpBasicAuthenticator(username, password);

                string method = string.Format("{0}?Oficina={1}", "obtener/ventanillas", turnosAdministrator.Properties.Settings.Default.IdOficina.ToString().Trim());

                var request = new RestRequest(method, Method.GET);
                request.AddHeader("Accept", "application/json");

                RestResponse<RESTVentanilla> ventanillas = client.Execute<RESTVentanilla>(request) as RestResponse<RESTVentanilla>;

                if (ventanillas.ResponseStatus == ResponseStatus.Completed)
                {
                    if (ventanillas.Data.REST_Service.Status_response.ToString().Trim().Equals("ok", StringComparison.CurrentCultureIgnoreCase) == true)
                    {
                        response = new List<strctVentanilla>(ventanillas.Data.response.FindAll(qry => qry.Activa == true));                        
                    }
                }
                
            }
            catch (Exception ex)
            {
                Logger logger = LogManager.GetCurrentClassLogger();
                logger.Error(ex, ex.Message);
            }
            return response;
        }

        public static List<strctTurno> turnos()
        {
            List<strctTurno> response = null;
            try
            {
                client.Timeout = turnosAdministrator.Properties.Settings.Default.RESTRequestTimeOut;
                // client.Authenticator = new HttpBasicAuthenticator(username, password);

                string method = string.Format("{0}?Oficina={1}", "obtener/ultimos3turnos", turnosAdministrator.Properties.Settings.Default.IdOficina.ToString().Trim());

                var request = new RestRequest(method, Method.GET);
                request.AddHeader("Accept", "application/json");

                RestResponse<RESTTurno> turnos = client.Execute<RESTTurno>(request) as RestResponse<RESTTurno>;

                if (turnos.ResponseStatus == ResponseStatus.Completed)
                {
                    if (turnos.Data.REST_Service.Status_response.ToString().Trim().Equals("ok", StringComparison.CurrentCultureIgnoreCase) == true)
                    {
                        response = new List<strctTurno>(turnos.Data.response);
                    }
                }

            }
            catch (Exception ex)
            {
                Logger logger = LogManager.GetCurrentClassLogger();
                logger.Error(ex, ex.Message);
            }
            return response;
        }

    }
}
