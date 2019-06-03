using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace LicoreraRebajaApp.Models
{
    public class MensajeErrorModel : INotifyPropertyChanged
    {
        //Atributos
        private string message;
        private bool hasError = false;

        public event PropertyChangedEventHandler PropertyChanged;

        //Métodos
        #region Getters/Setters
            public string Message
            {
                get { return message; }
                set
                {
                    message = value;
                    OnPropertyChanged();
                }
            }
            public bool HasError
            {
                get { return hasError; }
                set
                {
                    hasError = value;
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
