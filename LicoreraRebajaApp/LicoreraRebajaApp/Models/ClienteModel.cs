using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;


namespace LicoreraRebajaApp.Models
{
    public class ClienteModel : INotifyPropertyChanged
    {
        //Atributos
        private long idCliente;
        private string userName;
        private string password;

        [JsonProperty("valido")]
        private bool isValido;

        [JsonProperty("nombre")]
        private string nombre;

        [JsonProperty("apellido")]
        private string apellido;

        [JsonProperty("periodo")]
        private string periodo;

        [JsonProperty("emplid")]
        private string emplid;

        [JsonProperty("x-t6519fdd1s5q")]
        private string token;

        //Eventos
        public event PropertyChangedEventHandler PropertyChanged;

        //Métodos
        #region Getters/Setters
        
            public long IdCliente
            {
                get { return idCliente; }
                set
                {
                    idCliente = value;
                    OnPropertyChanged();
                }
            }

            public string UserName
            {
                get { return userName; }
                set
                {
                    userName = value;
                    OnPropertyChanged();
                }
            }

            public string Password
            {
                get { return password; }
                set
                {
                    password = value;
                    OnPropertyChanged();
                }
            }

            public string Nombre
            {
                get { return nombre; }
                set
                {
                    nombre = value;
                    OnPropertyChanged();
                }
            }

            public bool IsValido
            {
                get { return isValido; }
                set
                {
                    isValido = value;
                    OnPropertyChanged();
                }
            }

            public string Token
            {
                get { return token; }
                set
                {
                    token = value;
                    OnPropertyChanged();
                }
            }

            public string Emplid
            {
                get { return emplid; }
                set
                {
                    emplid = value;
                    OnPropertyChanged();
                }
            }

            public string Periodo
            {
                get { return periodo; }
                set {
                    periodo = value;
                    OnPropertyChanged();
            }
            }

            public string Apellido
            {
                get { return apellido; }
                set
                {
                    apellido = value;
                    OnPropertyChanged();
                }
            }

        #endregion

        public void OnPropertyChanged([CallerMemberName]string nombre = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nombre));
        }
    }
}
