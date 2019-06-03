using LicoreraRebajaApp.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace LicoreraRebajaApp.Services.Rest
{
    public class LicoreraAPIRest
    {
        //Constantes

        public const string BaseUrl = "http://replica.javerianacali.edu.co:8100/WSMobile/mobile/v2";
        public const string LoginUrl = "/Autenticacion/?";

        //Atributos

        private readonly HttpClient client;
        private MensajeErrorModel mensajeError;

        //Constructores
        public LicoreraAPIRest()
        {
            client = new HttpClient();
            mensajeError = new MensajeErrorModel();
        }

        //Metodos
        #region Getter/Setters
            public MensajeErrorModel MensajeError
            {
                get { return mensajeError; }
                set { mensajeError = value; }
            }
        #endregion

        public async Task<MensajeErrorModel> LoginCliente(ClienteModel cliente)
        {
            try
            {
                Dictionary<string, string> queryParameters = new Dictionary<string, string>();
                queryParameters.Add("usu", cliente.UserName);
                queryParameters.Add("pass", cliente.Password);

                var queryString = new FormUrlEncodedContent(queryParameters);
                //var url = BaseUrl + LoginUrl + queryString.ReadAsStringAsync().Result;
                var url = BaseUrl + queryString.ReadAsStringAsync().Result;

                var content = await client.GetStringAsync(url);
                ClienteModel loginCliente = JsonConvert.DeserializeObject<ClienteModel>(content);

                if(loginCliente.IsValido)
                {
                    mensajeError.Message = "Exitoso";
                    mensajeError.HasError = false;
                }
                else
                {
                    mensajeError.Message = "Credenciales no Validas";
                    mensajeError.HasError = true;
                }
            }
            catch(HttpRequestException e)
            {
                mensajeError.Message = "Error de comunicación";
                mensajeError.HasError = true;
            }

            return mensajeError;

        }

        public async Task<string> getAsignaturas()
        {
            string content = "";

            var url = "http://replica.javerianacali.edu.co:8100/WSMobile/mobile/v2/asignaturas";
            client.DefaultRequestHeaders.Add("x-t6519fdd1s5q", "eyJhbGciOiJIUzUxMiJ9.eyJleHAiOjE1NTk3NTE0MDUsInN1YiI6ImVucmlxdWVwYXJpcyJ9.C2MJ5EYGhCXVIny3OVlhgtBZJv0Ddn56gP07qV-BKiYlL8-2AzyjyqONhCZ3egre85HjgNR5ai0Gy-N919Cgvg");    ;
            content = await client.GetStringAsync(url);

            return content;
        }







    }
}
