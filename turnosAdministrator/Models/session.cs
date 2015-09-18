using NLog;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using turnosAdministrator.Models.structures;

namespace turnosAdministrator.Models
{
    static class session
    {
        public static void isValid(string usr, string pwd, turnosAdministrator.frmLogIn.callBackFunc callBack)
        {            
            Boolean response = false; 
            string message = "Usuario y/o contraseña incorrectos";
            try
            {
                string wsRESTFullRC = string.Format("{0}/{1}/", turnosAdministrator.Properties.Settings.Default.ApiRestCitasRC, turnosAdministrator.Properties.Settings.Default.VersionApiRestCitasRC);
                var client = new RestClient(wsRESTFullRC);
                // client.Authenticator = new HttpBasicAuthenticator(username, password);

                byte[] buffer = System.Text.Encoding.UTF8.GetBytes(pwd);
                SHA1CryptoServiceProvider cryptoTransformSHA1 = new SHA1CryptoServiceProvider();
                string hashPWD = BitConverter.ToString(cryptoTransformSHA1.ComputeHash(buffer)).Replace("-", "");

                string method = string.Format("{0}?Oficina={1}&Usr={2}&Cnn={3}", "valida/usuario", turnosAdministrator.Properties.Settings.Default.IdOficina.ToString().Trim(), usr, hashPWD);

                var request = new RestRequest(method, Method.GET);
                request.AddHeader("Accept", "application/json");

                RestRequestAsyncHandle asyncHandle = client.ExecuteAsync<RESTSession>(request, RestResponse =>
                {
                    if (RestResponse.ResponseStatus == ResponseStatus.Completed)
                    {
                        if (RestResponse.Data.REST_Service.Status_response.ToString().Trim().Equals("ok", StringComparison.CurrentCultureIgnoreCase) == true)
                        {
                            if (RestResponse.Data.response[0].Success.Equals("1", StringComparison.CurrentCultureIgnoreCase) == true)
                            {
                                response = true;
                            }
                        }
                    }
                    callBack(response, message);
                });
            }
            catch (Exception ex)
            {
                Logger logger = LogManager.GetCurrentClassLogger();
                logger.Error(ex, ex.Message);
            }
        }
    }
}
