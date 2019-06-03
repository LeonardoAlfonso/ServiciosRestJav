using LicoreraRebajaApp.Models;
using LicoreraRebajaApp.Services.Rest;
using LicoreraRebajaApp.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LicoreraRebajaApp.ViewModels
{
    public class ClienteViewModel : ClienteModel
    {
        //Atributos
        ClienteModel cliente;
        LicoreraAPIRest servicioLicorera;
        private MensajeErrorModel mensajeError;





        //Constructores
        public ClienteViewModel()
        {
            cliente = new ClienteModel();
            servicioLicorera = new LicoreraAPIRest();
            mensajeError = new MensajeErrorModel();
            LoginCommand = new Command(async () => await Login(), () => true);
        }

        //Eventos
        public Command LoginCommand { get; set; }

        //Métodos
        public MensajeErrorModel MensajeError
        {
            get { return mensajeError; }
            set
            {
                mensajeError = value;
                OnPropertyChanged();
            }
        }

        private async Task Login()
        {
            cliente.UserName = UserName;
            cliente.Password = Password;
            MensajeError = await servicioLicorera.LoginCliente(cliente);
            //var x = await servicioLicorera.getAsignaturas();
            //Application.Current.MainPage = new NavigationPage(new Page1());
        }

    }
}
