using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDionisio.Models
{
    public class Usuario : BaseModel
    {
        public string Id
        {
            get { return _Id; }

            set
            {
                if (value != this._Id)
                {
                    this._Id = value;
                    NotifyPropertyChanged();
                }
            }
        }
        private string _Id;
        public string Nome
        {
            get { return _Nome; }

            set
            {
                if (value != this._Nome)
                {
                    this._Nome = value;
                    NotifyPropertyChanged();
                }
            }
        }
        private string _Nome;
        public string Email
        {
            get { return _Email; }

            set
            {
                if (value != this._Email)
                {
                    this._Email = value;
                    NotifyPropertyChanged();
                }
            }
        }
        private string _Email;
        public string Senha
        {
            get { return _Senha; }

            set
            {
                if (value != this._Senha)
                {
                    this._Senha = value;
                    NotifyPropertyChanged();
                }
            }
        }private string _Senha;

        [JsonIgnore]
        private string _ConfirmarSenha;
        [JsonIgnore]
        public string ConfirmarSenha
        {
            get { return _ConfirmarSenha; }

            set
            {
                if (value != this._ConfirmarSenha)
                {
                    this._ConfirmarSenha = value;
                    NotifyPropertyChanged();
                }
            }
        }
        
        public string Facebook
        {
            get { return _Facebook; }

            set
            {
                if (value != this._Facebook)
                {
                    this._Facebook = value;
                    NotifyPropertyChanged();
                }
            }
        }
        private string _Facebook;
    }
}
